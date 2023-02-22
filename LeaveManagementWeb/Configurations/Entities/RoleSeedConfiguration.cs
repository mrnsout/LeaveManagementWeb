using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Construction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Xml.Linq;
using LeaveManagementWeb.Constants;



namespace LeaveManagementWeb.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
               new IdentityRole
               {
                   Id = "fb6e2be8-433a-4aa8-a370-940f8c528e61",
                   Name = Roles.Administrator,
                   NormalizedName = Roles.Administrator.ToUpper()
               },
                new IdentityRole
                {
                    Id = "966abaa5 - fc9d - 47c0 - b129 - 5fb8ce7bd950",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                }
                );
        }
    }
}