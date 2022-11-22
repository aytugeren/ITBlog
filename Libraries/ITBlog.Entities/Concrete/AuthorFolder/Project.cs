using ITBlog.Entities.Concrete.EntityFolder;
using ITBlog.Entities.Concrete.PictureFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Entities.Concrete.AuthorFolder
{
    public class Project : BaseEntity
    {
        public string? ProjectName { get; set; }

        public string? ProjectDescription { get; set; }

        public string? ProjectLink { get; set; }

        public virtual ICollection<Author> Authors { get; set; }

        public virtual ICollection<Picture> Pictures { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}
