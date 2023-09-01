using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Core.Entitites;

namespace YoutubeBlog.Entity.Entities
{
    public class AppUser : IdentityUser<Guid>,IEntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Guid ImageId { get; set; } = Guid.Parse("AF8E62F4-0625-4AAA-B3B1-29E13C8C59B5");

        public Image Image { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
