using ITBlog.Entities.Concrete.EntityFolder;
using ITBlog.Entities.Concrete.PostFolder;

namespace ITBlog.Entities.Concrete
{
    public class Category : BaseEntity
    {

        public Category()
        {
            this.Posts = new HashSet<Post>();
        }

        public string? CategoryName { get; set; }

        public bool IsCategoryMain { get; set; }

        public Guid? ParentCategoryId { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
