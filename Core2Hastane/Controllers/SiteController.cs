using Microsoft.AspNetCore.Mvc;

namespace Core2Hastane.Controllers
{
    public class SiteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult InnerPage()
        {
            return View();
        }

    }
}
