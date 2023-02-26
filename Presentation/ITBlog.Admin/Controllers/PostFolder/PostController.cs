#region
using ITBlog.Business.DTO;
using ITBlog.Business.DTO.ViewDTOs;
using ITBlog.Business.PostServiceFolder;
using ITBlog.Entities.Concrete.PostFolder;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
#endregion

namespace ITBlog.Admin.Controllers.PostFolder
{
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
        [Authorize(Roles = "Admin")]
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
        public async Task<ActionResult<PostDTO>> AddNewPost(AddNewPostDTO model)
        {
            try
            {
                var post = _postService.AddNewPost(model);
                if (post != null)
                    return Ok(new ApiResultModel
                    {
                        Result = 1,
                        Error = null,
                    });
            }
            catch (Exception e)
            {

                return Ok(new ApiResultModel
                {
                    Result = -1,
                    Error = e.Message,
                });
            }
            return Ok();
        }

        [EnableCors("ITBlog")]
        [HttpPost("UpdatePostWithId/post")]
        public PostUpdateViewDTO UpdatePostWithId(Guid id, PostUpdateViewDTO model)
        {
            var post = _postService.UpdatePostWithId(id, model);
            return post;
        }

        [EnableCors("ITBlog")]
        [HttpPost("DeletePostWithId/post")]
        public async Task<ActionResult<Post>> DeletePostWithId(Guid id)
        {
            var post = _postService.DeletePostWithId(id);
            if (post != null)
                return Ok(new ApiResultModel
                {
                    Result = 1,
                    Error = null,
                });
            else
                return Ok(new ApiResultModel
                {
                    Result = -1,
                    Error = "Yazı bulunamadı",
                });

        }

    }
}
