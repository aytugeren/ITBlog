using ITBlog.Business.DTO;

namespace ITBlog.Admin.MVC.Models
{
    public class CategoryPostEditModel
    {
        public PostDTO Post { get; set; }

        public List<CategoryDTO> Category { get; set; }
    }
}
