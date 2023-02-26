using ITBlog.Business.DTO;
using ITBlog.Business.DTO.ViewDTOs.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.CategoryServiceFolder
{
    public interface ICategoryService
    {
        Dictionary<CategoryDTO, List<CategoryDTO>> GetCategoryByPlaceName(string placeName);

        CategoryDTO GetCategoryById(Guid id);

        List<CategoryListViewDTO> GetAllCategories();

        NewCategoryViewDTO AddNewCategory(NewCategoryViewDTO model);
    }
}
