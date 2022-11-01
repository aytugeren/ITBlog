using ITBlog.Business.CategoryServiceFolder;
using ITBlog.Business.DTO;
using ITBlog.Business.Enums;
using Microsoft.AspNetCore.Mvc;

namespace ITBlog.Presentation.Controllers.CategoryFolder
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult GetNavigationCategories()
        {
            var categories = _categoryService.GetCategoryByPlaceName(CateogryEnums.Navigation.ToString());

            if (categories == null || categories == default(Dictionary<CategoryDTO, List<CategoryDTO>>))
            {
                return PartialView();
            }

            return PartialView(categories);
        }
    }
}
