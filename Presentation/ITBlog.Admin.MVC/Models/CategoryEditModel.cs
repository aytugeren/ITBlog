using ITBlog.Business.DTO;

namespace ITBlog.Admin.MVC.Models
{
    public class CategoryEditModel
    {
        public CategoryDTO Category { get; set; }

        public List<CategoryDTO> CategoryList { get; set; }

        public List<PlaceDTO> Places { get; set; }
    }
}
