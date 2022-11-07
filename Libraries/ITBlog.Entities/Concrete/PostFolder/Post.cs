using ITBlog.Entities.Concrete.AuthorFolder;
using ITBlog.Entities.Concrete.CommentFolder;
using ITBlog.Entities.Concrete.EntityFolder;
using ITBlog.Entities.Concrete.PostCategoryFolder;
using ITBlog.Entities.Concrete.PostPictureFolder;
using ITBlog.Entities.Concrete.PostPlaceFolder;

namespace ITBlog.Entities.Concrete.PostFolder
{
    public class Post : BaseEntity
    {
        public Post()
        {
            this.Categories = new List<PostCategory>();
            this.Pictures = new List<PostPicture>();
            this.Places = new List<PostPlace>();
            this.Comments = new List<Comment>();
        }

        public string? Title { get; set; }

        public string? FirstContent { get; set; }

        public string? SecondContent { get; set; }

        public Guid AuthorId { get; set; }

        public virtual ICollection<PostCategory> Categories { get; set; }

        public virtual ICollection<PostPicture> Pictures { get; set; }

        public virtual Author Author { get; set; }

        public virtual ICollection<PostPlace> Places { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
