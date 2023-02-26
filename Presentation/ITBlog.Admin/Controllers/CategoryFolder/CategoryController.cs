#region
using ITBlog.Business.DTO;
using ITBlog.Business.DTO.ViewDTOs;
using ITBlog.Business.CategoryServiceFolder;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ITBlog.Business.DTO.ViewDTOs.Category;
#endregion

namespace ITBlog.Admin.Controllers.CategoryFolder
{

    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [EnableCors("ITBlog")]
        [HttpGet("GetAllCategories")]
        public List<CategoryListViewDTO> GetCategories()
        {
            var categories = _categoryService.GetAllCategories();
            return categories;
        }

        [EnableCors("ITBlog")]
        [HttpPost("NewCategory")]
        public async Task<ActionResult<CategoryDTO>> AddNewCategory(NewCategoryViewDTO model)
        {
            try
            {
                var category = _categoryService.AddNewCategory(model);
                if (model != null)
                    return Ok(new ApiResultModel
                    {
                        Result = 1,
                        Error = null,
                    });
            }
            catch (Exception e)
            {

                return Ok(new ApiResultModel
                {
                    Result = -1,
                    Error = e.Message,
                });
            }
            return Ok();
        }
    }
}
