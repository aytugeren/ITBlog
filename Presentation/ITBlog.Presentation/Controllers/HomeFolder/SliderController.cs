using ITBlog.Business.Enums;
using ITBlog.Business.PictureServiceFolder;
using Microsoft.AspNetCore.Mvc;

namespace ITBlog.Presentation.Controllers.HomeFolder
{
    public class SliderController : Controller
    {
        private readonly IPictureService _pictureService;

        public SliderController(IPictureService pictureService)
        {
            _pictureService = pictureService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult GetSliders()
        {
            var pictures = _pictureService.GetPicturesByPlaceName(PicturePlaceEnums.Slider.ToString());
            if (pictures != null)
            {
                return PartialView(pictures);
            }

            return PartialView();
        }
    }
}
