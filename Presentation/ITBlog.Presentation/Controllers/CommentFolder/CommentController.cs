using ITBlog.Business.CommentServiceFolder;
using ITBlog.Business.UserServiceFolder;
using ITBlog.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

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
            var user = _userService.GetUserByEmail(model.Email);
            if (user == null)
            {
                //return RedirectToAction("SignUp", "User", new {email = model.Email});
                return RedirectToAction("GetPostById", "Post", new { id = model.PostId });
            }
            else
            {
                return RedirectToAction("GetPostById", "Post", new { id = model.PostId });
            }
        }
    }
}
