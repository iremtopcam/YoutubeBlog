using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            //builder.Property(x => x.Title).HasMaxLength(150);
            //null yapiyor
            //builder.Property(x => x.Title).IsRequired(false);

            builder.HasData(new Article
            {
                Id=Guid.NewGuid(),
                Title ="Asp.net Core Deneme Makalesi 1",
                Content ="lorem ipsum lalalalalalaalaala",
                ViewCount=15,
                CategoryId = Guid.Parse("D79233C4-26FD-4C4C-B51A-140D7BC62D61"),

                ImageId =Guid.Parse("AF8E62F4-0625-4AAA-B3B1-29E13C8C59B5"),
                CreatedBy="Admin Test",
                CreatedDate=DateTime.Now,
                IsDeleted=false,

               


            },
            new Article
            {
                 Id=Guid.NewGuid(),  
                Title = "Visual Studio  Deneme Makalesi 1",
                Content = "Visual Studio lorem ipsum lalalalalalaalaala",
                ViewCount = 15,
                CategoryId= Guid.Parse("D79233C4-26FD-4C4C-B51A-140D7BC62D61"),
                ImageId= Guid.Parse("AF8E62F4-0625-4AAA-B3B1-29E13C8C59B5"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,

            }




         

            );
        }
    }
}
