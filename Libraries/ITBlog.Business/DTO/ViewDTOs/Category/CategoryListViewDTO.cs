namespace ITBlog.Business.DTO.ViewDTOs.Category
{
    public class CategoryListViewDTO : BaseDTO
    {

        public string CategoryName { get; set; }

        public List<SubCategoryViewDTO> SubCategories { get; set; }

    }
}
