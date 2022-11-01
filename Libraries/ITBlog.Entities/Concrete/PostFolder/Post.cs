using ITBlog.Entities.Concrete.AuthorFolder;
using ITBlog.Entities.Concrete.EntityFolder;
using ITBlog.Entities.Concrete.PictureFolder;

namespace ITBlog.Entities.Concrete.PostFolder
{
    public class Post : BaseEntity
    {
        public Post()
        {
            this.Categories = new HashSet<Category>();
        }

        public string? Title { get; set; }

        public string? FirstContent { get; set; }

        public string? SecondContent { get; set; }

        public Guid AuthorId { get; set; }

        public virtual ICollection<Category> Categories { get; set; }

        public virtual ICollection<Picture> Pictures { get; set; }

        public Author Author { get; set; }
    }
}
