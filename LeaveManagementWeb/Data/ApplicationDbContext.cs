using LeaveManagementWeb.Configurations.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LeaveManagementWeb.Models;

namespace LeaveManagementWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeedConfiguration());

            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
        }

        public DbSet<LeaveType> LeaveTypes { get; set; }

        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }

        public DbSet<LeaveManagementWeb.Models.LeaveAllocationEditVM> LeaveAllocationEditVM { get; set; }
        //It was scaffolded. We do not need this. Delete it!
        //public DbSet<LeaveManagementWeb.Models.EmployeeListVM> EmployeeListVM { get; set; }
       // public DbSet<LeaveManagementWeb.Models.EmployeeAllocationVM> EmployeeAllocationVM { get; set; }

      
    }
}