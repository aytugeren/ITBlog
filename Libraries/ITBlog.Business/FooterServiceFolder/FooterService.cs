using AutoMapper;
using ITBlog.Business.DTO;
using ITBlog.Business.Enums;
using ITBlog.DataAccess.RepositoryFolder;
using ITBlog.Entities.Concrete;
using ITBlog.Entities.Concrete.AuthorFolder;
using ITBlog.Entities.Concrete.PictureFolder;
using ITBlog.Entities.Concrete.PostFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.FooterServiceFolder
{
    public class FooterService : IFooterService
    {
        private readonly IRepository<Category> _categoryRepository;
        private readonly IRepository<Picture> _pictureRepository;
        private readonly IRepository<Author> _authorRepository;
        private readonly IRepository<Post> _postRepository;
        private readonly IMapper _mapper;

        public FooterService(IRepository<Category> categoryRepository, IRepository<Picture> pictureRepository, IRepository<Author> authorRepository, IRepository<Post> postRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _pictureRepository = pictureRepository;
            _authorRepository = authorRepository;
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public FooterDTO GetFooter()
        {
            var footerModel = new FooterDTO();

            var logo = _pictureRepository.Query(x => x.PicturePlace == PicturePlaceEnums.Logo.ToString(), string.Empty).Where(y => y.IsActive && !y.IsDeleted).FirstOrDefault();

            var lastPosts = _postRepository.GetAll().OrderByDescending(x => x.CreatedDateTime).Take(5).ToList();

            var mainCategories = _categoryRepository.Query(x => x.IsCategoryMain, string.Empty);


            if (logo != null)
            {
                footerModel.FooterLogo = _mapper.Map<PictureDTO>(logo);
            }

            if (lastPosts.Any())
            {
                footerModel.Posts = _mapper.Map<List<PostDTO>>(lastPosts);
            }

            if (mainCategories.Any())
            {
                footerModel.Categories = _mapper.Map<List<CategoryDTO>>(mainCategories);
            }

            return footerModel;
        }
    }
}
