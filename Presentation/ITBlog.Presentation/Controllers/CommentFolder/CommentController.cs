using ITBlog.Business.CommentServiceFolder;
using ITBlog.Business.DTO;
using ITBlog.Business.UserServiceFolder;
using ITBlog.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ITBlog.Presentation.Controllers.CommentFolder
{
    public class CommentController : Controller
    {
        private IUserService _userService;
        private ICommentService _commentService;

        public CommentController(IUserService userService, ICommentService commentService)
        {
            _userService = userService;
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddComment(CommentModel model)
        {
            var userEmail = User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).Select(x => x.Value).SingleOrDefault();

            if (!string.IsNullOrEmpty(userEmail))
            {
                var user = _userService.GetUserByEmail(userEmail);
                if (user == null)
                {
                    return RedirectToAction("SignUp", "User");
                }
                else
                {
                    CommentDTO modelDTO = new CommentDTO();
                    modelDTO.PostId = model.PostId;
                    modelDTO.CommentResult = model.Comment;
                    modelDTO.CommentDateTime = DateTime.Now;
                    modelDTO.CreatedDateTime = DateTime.Now;
                    modelDTO.UserId = user.Id;
                    modelDTO.Id = Guid.NewGuid();
                    modelDTO.IsActive = true;
                    modelDTO.IsDeleted = false;

                    if (_commentService.InsertComment(modelDTO))
                    {
                        return RedirectToAction("GetPostById", "Post", new { id = model.PostId });
                    }
                    else
                    {
                        return RedirectToAction("Error", "Home");
                    }
                }
            }

            return View();

        }
    }
}
