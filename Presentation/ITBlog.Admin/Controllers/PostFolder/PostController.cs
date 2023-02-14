namespace ITBlog.Admin.Controllers.PostFolder
{
    using ITBlog.Business.AuthorServiceFolder;
    #region
    using ITBlog.Business.DTO;
    using ITBlog.Business.DTO.ViewDTOs;
    using ITBlog.Business.PostServiceFolder;
    using Microsoft.AspNetCore.Cors;
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

        [EnableCors("ITBlog")]
        [HttpGet("GetAllPosts")]
        public List<PostListModel> GetPosts()
        {
            var posts = _postService.GetAllPost();
            return posts;
        }

        [EnableCors("ITBlog")]
        [HttpGet("GetPostById/post")]
        public PostDTO GetPost(Guid id)
        {
            var post = _postService.GetPostById(id);
            return post;
        }

    }
}
