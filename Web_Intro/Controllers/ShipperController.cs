using Microsoft.AspNetCore.Mvc;

namespace Web_Intro.Controllers
{
    public class ShipperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
