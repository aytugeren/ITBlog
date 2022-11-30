using ITBlog.Business.CategoryServiceFolder;
using ITBlog.Business.DTO;
using ITBlog.Business.Enums;
using ITBlog.Business.PictureServiceFolder;
using ITBlog.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITBlog.Presentation.Controllers.CategoryFolder
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IPictureService _pictureService;

        public CategoryController(ICategoryService categoryService, IPictureService pictureService)
        {
            _categoryService = categoryService;
            _pictureService = pictureService;
        }

        public IActionResult Index(string seoName)
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

        [HttpGet(Name = "GetCategory/{Id}")]
        public IActionResult GetCategory(Guid Id)
        {
            if (Id == Guid.Empty)
            {
                return RedirectToAction("Error", "Home");
            }
            var model = new CategoryModel();
            var category = _categoryService.GetCategoryById(Id);

            if (category != null)
            {
                var posts = category.Posts.Select(x => x.Post).ToList();
                var tags = _categoryService.GetCategoryByPlaceName("Tag").Keys.ToList();
                var cv = _pictureService.GetCVByUserName("aytugeren");
                var popularPosts = posts.OrderBy(x => x.Comments.Count).ToList();
                var recentPosts = posts.OrderByDescending(x => x.CreatedDateTime).ToList();

                model.Posts = posts;
                model.CV = cv;
                model.Category = category;
                model.Tags = tags;
                model.PopularPostOfCategory = popularPosts;
                model.RecentPostOfCategory = recentPosts;

                return View(model);
            }

            return View();
        }
    }
}
