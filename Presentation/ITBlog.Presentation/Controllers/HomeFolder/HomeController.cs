using ITBlog.Business.FooterServiceFolder;
using ITBlog.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ITBlog.Presentation.Controllers.HomeFolder
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFooterService _footerService;

        public HomeController(ILogger<HomeController> logger, IFooterService footerService)
        {
            _logger = logger;
            _footerService = footerService;
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

    }
}