using Microsoft.AspNetCore.Mvc;
using System;

namespace SayehMVC.Controllers
{
    public class GameController : Controller
    {


        [HttpGet]

        public IActionResult GuessView()
        {
            if ((string.IsNullOrEmpty(HttpContext.Session.GetString("intRnd"))))
            {
                int getRnd=

            }
            else
            {
                ViewBag.Rnd = HttpContext.Session.GetInt32("intRnd");
            }
            return View();

        }


        [HttpPost]
        public IActionResult GuessView(int GuessByUser)
        {
            if (!(string.IsNullOrEmpty(HttpContext.Session.GetString("intRnd"))))
            {
                string? StoredRnd = HttpContext.Session.GetString("intRnd");
                string response = Models.GameLogic.GuessTheNumber(Convert.ToInt32( GuessByUser));
                ViewBag.Msg = response;
               
            } 
            else
            {
                ViewBag.Msg = "Guess your number";
            }
            return View();
         
        }
    }
}
