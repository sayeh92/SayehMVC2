using Microsoft.AspNetCore.Mvc;

namespace SayehMVC.Controllers
{
    public class GameController : Controller
    {

     
        public IActionResult GuessView(int num, int MyNumberNum)
        {

          
            if (num != MyNumberNum)
            {
                ViewBag.Msg = Models.GameLogic.GuessTheNumber(num, MyNumberNum);
                return View();
            }
            else
            {
                ViewBag.Msg = "Please Enter your Number";
                return View();
            }
        }
    }
}
