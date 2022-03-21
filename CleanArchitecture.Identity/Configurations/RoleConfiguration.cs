using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Identity.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "6467448c-ffb9-4005-b927-fde2d7d4509d",
                    Name = "Administrador",
                    NormalizedName="ADMINISTRADOR"
                },
                new IdentityRole
                {
                    Id = "ea6cd61e-2ed8-4b8b-b1cf-d1d6f3da293f",
                    Name = "Operador",
                    NormalizedName = "OPERADOR"
                }

                ) ;
        }
    }
}
