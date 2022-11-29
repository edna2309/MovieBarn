using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieBarn.Common.Constants;

namespace StudentManagementSystem.Data.Configuration.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "88105423-d222-48ec-85c5-04e4f3cb2aa6",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                }); 
        }
    }
}
