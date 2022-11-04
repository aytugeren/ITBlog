using ITBlog.Entities.Concrete.EntityFolder;
using ITBlog.Entities.Concrete.PlaceFolder;

namespace ITBlog.Entities.Concrete.CategoryPlaceFolder
{
    public class CategoryPlace : BaseEntity
    {
        public Guid PlaceId { get; set; }

        public Guid CategoryId { get; set; }

        public Place Place { get; set; }

        public Category Category { get; set; }
    }
}
