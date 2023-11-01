using ITBlog.Business.DTO;
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

        List<CategoryDTO> GetCategories();

        Tuple<string, bool> AddOrUpdateCategory(CategoryDTO categoryDTO, bool isUpdate);

        bool RemoveCategory(Guid id);

        bool RemoveCategoryPlace(Guid placeId, Guid categoryId);

        bool AddUpdateCategoryPlace(Guid categoryId, Guid categoryPlaceId);
    }
}
