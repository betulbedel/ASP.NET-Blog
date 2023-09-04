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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
     

        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("7418FB6D-17C3-486E-93F6-0623C7B98730"),
                Name = "asp.net ile test",
                CreatedBy = "betus test",
                CreatedDate = DateTime.Now,
                IsDeleted = false

            },

            new Category
            {
                Id = Guid.Parse("17EA0DA3-F0AF-40FD-AEB9-62436552B0C6"),
                Name = "asp.net ile test2",
                CreatedBy = "betus test2",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            });
           
        }
    }
}
