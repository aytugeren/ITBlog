using ITBlog.Entities.Concrete.AuthorFolder;
using ITBlog.Entities.Concrete.EntityFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Entities.Concrete.SocialMediaFolder
{
    public class SocialMedia : BaseEntity
    {
        public string? SocialMediaName { get; set; }

        public string? SocialMediaUrl { get; set; }

        public string? SocialMediaIconAsHtml { get; set; }

        public string? SocialMediaButtonClass { get; set; }

        public ICollection<Author> Authors { get; set; }
    }
}
