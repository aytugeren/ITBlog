using AutoMapper;
using ITBlog.Business.DTO;
using ITBlog.Business.DTO.ViewDTOs;
using ITBlog.DataAccess.RepositoryFolder;
using ITBlog.Entities.Concrete.PictureFolder;
using ITBlog.Entities.Concrete.PostCategoryFolder;
using ITBlog.Entities.Concrete.PostFolder;
using ITBlog.Entities.Concrete.PostPlaceFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.PostServiceFolder
{
    public class PostService : IPostService
    {
        private readonly IRepository<Post> _postRepository;
        private readonly IRepository<PostPlace> _postPlaceRepository;
        private readonly IRepository<Picture> _pictureRepository;
        private readonly IRepository<PostCategory> _postCategoryRepository;
        private readonly IMapper _mapper;

        public PostService(IRepository<Post> postRepository, IRepository<PostPlace> postPlaceRepository, IRepository<Picture> pictureRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _postPlaceRepository = postPlaceRepository;
            _pictureRepository = pictureRepository;
            _mapper = mapper;
        }

        public List<IndexViewDTOS> GetPostsByPlace(Guid placeId)
        {
            var listModel = new List<IndexViewDTOS>();
            StringBuilder categoryFlat = new StringBuilder();

            if (placeId != Guid.Empty)
            {
                var posts = _postPlaceRepository.Query(x => x.PlaceId == placeId, "Post|Post.Pictures.Picture|Post.Categories.Category").Select(x => x.Post);

                var result = _mapper.Map<List<PostDTO>>(posts);
                
                foreach(var post in result)
                {
                    var model = new IndexViewDTOS();

                    if (post.Pictures != null)
                    {
                        var pictures = post.Pictures;
                        foreach (var item in pictures)
                        {
                            model.Pictures.Add(item.Picture);
                        }
                        model.MainPicture = model.Pictures.Any(x => x.PictureIsDefault) ? model.Pictures.FirstOrDefault(x => x.PictureIsDefault) : new PictureDTO();
                    }

                    if (post.Categories != null)
                    {
                        foreach (var item in post.Categories)
                        {
                            model.Category.Add(item.Category);
                            if (post.Categories.Count > 1)
                            {
                                categoryFlat.Append(item.Category.CategoryName + ",");
                            }
                            else
                            {
                                categoryFlat.Append(item.Category.CategoryName);
                            }
                        }

                        if (categoryFlat.ToString().Contains(','))
                        {
                            model.CategoryFlat = categoryFlat.ToString().Remove(categoryFlat.Length - 1);
                        }
                        else
                        {
                            model.CategoryFlat = categoryFlat.ToString();
                        }
                        categoryFlat.Clear();
                    }

                    model.Post = post;
                    model.AuthorId = post.AuthorId;
                    listModel.Add(model);
                }

                return listModel;
            }

            return default(List<IndexViewDTOS>);
        }
    }
}
