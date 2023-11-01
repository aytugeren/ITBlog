using AutoMapper;
using ITBlog.Business.DTO;
using ITBlog.Business.DTO.MappingDTOs;
using ITBlog.Business.Enums;
using ITBlog.DataAccess.RepositoryFolder;
using ITBlog.Entities.Concrete;
using ITBlog.Entities.Concrete.CategoryPlaceFolder;
using ITBlog.Entities.Concrete.PlaceFolder;
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
        private readonly IRepository<CategoryPlace> _categoryPlaceRepository;
        private readonly IRepository<Place> _placeRepository;
        private readonly IMapper _mapper;

        public CategoryService(IRepository<Category> categoryRepository, IRepository<CategoryPlace> categoryPlaceRepository, IRepository<Place> placeRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _categoryPlaceRepository = categoryPlaceRepository;
            _placeRepository = placeRepository;
            _mapper = mapper;
        }

        public Tuple<string, bool> AddOrUpdateCategory(CategoryDTO categoryDTO, bool isUpdate)
        {
            if (isUpdate)
            {
                var result = _categoryRepository.Update(_mapper.Map<Category>(categoryDTO));
            }
            else
            {
                _categoryRepository.Insert(_mapper.Map<Category>(categoryDTO));
            }

            return Tuple.Create("Güncelleme Başarılı!", true);
        }

        public bool AddUpdateCategoryPlace(Guid categoryId, Guid categoryPlaceId)
        {
            var model = new CategoryPlace()
            {
                CategoryId = categoryId,
                PlaceId = categoryPlaceId
            };


            var isOccured = _categoryPlaceRepository.Query(x => x.CategoryId == categoryId && x.PlaceId == categoryPlaceId, string.Empty);

            try
            {
                if (isOccured.Any())
                {
                    model.UpdatedDateTime = DateTime.Now;
                    model.CreatedDateTime = isOccured.FirstOrDefault().CreatedDateTime;
                    model.IsActive = true;
                    model.IsDeleted = false;
                    model.Id = isOccured.FirstOrDefault().Id;

                    _categoryPlaceRepository.Update(model);
                }
                else
                {
                    model.CreatedDateTime = DateTime.Now;
                    model.IsActive = true;
                    model.IsDeleted = false;
                    model.Id = Guid.NewGuid();

                    _categoryPlaceRepository.Insert(model);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<CategoryDTO> GetCategories()
        {
            var categoryList = _categoryRepository.Query(null, "Places|Places.Place|Posts");
            if (categoryList != null)
            {
                return _mapper.Map<List<CategoryDTO>>(categoryList);
            }

            return new List<CategoryDTO>();
        }

        public CategoryDTO GetCategoryById(Guid id)
        {
            var category = _categoryRepository.Query(x => x.Id == id, "Posts|Posts.Post|Posts.Post.Comments|Posts.Post.Author|Places|Places.Place").FirstOrDefault();

            if (category != null)
            {
                return _mapper.Map<CategoryDTO>(category);
            }

            return new CategoryDTO();
        }

        public Dictionary<CategoryDTO, List<CategoryDTO>> GetCategoryByPlaceName(string placeName)
        {
            var listOfCategories = new Dictionary<CategoryDTO, List<CategoryDTO>>();
            if (!string.IsNullOrEmpty(placeName))
            {
                var place = _placeRepository.Query(x => x.PlaceName == placeName, "Categories|Categories.Category").FirstOrDefault()?.Categories;

                if (place != null)
                {
                    var categories = place.Select(c => c.Category);
                    var subCategories = categories.Where(x => x.ParentCategoryId != null);

                    foreach (var item in categories)
                    {
                        if (item.IsCategoryMain && (item.ParentCategoryId == null || item.ParentCategoryId == Guid.Empty))
                        {
                            if (subCategories.Count() > 0)
                            {
                                var sbc = categories.Where(x => x.ParentCategoryId == item.Id).ToList();
                                listOfCategories.Add(_mapper.Map<CategoryDTO>(item), _mapper.Map<List<CategoryDTO>>(sbc));
                            }
                            else
                            {
                                listOfCategories.Add(_mapper.Map<CategoryDTO>(item), null);
                            }
                        }
                    }
                }


                return listOfCategories;
            }

            return listOfCategories;
        }

        public bool RemoveCategory(Guid id)
        {
            var category = _categoryRepository.GetById(id);
            _categoryRepository.Delete(category);

            return true;
        }

        public bool RemoveCategoryPlace(Guid placeId, Guid categoryId)
        {
            var categoryPlace = _categoryPlaceRepository.Query(x => x.PlaceId == placeId && x.CategoryId == categoryId, string.Empty).FirstOrDefault();

            if (categoryPlace != null)
            {
                _categoryPlaceRepository.Delete(categoryPlace);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
