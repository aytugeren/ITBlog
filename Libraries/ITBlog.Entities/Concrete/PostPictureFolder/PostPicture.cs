using ITBlog.Entities.Concrete.EntityFolder;
using ITBlog.Entities.Concrete.PictureFolder;
using ITBlog.Entities.Concrete.PostFolder;

namespace ITBlog.Entities.Concrete.PostPictureFolder
{
    public class PostPicture : BaseEntity
    {
        public Guid PostId { get; set; }

        public Guid PictureId { get; set; }

        public Post Post{ get; set; }

        public Picture Picture { get; set; }
    }
}
