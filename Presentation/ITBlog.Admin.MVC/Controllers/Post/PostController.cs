using ITBlog.Admin.MVC.Models;
using ITBlog.Business.AuthorServiceFolder;
using ITBlog.Business.CategoryServiceFolder;
using ITBlog.Business.DTO;
using ITBlog.Business.PostServiceFolder;
using Microsoft.AspNetCore.Mvc;

namespace ITBlog.Admin.MVC.Controllers.Post
{
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        private readonly IAuthorService _authorService;
        private readonly ICategoryService _categoryService;

        public PostController(IPostService postService, IAuthorService authorService, ICategoryService categoryService)
        {
            _postService = postService;
            _authorService = authorService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var authenticationCookie = Request.HttpContext.User.Identities.FirstOrDefault();
            if (authenticationCookie != null)
            {
                var authorEmail = authenticationCookie.Claims.FirstOrDefault()?.Value;

                if (string.IsNullOrEmpty(authorEmail))
                {
                    return Redirect("/");
                }

                var author = _authorService.GetAuthorByEmail(authorEmail);

                if (author == null)
                {
                    return Redirect("/");
                }

                var posts = _postService.GetPostsByAuthorId(author.Id);

                return View(posts);
            }

            return Redirect("/");
        }

        public IActionResult GetPostInfoById(Guid id)
        {
            var post = _postService.GetPostById(id);
            var categoryList = _categoryService.GetCategories();

            if (post == null) return View(new CategoryPostEditModel()
            {
                Category = categoryList,
                Post = post ?? new PostDTO()
            });

            var model = new CategoryPostEditModel()
            {
                Category = categoryList,
                Post = post
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult SubmitPost(PostDTO postDto)
        {
            var authenticationCookie = Request.HttpContext.User.Identities.FirstOrDefault();
            if (authenticationCookie != null)
            {
                var authorEmail = authenticationCookie.Claims.FirstOrDefault()?.Value;

                if (string.IsNullOrEmpty(authorEmail))
                {
                    return Redirect("/");
                }

                var author = _authorService.GetAuthorByEmail(authorEmail);

                if (author == null)
                {
                    return Redirect("/");
                }

                postDto.AuthorId = author.Id;

                var result = _postService.SubmitPost(postDto);

                if (result)
                {
                    return Redirect("/Post/Index");
                }
            }

            return Redirect("/");
        }

        public IActionResult RemoveCategoryMapping(Guid categoryId, Guid postId)
        {
            if (categoryId != Guid.Empty && postId != Guid.Empty)
            {
                var result = _postService.RemovePostCategoryMapping(categoryId, postId);

                if (result)
                {
                    return Redirect($"/Post/GetPostInfoById/{postId}");
                }
            }

            return Redirect("/Post");
        }

        public IActionResult AddCategoryPost(Guid categoryId, Guid postId)
        {
            var result = _postService.AddUpdatePostCategoryMapping(categoryId, postId);

            if (result)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
