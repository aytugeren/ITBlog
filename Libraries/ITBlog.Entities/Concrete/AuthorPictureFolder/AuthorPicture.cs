using ITBlog.Entities.Concrete.AuthorFolder;
using ITBlog.Entities.Concrete.EntityFolder;
using ITBlog.Entities.Concrete.PictureFolder;

namespace ITBlog.Entities.Concrete.AuthorPictureFolder
{
    public class AuthorPicture : BaseEntity
    {
        public Guid AuthorId { get; set; }

        public Guid PictureId { get; set; }

        public Author Author { get; set; }

        public Picture Picture { get; set; }
    }
}
