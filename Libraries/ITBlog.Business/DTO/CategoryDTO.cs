using ITBlog.Business.DTO.MappingDTOs;

namespace ITBlog.Business.DTO
{
    public class CategoryDTO : BaseDTO
    {
        public string? CategoryName { get; set; }

        public bool IsCategoryMain { get; set; }

        public Guid? ParentCategoryId { get; set; }

        public string? CategoryPlace { get; set; }

        public string? CategoryUrl { get; set; }

        public string? CategorySeoName { get; set; }


        public virtual ICollection<PostCategoryDTO> Posts { get; set; }
        public virtual ICollection<CategoryPlaceDTO> Places { get; set; }

    }
}
