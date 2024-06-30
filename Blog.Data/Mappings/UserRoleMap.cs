using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId= Guid.Parse("46EE56BE-1ECD-4A21-B037-637B1D4A8F4C"),
                RoleId= Guid.Parse("7EB45983-A427-48BF-9FF4-10659343066A")

            },
            new AppUserRole
            {
                UserId = Guid.Parse("E308D56D-BBBD-45F7-B439-6EF0355BCAC1"),
                RoleId = Guid.Parse("77C8DBD9-367B-4154-993A-F85B353144B5")

            }
            
            );
        }
    }
}
