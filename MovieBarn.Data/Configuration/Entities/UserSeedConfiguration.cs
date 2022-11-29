using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Data.Configuration.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            var passwordHasher = new PasswordHasher<IdentityUser>();
            builder.HasData(
                new IdentityUser
                {
                    Id = "807d4075-6fa0-465e-aa89-6255708fde21",
                    Email = "admin@localhost.com",
                    UserName = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    PasswordHash = passwordHasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true          
                }    
            );
        }
    }
}
