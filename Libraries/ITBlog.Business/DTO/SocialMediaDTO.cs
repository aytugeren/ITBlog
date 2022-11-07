using ITBlog.Entities.Concrete.AuthorFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.DTO
{
    public class SocialMediaDTO : BaseDTO
    {
        public string? SocialMediaName { get; set; }

        public string? SocialMediaUrl { get; set; }

        public string? SocialMediaIconAsHtml { get; set; }
        public string? SocialMediaButtonClass { get; set; }

        public ICollection<AuthorDTO> Authors { get; set; }
    }
}
