using AutoMapper;
using ITBlog.Business.DTO;
using ITBlog.Business.DTO.MappingDTOs;
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

        public PostService(IRepository<Post> postRepository, IRepository<PostPlace> postPlaceRepository, IRepository<Picture> pictureRepository, IRepository<PostCategory> postCategoryRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _postPlaceRepository = postPlaceRepository;
            _pictureRepository = pictureRepository;
            _postCategoryRepository = postCategoryRepository;
            _mapper = mapper;
        }

        public List<IndexViewDTOS> GetPostsByPlace(Guid placeId)
        {
            var listModel = new List<IndexViewDTOS>();
            StringBuilder categoryFlat = new StringBuilder();

            if (placeId != Guid.Empty)
            {
                var posts = _postPlaceRepository.Query(x => x.PlaceId == placeId, "Post|Post.Pictures.Picture|Post.Categories.Category");

                var result = _mapper.Map<List<PostDTO>>(posts.Select(x => x.Post));
                
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

        public PostDTO GetPostById(Guid id)
        {
            var post = _postRepository.Query(x => x.Id == id, "Author|Categories|Categories.Category|Pictures|Pictures.Picture").FirstOrDefault();
            if (post != null)
            {
                return _mapper.Map<PostDTO>(post);
            }

            return default(PostDTO);
        }

        public List<PostDTO> GetPostsByCategory(Guid[] categoryIds, Guid authorId)
        {
            List<PostDTO> posts = new List<PostDTO>();
            if (categoryIds != null)
            {
                if (categoryIds.Count() > 0)
                {
                    foreach (var item in categoryIds)
                    {
                        var relatedPosts = _postRepository.Query(null, "Categories|Category");
                        relatedPosts = relatedPosts.Where(x => x.Categories.Any(x => categoryIds.Contains(x.CategoryId))).ToList();

                        if (relatedPosts != null)
                        {
                            var authorsPosts = relatedPosts.Where(x => x.AuthorId == authorId);
                            if (authorsPosts.Count() > 0)
                            {
                                foreach (var post in relatedPosts.Where(x => x.AuthorId == authorId))
                                {
                                    posts.Add(_mapper.Map<PostDTO>(post));
                                }
                            }
                            else
                            {
                                foreach (var post in relatedPosts)
                                {
                                    posts.Add(_mapper.Map<PostDTO>(post));
                                }
                            }

                        }
                    }
                }
            }

            return posts;
        }

        public List<PostDTO> GetPostsByDeterminedDayBefore(int dayBefore)
        {
            var posts = _postRepository.Query(x => x.CreatedDateTime >= DateTime.Now.AddDays(-dayBefore), "Author|Comments");

            if (posts != null)
            {
                return _mapper.Map<List<PostDTO>>(posts);
            }

            return default(List<PostDTO>);
        }

        public List<PostDTO> GetPostsBySearchText(string searchText)
        {
            var posts = _postRepository.Query(x => x.SecondContent.Contains(searchText) || x.FirstContent.Contains(searchText), "Author|Comments");

            return _mapper.Map<List<PostDTO>>(posts);
        }

        public List<PostDTO> GetPostsByAuthorId(Guid id)
        {
            var posts = _postRepository.Query(x => x.AuthorId == id, "Author|Categories|Pictures|Places|Comments");

            return _mapper.Map<List<PostDTO>>(posts);
        }

        public bool SubmitPost(PostDTO postDTO)
        {
            if (postDTO == null)
            {
                return false;
            }

            var postEntity = new Post();

            bool isUpdate = postDTO.Id != Guid.Empty;
            DateTime createdTime = DateTime.Now;
            if (isUpdate)
            {
                var post = _postRepository.GetById(postDTO.Id);
                createdTime = post.CreatedDateTime;
            }

            postEntity.Id = isUpdate ? postDTO.Id : Guid.NewGuid();
            postEntity.Title = postDTO.Title;
            postEntity.FirstContent = postDTO.FirstContent;
            postEntity.SecondContent = postDTO.SecondContent;
            postEntity.AuthorId = postDTO.AuthorId;
            postEntity.IsActive = true;
            postEntity.IsDeleted = false;

            if (isUpdate)
            {
                postEntity.UpdatedDateTime = DateTime.Now;
                postEntity.CreatedDateTime = createdTime;
                _postRepository.Update(postEntity);
            }
            else
            {
                postEntity.CreatedDateTime = DateTime.Now;
                _postRepository.Insert(postEntity);
            }

            return true;
        }

        public PostCategoryDTO GetPostCategoryDTO(Guid categoryId, Guid postId)
        {
            var result = _postCategoryRepository.Query(x => x.CategoryId == categoryId && x.PostId == postId, string.Empty);

            if (result == null || !result.Any())
            {
                return new PostCategoryDTO();
            }

            return _mapper.Map<PostCategoryDTO>(result.FirstOrDefault());
        }

        public bool RemovePostCategoryMapping(Guid categoryId, Guid postId)
        {
            try
            {
                var result = _postCategoryRepository.Query(x => x.CategoryId == categoryId && x.PostId == postId, string.Empty).FirstOrDefault();

                if (result != default(PostCategory))
                {
                    _postCategoryRepository.Delete(result);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool AddUpdatePostCategoryMapping(Guid categoryId, Guid postId)
        {
            try
            {
                var result = this.GetPostCategoryDTO(categoryId, postId);

                if (result != null && result.Id != Guid.Empty)
                {
                    return false;
                }

                var model = new PostCategory()
                {
                    CategoryId = categoryId,
                    PostId = postId,
                    CreatedDateTime = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    Id = Guid.NewGuid(),
                };

                _postCategoryRepository.Insert(model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
