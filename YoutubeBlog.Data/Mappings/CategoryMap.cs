using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            { 
                Id = Guid.Parse("D79233C4-26FD-4C4C-B51A-140D7BC62D61"),
                Name = "ASP.net Core",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            },
           


            new Category 
            {
               
                    Id = Guid.Parse("22CD830C-16C4-4AC1-9D1F-8E0B0686AD68"),
                    Name = "ASP.net Core",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                
            });
           
        }
    }
}
