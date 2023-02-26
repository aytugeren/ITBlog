using AutoMapper;
using ITBlog.Business.DTO;
using ITBlog.Business.DTO.ViewDTOs.Category;
using ITBlog.Business.Enums;
using ITBlog.DataAccess.RepositoryFolder;
using ITBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.CategoryServiceFolder
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(IRepository<Category> categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public CategoryDTO GetCategoryById(Guid id)
        {
            var category = _categoryRepository.Query(x => x.Id == id, "Posts|Posts.Post|Posts.Post.Comments|Posts.Post.Author").FirstOrDefault();

            if (category != null)
            {
                return _mapper.Map<CategoryDTO>(category);
            }

            return default(CategoryDTO);
        }

        public Dictionary<CategoryDTO, List<CategoryDTO>> GetCategoryByPlaceName(string placeName)
        {
            var listOfCategories = new Dictionary<CategoryDTO, List<CategoryDTO>>();
            if (!string.IsNullOrEmpty(placeName))
            {
                var result = _categoryRepository.Query(x => x.CategoryPlace == placeName, string.Empty);
                var subCategories = result.Where(x => x.ParentCategoryId != null);

                foreach (var item in result)
                {
                    if (item.IsCategoryMain && (item.ParentCategoryId == null || item.ParentCategoryId == Guid.Empty))
                    {
                        if (subCategories.Count() > 0)
                        {
                            var sbc = result.Where(x => x.ParentCategoryId == item.Id).ToList();
                            listOfCategories.Add(_mapper.Map<CategoryDTO>(item), _mapper.Map<List<CategoryDTO>>(sbc));
                        }
                        else
                        {
                            listOfCategories.Add(_mapper.Map<CategoryDTO>(item), null);
                        }
                    }
                }
                return listOfCategories;
            }
            return listOfCategories;
        }

        //Api

        public List<CategoryListViewDTO> GetAllCategories()
        {
            var categories = _categoryRepository.GetAll();
            var categoryList = categories.Where(d => d.ParentCategoryId == null).Select(c => new CategoryListViewDTO
            {
                Id = c.Id,
                CategoryName = c.CategoryName,
                SubCategories = categories.Where(f => f.ParentCategoryId == c.Id).Select(x => new SubCategoryViewDTO
                {
                    Id = x.Id,
                    CategoryName = x.CategoryName
                }).ToList(),
            }).ToList();
            return categoryList;
        }

        public NewCategoryViewDTO AddNewCategory(NewCategoryViewDTO model)
        {

            CategoryDTO category = new();

            try
            {
                if (model != null)
                {
                    category.ParentCategoryId = model.ParentId;
                    category.CategoryName = model.CategoryName;
                    category.CategoryUrl = model.CategoryUrl;
                    category.IsCategoryMain = model.IsCategoryMain;
                    category.CategorySeoName = model.CategorySeoName;

                    _categoryRepository.Insert(_mapper.Map<Category>(category));
                }
            }
            catch (Exception)
            {
                throw;
            }

            return model;

        }

    }
}
