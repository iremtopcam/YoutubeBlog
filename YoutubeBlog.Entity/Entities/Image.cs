using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Core.Entitites;

namespace YoutubeBlog.Entity.Entities
{
    public class Image : EntityBase
    {

        public Image()
        
        {
        
        }


        public Image(string fileName,string  fileType) 
        
        {
            FileName = fileName;
            FileType = fileType;
        
        
        }

        //public Guid Id { get; set; } 
        public string FileName { get; set; } 
        public string FileType { get; set; } 
        public ICollection<Article> Articles { get; set; } 

        public ICollection<AppUser> AppUsers { get; set; }

        




    }
}
