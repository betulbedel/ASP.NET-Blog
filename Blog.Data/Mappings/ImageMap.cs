using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id = Guid.Parse("F2CF9CAF-CD2C-48CA-BC56-4E2A801B9CE9"),
                FileName = "images//testimage",
                FileType = "jpg",
                CreatedBy = "betus test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Image
            {
                Id = Guid.Parse("A74D2084-384C-4722-9841-FFDC36C0A632"),
                FileName = "images//testimagei",
                FileType = "png",
                CreatedBy = "betus test2",
                CreatedDate = DateTime.Now,
                IsDeleted = false

            }



            );
        }
    }
}
