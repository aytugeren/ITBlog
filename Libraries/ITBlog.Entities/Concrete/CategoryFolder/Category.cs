using ITBlog.Entities.Concrete.CategoryPlaceFolder;
using ITBlog.Entities.Concrete.EntityFolder;
using ITBlog.Entities.Concrete.PostCategoryFolder;

namespace ITBlog.Entities.Concrete
{
    public class Category : BaseEntity
    {
        public Category()
        {
            this.Posts = new HashSet<PostCategory>();
            this.Places = new HashSet<CategoryPlace>();
        }

        public string? CategoryName { get; set; }

        public bool IsCategoryMain { get; set; }

        public Guid? ParentCategoryId { get; set; }

        public string? CategoryPlace { get; set; }

        public string? CategoryUrl { get; set; }

        public string? CategorySeoName { get; set; }

        public virtual ICollection<PostCategory> Posts { get; set; }

        public virtual ICollection<CategoryPlace> Places { get; set; }
    }
}
