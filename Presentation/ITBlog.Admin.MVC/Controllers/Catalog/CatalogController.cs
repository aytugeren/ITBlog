using ITBlog.Admin.MVC.Models;
using ITBlog.Business.CategoryServiceFolder;
using ITBlog.Business.DTO;
using ITBlog.Business.DTO.MappingDTOs;
using ITBlog.Business.PlaceServiceFolder;
using Microsoft.AspNetCore.Mvc;

namespace ITBlog.Admin.MVC.Controllers.Catalog
{
    public class CatalogController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IPlaceService _placeService;

        public CatalogController(ICategoryService categoryService, IPlaceService placeService)
        {
            _categoryService = categoryService;
            _placeService = placeService;
        }

        public IActionResult Index()
        {
            var list = _categoryService.GetCategories();

            return View(list);
        }

        public ActionResult GetCategoryInfoById(Guid id)
        {
            CategoryEditModel categoryEditModel = new CategoryEditModel();


            var categoryList = _categoryService.GetCategories();

            var places = _placeService.GetPlaceList();

            if (id != Guid.Empty)
            {
                var category = _categoryService.GetCategoryById(id);

                categoryEditModel.Category = category;
            }

            categoryEditModel.CategoryList = categoryList;
            categoryEditModel.Places = places;

            return View(categoryEditModel);
        }

        [HttpPost]
        public IActionResult SubmitCategory(CategorySubmitModel model)
        {
            var catalogDTOModel = new CategoryDTO();

            if (model != null)
            {
                var categoryId = model.CategoryId != Guid.Empty ? model.CategoryId : Guid.NewGuid();
                var isUpdate = model.CategoryId != Guid.Empty;

                catalogDTOModel.Id = categoryId;
                catalogDTOModel.CategoryName = model.CategoryName;
                catalogDTOModel.CategorySeoName = model.CategorySeoName;
                catalogDTOModel.IsCategoryMain = model.ParentCategoryId == Guid.Empty;
                catalogDTOModel.CategoryUrl = model.CategoryUrl;
                if (model.ParentCategoryId != Guid.Empty)
                {
                    catalogDTOModel.ParentCategoryId = model.ParentCategoryId;
                }

                if (model.CategoryActiveStatus)
                {
                    catalogDTOModel.IsActive = true;
                    catalogDTOModel.IsDeleted = false;
                }
                else
                {
                    catalogDTOModel.IsActive = false;
                    catalogDTOModel.IsDeleted = true;
                }

                var result = _categoryService.AddOrUpdateCategory(catalogDTOModel, isUpdate);

                return Redirect("Index");
            }

            return Redirect($"GetCategoryInfoById/{Guid.Empty}");
        }

        public IActionResult RemoveCategory(Guid id)
        {
            if (id != Guid.Empty)
            {
                var reuslt = _categoryService.RemoveCategory(id);

                return Redirect("/Catalog/Index");
            }

            return Redirect($"/GetCategoryInfoById/{Guid.Empty}");
        }

        [HttpGet]
        public IActionResult RemoveCategoryPlace(Guid placeId, Guid categoryId)
        {
            var result = _categoryService.RemoveCategoryPlace(placeId, categoryId);

            if (result)
            {
                return Redirect($"GetCategoryInfoById/{categoryId}");
            }
            else
            {
                ViewData["ErrorMessage"] = "Böyle bir bilgi bulunamadı!";
                return Redirect($"GetCategoryInfoById/{categoryId}");
            }
        }

        [HttpGet]
        public IActionResult AddCategoryPlace(Guid categoryId, Guid categoryPlaceId)
        {
            _categoryService.AddUpdateCategoryPlace(categoryId, categoryPlaceId);
            return Ok();
        }
    }
}
