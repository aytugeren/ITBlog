using ITBlog.Entities.Concrete.EntityFolder;
using ITBlog.Entities.Concrete.PictureFolder;
using ITBlog.Entities.Concrete.PostFolder;

namespace ITBlog.Entities.Concrete.AuthorFolder
{
    public class Author : BaseEntity
    {
        public Author()
        {
            this.Posts = new List<Post>();
        }

        public string? AuthorName { get; set; }

        public string? AuthorSecondName { get; set; }

        public string? AuthorLastName { get; set; }

        public DateTime AuthorBirthday { get; set; }

        public int PostCount { get; set; }

        public string? AuthorRole { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

        public virtual ICollection<Picture> Pictures { get; set; }
    }
}
