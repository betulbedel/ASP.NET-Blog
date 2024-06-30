using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id =Guid.NewGuid(),
                Title= "deneme makalesiii",
                Content= "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ViewCount=15,
                CategoryId= Guid.Parse("7418FB6D-17C3-486E-93F6-0623C7B98730"),
              
                ImageId= Guid.Parse("F2CF9CAF-CD2C-48CA-BC56-4E2A801B9CE9"),
                CreatedBy ="betus",
                CreatedDate= DateTime.Now,
                IsDeleted = false,
                UserId= Guid.Parse("46EE56BE-1ECD-4A21-B037-637B1D4A8F4C")


            },
            new Article {
                Id = Guid.NewGuid(),
                Title = "deneme makalesiii 2",
                Content = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source.",
                ViewCount = 15,
                CategoryId =Guid.Parse("17EA0DA3-F0AF-40FD-AEB9-62436552B0C6"),
                ImageId=Guid.Parse("A74D2084-384C-4722-9841-FFDC36C0A632"),
                CreatedBy = "betus2",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("E308D56D-BBBD-45F7-B439-6EF0355BCAC1")


            }
            );
        }
    }
}
