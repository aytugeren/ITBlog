namespace ITBlog.Admin.MVC.Models
{
    public class CategorySubmitModel
    {
        public Guid CategoryId { get; set; }
        
        public string? CategoryName { get; set; }

        public Guid ParentCategoryId { get; set; }

        public Guid CategoryPlaceId { get; set; }

        public string? CategorySeoName { get; set; }

        public string? CategoryUrl { get; set; }

        public bool CategoryActiveStatus { get; set; }
    }
}
