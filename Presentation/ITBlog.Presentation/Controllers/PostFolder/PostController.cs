using ITBlog.Business.AuthorServiceFolder;
using ITBlog.Business.CommentServiceFolder;
using ITBlog.Business.DTO;
using ITBlog.Business.PlaceServiceFolder;
using ITBlog.Business.PostServiceFolder;
using ITBlog.Presentation.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ITBlog.Presentation.Controllers.PostFolder
{
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        private readonly IAuthorService _authorService;
        private readonly IPlaceService _placeService;
        private readonly ICommentService _commentService;

        public PostController(IPostService postService, IAuthorService authorService, IPlaceService placeService, ICommentService commentService)
        {
            _postService = postService;
            _authorService = authorService;
            _placeService = placeService;
            _commentService = commentService;
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
                    if (posts != null)
                    {
                        foreach (var post in posts)
                        {
                            var author = _authorService.GetAuthorById(post.AuthorId);
                            post.Author = author;
                        }
                    }

                    return PartialView(posts);
                }
            }

            return PartialView();
        }

        [Authorize]
        public IActionResult GetPostById(Guid id)
        {
            PostDetailModel model = new PostDetailModel();
            var post = _postService.GetPostById(id);

            if (post != null)
            {
                var relatedPosts = _postService.GetPostsByCategory(post.Categories.Select(x => x.CategoryId).ToArray(), post.AuthorId);

                var dayBeforePosts = _postService.GetPostsByDeterminedDayBefore(10);

                var comments = _commentService.GetCommentsByPostId(post.Id);

                model.Post = post;
                model.RecentPosts = dayBeforePosts.Where(x => x.Id != id).ToList();
                model.RelatedPosts = relatedPosts.Where(x => !dayBeforePosts.Select(y => y.Id).Contains(x.Id) && x.Id != id).ToList();
                model.Comments = comments != null ? comments : new List<CommentDTO>();
                model.Author = post.Author;

                return View(model);
            }
            else
            {
                return RedirectToAction("Error", "Home");
            }
        }
    }
}
