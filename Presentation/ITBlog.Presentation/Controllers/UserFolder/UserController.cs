using ITBlog.Business.DTO;
using ITBlog.Business.UserServiceFolder;
using ITBlog.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITBlog.Presentation.Controllers.UserFolder
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp(UserDTO model, string email, string isFromRegister)
        {
            if (!string.IsNullOrEmpty(email))
            {
                if (!string.IsNullOrEmpty(isFromRegister))
                {
                    model.Password = isFromRegister;
                }
                model.Email = email;    
            }
            return View(model);
        }

        [HttpGet]
        public JsonResult GetUserNameIsExist(string userName)
        {
            var result = _userService.GetUserByUserName(userName);
            if (result != null)
            {
                if (result != default(UserDTO))
                {
                    return new JsonResult(true);
                }
            }

            return new JsonResult(false);
        }

        [HttpGet]
        public JsonResult GetEmailIsExists(string email)
        {
            var result = _userService.GetUserByEmail(email);
            if (result != null)
            {
                if (result != default(UserDTO))
                {
                    return new JsonResult(true);
                }
            }

            return new JsonResult(false);
        }

        [HttpPost]
        public JsonResult SubmitForUserName([FromBody] UserModel model)
        {
            if (model != null && model != default(UserModel))
            {
                UserDTO dtoModel = new UserDTO();
                dtoModel.UserName = model.UserName;
                dtoModel.FirstName = model.FirstName;
                dtoModel.SecondName = model.SecondName;
                dtoModel.LastName = model.LastName;
                dtoModel.Birthday = DateTime.Parse(model.Birthday);
                dtoModel.Email = model.Email;
                dtoModel.Password = model.Password;
                dtoModel.LastVisitedDate = DateTime.Now;

                var result = _userService.InserToUser(dtoModel);

                return new JsonResult(result);
            }

            return new JsonResult(false);
        }
    }
}
