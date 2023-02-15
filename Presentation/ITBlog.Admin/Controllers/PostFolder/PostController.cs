namespace ITBlog.Admin.Controllers.PostFolder
{
    using ITBlog.Business.AuthorServiceFolder;
    #region
    using ITBlog.Business.DTO;
    using ITBlog.Business.DTO.ViewDTOs;
    using ITBlog.Business.PostServiceFolder;
    using ITBlog.Entities.Concrete.PostFolder;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    #endregion

    [ApiController]
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [EnableCors("ITBlog")]
        [HttpGet("GetAllPosts")]
        public List<PostListViewDTO> GetPosts()
        {
            var posts = _postService.GetAllPost();
            return posts;
        }

        [EnableCors("ITBlog")]
        [HttpGet("GetPostWithId/post")]
        public PostDetailViewDTO GetPost(Guid id)
        {
            var post = _postService.GetPostWithId(id);
            return post;
        }

        [EnableCors("ITBlog")]
        [HttpPost("CreateNewPost")]
        public PostDTO AddNewPost(AddNewPostDTO model)
        {

            var post = _postService.AddNewPost(model);
            return post;

        }

    }
}
