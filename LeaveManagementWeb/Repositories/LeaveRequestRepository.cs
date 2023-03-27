using AutoMapper;
using LeaveManagementWeb.Contracts;
using LeaveManagementWeb.Data;
using LeaveManagementWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LeaveManagementWeb.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>,ILeaveRequestRepository

    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly ILeaveAllocationRepository leaveAllocationRepository;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly UserManager<Employee> userManager;
        
        public LeaveRequestRepository(ApplicationDbContext context,
            IMapper mapper,ILeaveAllocationRepository leaveAllocationRepository,
           IHttpContextAccessor httpContextAccessor, UserManager<Employee> userManager ) : base(context)
        {
            this.context = context;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            this.leaveAllocationRepository = leaveAllocationRepository; 
            this.userManager = userManager;
        }

        public async Task CancelLeaveRequest(int leaveRequestId)
        {
            var leaveRequest = await GetAsync(leaveRequestId);
            leaveRequest.Cancelled = true;
            await UpdateAsync(leaveRequest);
        }

        public async Task ChangeApprovalStatus(int leaveRequestId, bool approved)
        {
            var leaveRequest = await GetAsync(leaveRequestId);
            leaveRequest.Approved = approved;
            if (approved)
            {
                var allocation = await leaveAllocationRepository.GetEmployeeAllocation(leaveRequest.RequestingEmployeeId,leaveRequest.LeaveTypeId);
                int daysRequested = (int)(leaveRequest.EndDate - leaveRequest.StartDate).TotalDays;
                allocation.NumberOfDays -= daysRequested;

                
                await leaveAllocationRepository.UpdateAsync(allocation);
            }
            await UpdateAsync(leaveRequest);            
        }

        public async Task<bool> CreateLeaveRequest(LeaveRequestCreateVM model)
        {
            var user = await userManager.GetUserAsync(httpContextAccessor?.HttpContext?.User);
            var leaveAllocation = await leaveAllocationRepository.GetEmployeeAllocation(user.Id,  model.LeaveTypeId);
           if (leaveAllocation == null)
            {
                return false;   
            }
            int daysRequested = (int)(model.EndDate.Value - model.StartDate.Value).TotalDays;

            if(daysRequested > leaveAllocation.NumberOfDays)
            {
                return false;
            }
            var leaveRequest = mapper.Map<LeaveRequest>(model);

            leaveRequest.DateCreated = DateTime.Now;
            leaveRequest.RequestingEmployeeId = user.Id;
            await AddAsync(leaveRequest); 
            return true;    
        }

        public async Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList()
        {
          var leaveRequests = await context.LeaveRequests
                .Include(q => q.LeaveType).ToListAsync();
            // var leaveRequests = await GetAllAsync();
            

            var model = new AdminLeaveRequestViewVM
            {
                TotalRequests = leaveRequests.Count,
                ApprovedRequests = leaveRequests.Count(q => q.Approved == true),
                PendingRequests = leaveRequests.Count(q => q.Approved == null),
                RejectedRequests = leaveRequests.Count(q => q.Approved == false),
                LeaveRequests = mapper.Map<List<LeaveRequestVM>>(leaveRequests)
            };
            foreach (var leaveRequest in model.LeaveRequests)
            {
                leaveRequest.Employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(leaveRequest.RequestingEmployeeId));
            }
            return model;
        }
        public async Task<List<LeaveRequest>> GetAllAsync(string employeeId)
        {
            //I added this line  .Include(q => q.LeaveType)     otherwise it does not show LeaveType.Name
            return await context.LeaveRequests
                 .Include(q => q.LeaveType)
                .Where(q => q.RequestingEmployeeId == employeeId).ToListAsync();     
        }

        public async Task<LeaveRequestVM?> GetLeaveRequestAsync(int? id)
        {
            var leaveRequest = await context.LeaveRequests
                .Include (q => q.LeaveType)
                .FirstOrDefaultAsync(q => q.Id == id);
            if (leaveRequest == null)
            {
                return null;    
            }
            var model = mapper.Map<LeaveRequestVM>(leaveRequest);
            model.Employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(leaveRequest?.RequestingEmployeeId));
            return model;
        }

        public async Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails()
        {
            var user = await userManager.GetUserAsync(httpContextAccessor?.HttpContext?.User);
            var allocations = (await leaveAllocationRepository.GetEmployeeAllocations(user.Id)).LeaveAllocations;
           
            var requests = mapper.Map <List<LeaveRequestVM>> (await GetAllAsync(user.Id));
           
            var model = new EmployeeLeaveRequestViewVM(allocations, requests);
            return model;
        }
    }
}