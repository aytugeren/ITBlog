using ITBlog.Admin.MVC.Models;
using ITBlog.Business.DTO;
using ITBlog.Business.PictureServiceFolder;
using Microsoft.AspNetCore.Mvc;

namespace ITBlog.Admin.MVC.Controllers.Picture
{
    public class PictureController : Controller
    {
        private readonly IPictureService _pictureService;

        public PictureController(IPictureService pictureService)
        {
            _pictureService = pictureService;
        }

        public IActionResult Index()
        {
            var pictureList = _pictureService.GetPicturesForAdmin();
            return View(pictureList);
        }

        public IActionResult GetPictureDetailById(Guid id)
        {
            var picture = new PictureDTO();

            if (id != Guid.Empty)
            {
                picture = _pictureService.GetPictureDetailById(id);
            }

            return View(picture);
        }

        [HttpPost]
        public IActionResult SubmitPicture(PictureSubmitModel model)
        {
            if (model == null)
            {
                ViewData["IsError"] = true;
                ViewData["ErrorMessageOfPictureSubmit"] = "Bilgiler Doğru Şekilde Gelmemiştir!";
                return Redirect($"GetPictureDetailById/{Guid.Empty}");
            }

            bool isUpdate = model.PictureId != Guid.Empty;

            var pictureDTO = new PictureDTO()
            {
                Id = isUpdate ? model.PictureId : Guid.NewGuid(),
                PictureTitle = model.PictureTitle,
                PicturePlace = model.PicturePlace,
                PictureUrl = model.PictureUrl,
                PictureAltName = model.PictureAltName,
                PictureContent = model.PictureContent,
                PictureExtension = model.PictureExtension,
                PictureFilePath = model.PictureFilePath,
                PictureIsDefault = model.PictureIsDefault,
                PictureName = model.PictureName,
                IsActive = model.PictureIsActive,
                IsDeleted = !model.PictureIsActive,
                CreatedDateTime = isUpdate ? model.CreatedDateTime : DateTime.Now,
                UpdatedDateTime = isUpdate ? DateTime.Now : null
            };

            
            var result = _pictureService.SubmitPicture(pictureDTO, isUpdate);
            if (result)
            {
                return Redirect("Index");
            }
            else
            {
                ViewData["IsError"] = true;
                ViewData["ErrorMessageOfPictureSubmit"] = "Kaydedilme İşleminde Sorun Yaşandı!";
                return Redirect($"GetPictureDetailById/{model.PictureId}");
            }
        }

        [HttpGet]
        public IActionResult RemovePictureById(Guid id)
        {
            _pictureService.RemovePicture(id);
            return Redirect("/Picture/Index");
        }

        [HttpPost]
        public IActionResult UploadPicture(IFormFile formFile)
        {
            return View();
        }
    }
}
