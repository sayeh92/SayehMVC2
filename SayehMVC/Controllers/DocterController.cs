using Microsoft.AspNetCore.Mvc;

namespace SayehMVC.Controllers
{
    public class DocterController : Controller
    {
        [HttpGet]
        public IActionResult FeverCheck(double temp)
        {

            if (temp != 0)
            {
                ViewBag.Msg = Models.Docter.FeverCheck(temp);
                return View();
            }
            else
            {
                ViewBag.Msg = "Please Enter your temperature and then hit Submit";
                return View();
            }



        }

      
    }
}

