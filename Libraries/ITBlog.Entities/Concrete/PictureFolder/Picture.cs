using ITBlog.Entities.Concrete.AuthorFolder;
using ITBlog.Entities.Concrete.AuthorPictureFolder;
using ITBlog.Entities.Concrete.EntityFolder;
using ITBlog.Entities.Concrete.PostPictureFolder;

namespace ITBlog.Entities.Concrete.PictureFolder
{
    public class Picture : BaseEntity
    {
        public Picture()
        {
            this.Posts = new HashSet<PostPicture>();
            this.Authors = new HashSet<AuthorPicture>();
        }

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

        public bool PictureIsDefault { get; set; }

        public virtual ICollection<PostPicture> Posts { get; set; }

        public virtual ICollection<AuthorPicture> Authors { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}
