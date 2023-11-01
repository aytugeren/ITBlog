using ITBlog.Business.AuthorServiceFolder;
using ITBlog.Business.DTO;
using ITBlog.Business.Enums;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ITBlog.Admin.MVC.Controllers.Author
{
    public class AuthorController : Controller
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAuthorInfosById(Guid id)
        {
            var authorInfo = _authorService.GetAuthorById(id);

            return View(authorInfo);
        }

        public PartialViewResult MyAccount()
        {
            var authenticationCookie = Request.HttpContext.User.Identities.FirstOrDefault();

            if (authenticationCookie != null)
            {
                var authorEmail = authenticationCookie.Claims.FirstOrDefault()?.Value;

                if (string.IsNullOrEmpty(authorEmail))
                {
                    return PartialView();
                }

                var author = _authorService.GetAuthorByEmail(authorEmail);

                return PartialView(author);
            }

            return PartialView();
        }
    }
}
