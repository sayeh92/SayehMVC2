using Microsoft.AspNetCore.Mvc;

namespace SayehMVC.Controllers
{
    public class FeverController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
