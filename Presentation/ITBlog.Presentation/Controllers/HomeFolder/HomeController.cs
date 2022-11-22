using ITBlog.Business.FooterServiceFolder;
using ITBlog.Business.PictureServiceFolder;
using ITBlog.Business.PlaceServiceFolder;
using ITBlog.Business.PostServiceFolder;
using ITBlog.Business.SocialMediaFolder;
using ITBlog.Business.SubscriberServiceFolder;
using ITBlog.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ITBlog.Presentation.Controllers.HomeFolder
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFooterService _footerService;
        private readonly ISubscriberService _subscriberService;
        private readonly IPostService _postService;
        private readonly IPlaceService _placeService;
        private readonly IPictureService _pictureService;
        private readonly ISocialMediaService _socialMediaService;

        public HomeController(ILogger<HomeController> logger, IFooterService footerService, ISubscriberService subscriberService, IPostService postService, IPlaceService placeService, IPictureService pictureService, ISocialMediaService socialMediaService)
        {
            _logger = logger;
            _footerService = footerService;
            _subscriberService = subscriberService;
            _postService = postService;
            _placeService = placeService;
            _pictureService = pictureService;
            _socialMediaService = socialMediaService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public PartialViewResult Footer()
        {
            var footerModel = _footerService.GetFooter();

            return PartialView(footerModel);
        }

        [HttpPost]
        public JsonResult GetSubsBox(string email)
        {
            var result = _subscriberService.AddOrUpdateTheSubscriber(email);
            return new JsonResult(result);
        }

        public PartialViewResult GetHomeRightSiderBar()
        {
            var place = _placeService.GetPlaceByName("HomeSideBar");

            if (place!= null)
            {
                HomeSideBarModel model = new HomeSideBarModel();
                var recentPosts = _postService.GetPostsByPlace(place.Id);
                var pictures = _pictureService.GetPicturesByPlaceName("HomeSideBar");
                var cvOfUser = _pictureService.GetCVByUserName("AytugEren");
                var socialMedias = _socialMediaService.GetSocialMediasByUserName("aytuğeren");

                model.RecentPosts = recentPosts;
                model.Pictures = pictures;
                model.CVPicture = cvOfUser;
                model.SocialMedias = socialMedias;

                return PartialView(model);
            }

            return PartialView();
        }

        public IActionResult AboutMe()
        {
            return View();
        }
    }
}