using ITBlog.Entities.Concrete.EntityFolder;
using ITBlog.Entities.Concrete.PictureFolder;
using ITBlog.Entities.Concrete.PostFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Entities.Concrete.PostCategoryFolder
{
    public class PostCategory : BaseEntity
    {
        public Guid PostId { get; set; }

        public Guid CategoryId { get; set; }

        public Post Post { get; set; }

        public Category Category { get; set; }
    }
}
