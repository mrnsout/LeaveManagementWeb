using LeaveManagementWeb.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementWeb.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {        
public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
               new Employee
               {
                   Id = "9470d59e-dab9-4543-8ea6-9773b55e0512",
                   Email = "admin@localhost.com",
                   NormalizedEmail = "ADMIN@LOCALHOST.COM",
                   NormalizedUserName = "ADMIN@LOCALHOST.COM",
                   UserName = "admin@localhost.com",
                   Firstname = "System",
                   Lastname = "Admin",
                   PasswordHash = hasher.HashPassword(null, "@Password1"),
                   EmailConfirmed= true
               },
                new Employee
                {
                    Id ="966abaa5 - fc9d - 47c0 - b129 - 5fb8ce7bd950",
                    Email = "user@localhost.com",
                    NormalizedEmail = "USER@LOCALHOST.COM",
                    NormalizedUserName = "USER@LOCALHOST.COM",
                    UserName = "user@localhost.com",
                    Firstname = "System",
                    Lastname = "User",
                    PasswordHash = hasher.HashPassword(null, "@Password1"),
                    EmailConfirmed= true
                }
            );
         }
    }
}