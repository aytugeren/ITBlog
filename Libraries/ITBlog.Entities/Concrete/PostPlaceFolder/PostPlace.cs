using ITBlog.Entities.Concrete.EntityFolder;
using ITBlog.Entities.Concrete.PlaceFolder;
using ITBlog.Entities.Concrete.PostFolder;

namespace ITBlog.Entities.Concrete.PostPlaceFolder
{
    public class PostPlace : BaseEntity
    {
        public Guid PostId { get; set; }

        public Guid PlaceId { get; set; }

        public Post Post { get; set; }

        public Place Place { get; set; }
    }
}
