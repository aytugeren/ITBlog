using ITBlog.Entities.Concrete.AuthorFolder;
using ITBlog.Entities.Concrete.EntityFolder;
using ITBlog.Entities.Concrete.PostFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Entities.Concrete.PictureFolder
{
    public class Picture : BaseEntity
    {
        public string? PictureName { get; set; }

        public string? PictureUrl { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

        public string? PicturePlace { get; set; }

        public string? PictureAltName { get; set; }

        public string? PictureFilePath { get; set; }

        public string? PictureExtension { get; set; }

        public string? PictureTitle { get; set; }

        public string? PictureContent { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

        public virtual ICollection<Author> Authors { get; set; }
    }
}
