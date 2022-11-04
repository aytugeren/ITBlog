using ITBlog.Entities.Concrete.CategoryPlaceFolder;
using ITBlog.Entities.Concrete.EntityFolder;
using ITBlog.Entities.Concrete.PostPlaceFolder;

namespace ITBlog.Entities.Concrete.PlaceFolder
{
    public class Place : BaseEntity
    {
        public Place()
        {
            this.Posts = new HashSet<PostPlace>();
            this.Categories = new HashSet<CategoryPlace>();
        }

        public string PlaceName { get; set; }

        public virtual ICollection<PostPlace> Posts { get; set; }
        
        public virtual ICollection<CategoryPlace> Categories { get; set; }
    }
}
