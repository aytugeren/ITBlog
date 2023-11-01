using ITBlog.Admin.MVC.Models;
using ITBlog.Business.AuthorServiceFolder;
using ITBlog.Business.DTO;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ITBlog.Admin.MVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAuthorService _authorService;
        IConfiguration _configuration;

        public LoginController(IAuthorService authorService, IConfiguration configuration)
        {
            _authorService = authorService;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Login(LoginModel model)
        {
            AuthorDTO authorDTO = new AuthorDTO();

            if (model != null)
            {
                authorDTO.Password = model.Password;
                authorDTO.Email = model.Email;

                string saltPassword = _configuration["Authentication:SaltPassword"];

                if (_authorService.CheckAuthor(authorDTO, saltPassword))
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.NameIdentifier, model.Email)
                    };

                    var userIdentity = new ClaimsIdentity(claims, "loginAdmin");
                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                    await HttpContext.SignInAsync(principal);

                    return RedirectToAction("Index", "Home");
                }
            }

            return View();
        }
    }
}
