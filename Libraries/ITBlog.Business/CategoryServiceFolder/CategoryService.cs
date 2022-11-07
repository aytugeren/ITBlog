using AutoMapper;
using ITBlog.Business.DTO;
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
            var category = _categoryRepository.Query(x => x.Id == id, "Posts|Posts.Post|Posts.Post.Comments").FirstOrDefault();

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
    }
}
