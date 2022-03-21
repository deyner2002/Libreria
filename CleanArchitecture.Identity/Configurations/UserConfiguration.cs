using CleanArchitecture.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Identity.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = "db71af91-1f22-4aee-b416-e85bb36cccd6",
                    Email="admin@gmail.com",
                    NormalizedEmail = "admin@gmail.com",
                    Nombre="deyner",
                    Apellidos="solano",
                    UserName= "deynersolano",
                    NormalizedUserName="deynersolano",
                    PasswordHash= hasher.HashPassword(null, "Deiner.2002"),
                    EmailConfirmed=true,

                },
                new ApplicationUser
                {
                    Id = "672fe068-0696-4273-8643-c769cac19836",
                    Email = "solano27deiner@gmail.com",
                    NormalizedEmail = "solano27deiner@gmail.com",
                    Nombre = "dey",
                    Apellidos = "solanoo",
                    UserName = "deysolanoo",
                    NormalizedUserName = "deysolanoo",
                    PasswordHash = hasher.HashPassword(null, "Deiner.2002"),
                    EmailConfirmed = true,

                }


                );
        }
    }
}
