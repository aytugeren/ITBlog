using ITBlog.Admin.MVC.Models;
using ITBlog.Business.DTO;
using ITBlog.Business.PlaceServiceFolder;
using Microsoft.AspNetCore.Mvc;

namespace ITBlog.Admin.MVC.Controllers.Place
{
    public class PlaceController : Controller
    {
        private readonly IPlaceService _placeService;

        public PlaceController(IPlaceService placeService)
        {
            _placeService = placeService;
        }

        public IActionResult Index()
        {
            var placeList = _placeService.GetPlaceList();
            return View(placeList);
        }

        public IActionResult GetPlaceInfoById(Guid id)
        {
            var place = _placeService.GetPlaceById(id);

            return View(place);
        }

        public IActionResult SubmitPlace(PlaceSubmitModel model)
        {
            var place = new PlaceDTO();

            if (model != null)
            {
                var isUpdate = model.PlaceId != Guid.Empty;
                var placeId = model.PlaceId == Guid.Empty ? Guid.NewGuid() : model.PlaceId;

                place.PlaceName = model.PlaceName;
                place.Id = placeId;
                place.IsActive = true;
                place.IsDeleted = false;
                place.CreatedDateTime = DateTime.Now;

                var result = _placeService.SubmitPlace(place, isUpdate);

                if (result)
                {
                    return Redirect("/Place/Index");
                }
                else
                {
                    return Redirect($"/Place/GetPlaceByInfoById/{Guid.NewGuid()}");
                }
            }

            return Redirect("/Place/Index");
        }

        public IActionResult RemovePlace(Guid id)
        {
            _placeService.RemovePlace(id);

            return Redirect("/Place/Index");
        }
    }
}
