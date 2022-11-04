using ITBlog.Business.AuthorServiceFolder;
using ITBlog.Business.DTO;
using ITBlog.Business.PlaceServiceFolder;
using ITBlog.Business.PostServiceFolder;
using Microsoft.AspNetCore.Mvc;

namespace ITBlog.Presentation.Controllers.PostFolder
{
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        private readonly IAuthorService _authorService;
        private readonly IPlaceService _placeService;

        public PostController(IPostService postService, IAuthorService authorService, IPlaceService placeService)
        {
            _postService = postService;
            _authorService = authorService;
            _placeService = placeService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult GetPosts(string place)
        {
            if (!string.IsNullOrEmpty(place))
            {
                var placeResult = _placeService.GetPlaceByName(place);

                if (placeResult != null || placeResult != default(PlaceDTO))
                {
                    var posts = _postService.GetPostsByPlace(placeResult.Id);

                    foreach (var post in posts)
                    {
                        var author = _authorService.GetAuthorById(post.AuthorId);
                        post.Author = author;
                    }

                    return PartialView(posts);
                }
            }

            return PartialView();
        }
    }
}
