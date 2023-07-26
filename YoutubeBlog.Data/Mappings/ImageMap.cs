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
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                


                    Id = Guid.Parse("AF8E62F4-0625-4AAA-B3B1-29E13C8C59B5"),
                    FileName = "images/testimage",
                    FileType = "jpg",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
            },
            
            new Image
            {
                

                    Id = Guid.Parse("9C41643F-A6AF-4621-8110-82BC6254AAD8"),
                    FileName = "images/vstest",
                    FileType = "png",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,



            });
        }
    }
}
