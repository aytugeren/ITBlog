using AutoMapper;
using ITBlog.Business.AuthorServiceFolder;
using ITBlog.Business.DTO;
using ITBlog.Business.DTO.MappingDTOs;
using ITBlog.Business.DTO.ViewDTOs;
using ITBlog.DataAccess.RepositoryFolder;
using ITBlog.Entities.Concrete;
using ITBlog.Entities.Concrete.PictureFolder;
using ITBlog.Entities.Concrete.PostCategoryFolder;
using ITBlog.Entities.Concrete.PostFolder;
using ITBlog.Entities.Concrete.PostPlaceFolder;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ITBlog.Business.PostServiceFolder
{
    public class PostService : IPostService
    {
        private readonly IRepository<Post> _postRepository;
        private readonly IRepository<PostPlace> _postPlaceRepository;
        private readonly IRepository<PostCategory> _postCategoryRepository;
        private readonly IRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public PostService(IRepository<Post> postRepository, IRepository<PostPlace> postPlaceRepository, IRepository<PostCategory> postCategoryRepository, IRepository<Category> categoryRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _postPlaceRepository = postPlaceRepository;
            _postCategoryRepository = postCategoryRepository;
            _categoryRepository = categoryRepository;
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

                foreach (var post in result)
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
                        var relatedPosts = _postRepository.Query(null, "Post|Post.Categories.Category");
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

        //Api
        public List<PostListViewDTO> GetAllPost()
        {
            var post = _postRepository.Query(null, "Author|Categories|Categories.Category|Pictures|Pictures.Picture|Comments")
                .Select(d => new PostListViewDTO
                {
                    Id = d.Id,
                    Title = d.Title,
                    ShortText = d.FirstContent,
                    PublishDate = d.CreatedDateTime.ToString("dd-MM-yyyy hh:mm:ss"),
                    IsActive = d.IsActive,
                    AuthorName = d.Author.AuthorName,
                    CategoryList = d.Categories.Where(x => x.PostId == d.Id).Select(y => y.Category.CategoryName).ToList(),
                    MainPicture = d.Pictures.Where(x => x.PostId == d.Id).Select(y => y.Picture.PictureUrl).FirstOrDefault(),
                    CommentCount = d.Comments.Where(x => x.PostId == d.Id).Count(),

                }).ToList();
            return post;
        }

        public PostDetailViewDTO GetPostWithId(Guid id)
        {
            var post = _postRepository.Query(d => d.Id == id, "Author|Categories|Categories.Category|Pictures|Pictures.Picture|Comments")
                .Select(d => new PostDetailViewDTO
                {
                    Id = d.Id,
                    Title = d.Title,
                    ShortText = d.FirstContent,
                    Content = d.SecondContent,
                    AuthorName = d.Author.AuthorName,
                    PictureList = d.Pictures.Where(x => x.PostId == id).Select(y => y.Picture.PictureUrl).ToList(),
                    CommentList = d.Comments.Where(x => x.PostId == id).Select(y => y.CommentResult).ToList(),
                    PostCategories = d.Categories.Where(x => x.PostId == id).Select(y => new PostCategoryViewDTO
                    {
                        CategoryId = y.Id,
                        CategoryName = y.Category.CategoryName,

                    }).ToList(),

                }
                ).FirstOrDefault();
            return post;

        }

        public PostDTO AddNewPost(AddNewPostDTO model)
        {
            var userGuid = new Guid("96BC1CDB-4135-481E-B628-6B41021B0C55");
            var uncatGuid = new Guid("1E863F4F-9388-40EC-A10D-816DAAC40C0A");
            var newPostId = Guid.NewGuid();
            var newColId = Guid.NewGuid();
            List<PostCategoryDTO> categories = new();
            PostDTO post = new();
            try
            {
                if (model != null)
                {
                    post.Id = newPostId;
                    post.Title = model.Title;
                    post.FirstContent = model.ShortText;
                    post.SecondContent = model.Content;
                    post.AuthorId = userGuid;

                    if (model.CategoryList.Count > 0)
                    {
                        post.Categories = model.CategoryList.Select(d => new PostCategoryDTO
                        {
                            Id = newColId,
                            PostId = newPostId,
                            CategoryId = d
                        }).ToList();
                    }
                    else
                    {
                        post.Categories = categories.Select(d => new PostCategoryDTO
                        {
                            Id = newColId,
                            PostId = newPostId,
                            CategoryId = uncatGuid,
                        }).ToList();
                    }

                    _postRepository.Insert(_mapper.Map<Post>(post));
                }

            }
            catch (Exception)
            {
                throw;
            }
            return post;
        }

        public PostUpdateViewDTO UpdatePostWithId(Guid id, PostUpdateViewDTO model)
        {
            var uncatGuid = new Guid("1E863F4F-9388-40EC-A10D-816DAAC40C0A");
            var newColId = Guid.NewGuid();
            List<PostCategoryDTO> categories = new();
            var post = _postRepository.Query(d => d.Id == id, "Author|Categories|Categories.Category|Pictures|Pictures.Picture|Comments")
               .FirstOrDefault();
            try
            {
                if (post != null)
                {
                    post.Title = model.Title;
                    post.FirstContent = model.ShortText;
                    post.SecondContent = model.Content;
                    post.UpdatedDateTime = DateTime.Now;
                    if (model.CategoryList.Count > 0)
                    {
                        post.Categories = model.CategoryList.Select(d => new PostCategory
                        {
                            Id = newColId,
                            PostId = post.Id,
                            CategoryId = d
                        }).ToList();
                    }
                    else
                    {
                        return null;
                    }
                    _postRepository.Update(_mapper.Map<Post>(post));
                }

            }
            catch (Exception)
            {
                throw;
            }
            return model;

        }

        public Post DeletePostWithId(Guid id)
        {
            var post = _postRepository.GetById(id);
            if (post != null)
            {
                _postRepository.Delete(_mapper.Map<Post>(post));
                return post;
            }
            else
            {
                return null;
            }

        }

    }
}
