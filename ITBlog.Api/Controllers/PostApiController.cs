namespace ITBlog.Admin.Controllers.PostFolder
{
    #region
    using ITBlog.Business.AuthorServiceFolder;
    using ITBlog.Business.DTO;
    using ITBlog.Business.PostServiceFolder;
    using Microsoft.AspNetCore.Mvc;

    #endregion

    [ApiController]
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;
        private readonly IAuthorService _authorService;


        public PostController(IPostService postService, IAuthorService authorService)
        {
            _postService = postService;
            _authorService = authorService;
        }

        [HttpGet("GetAllPosts")]
        public List<PostDTO> GetPosts()
        {
            var posts = _postService.GetAllPosts();
            if (posts != null)
            {
                foreach (var post in posts)
                {
                    var author = _authorService.GetAuthorById(post.AuthorId);
                    post.Author = author;
                }
            }
            return posts;
        }

        [HttpGet("GetPostById/post")]
        public PostDTO GetPost(Guid id)
        {
            var post = _postService.GetPostById(id);
            return post;
        }

    }
}
