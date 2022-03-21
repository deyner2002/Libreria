using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Identity.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        

        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId= "6467448c-ffb9-4005-b927-fde2d7d4509d",
                    UserId= "db71af91-1f22-4aee-b416-e85bb36cccd6"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "ea6cd61e-2ed8-4b8b-b1cf-d1d6f3da293f",
                    UserId = "672fe068-0696-4273-8643-c769cac19836"
                }

                );
        }
    }
}
