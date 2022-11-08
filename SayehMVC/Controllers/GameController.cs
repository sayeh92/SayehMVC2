using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SayehMVC.Models;
using System;

namespace SayehMVC.Controllers
{
    public class GameController : Controller
    {

        [HttpPost]
        public IActionResult GuessView(int Guess)
        {
            if (!(string.IsNullOrEmpty(HttpContext.Session.GetString("intRnd"))))
            {
                int storedRnd = (int)HttpContext.Session.GetInt32("intRnd");
                string response = GameLogic.GuessTheNumber(Convert.ToInt32(Guess), storedRnd);

                ViewBag.Msg = response;

            }
            else
            {
                ViewBag.Msg = "Enter a number between 1 and 100 and Submit";
            }
            return View();
        }



        [HttpGet]
        public IActionResult GuessView()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("intRnd")))
            {
                int getRnd = GameLogic.RandomNumber();
                HttpContext.Session.SetInt32("intRnd", getRnd);
                ViewBag.Rnd = getRnd;
            }
            else
            {
                ViewBag.Rnd = HttpContext.Session.GetInt32("intRnd");
            }
            return View();
        }



        [HttpGet]
        public IActionResult Reset()
        {
            int getRnd = GameLogic.RandomNumber();
            HttpContext.Session.SetInt32("intRnd", getRnd);
            ViewBag.Rnd = getRnd;
            return RedirectToAction(nameof(GuessView));
        }
    }



    ////Creating the
    ////Random Number
    //Random randomNumber = new Random();

    //[HttpGet]

    //public IActionResult GuessView()
    //{
    //    //if ((string.IsNullOrEmpty(HttpContext.Session.GetString("intRnd"))))
    //    //{
    //    //    int getRnd=

    //    //}
    //    //else
    //    //{
    //    //    ViewBag.Rnd = HttpContext.Session.GetInt32("intRnd");
    //    //}

    //    //reading the cookie
    //    string? RandomNumCookie = Request.Cookies["randomNumber"];
    //    if ( RandomNumCookie != null)
    //    {
    //        CookieOptions MyCookie = new CookieOptions();
    //        MyCookie.Expires = DateTime.Now.AddMinutes(0);
    //        randomNumber.Next(0, 100);
    //        Response.Cookies.Append("randomNumber", "", MyCookie);
    //    }
    //    return View();

    //}


    //[HttpPost]
    //public IActionResult GuessView(int GuessByUser)
    //{
    //    //if (!(string.IsNullOrEmpty(HttpContext.Session.GetString("intRnd"))))
    //    //{
    //    //    string? StoredRnd = HttpContext.Session.GetString("intRnd");
    //    //    string response = Models.GameLogic.GuessTheNumber(Convert.ToInt32( GuessByUser));
    //    //    ViewBag.Msg = response;

    //    //} 
    //    //else
    //    //{
    //    //    ViewBag.Msg = "Guess your number";
    //    //}

    //    //reading the cookie
    //    string? RandomNumCookie = Request.Cookies["randomNumber"];
    //    int Rnd;

    //    //Checking whether the cookie is set or not
    //    if (RandomNumCookie == null)
    //    {
    //        //seting up the  cookie with CookieOptions
    //        CookieOptions MyCookie = new CookieOptions();
    //        //expiration time
    //        MyCookie.Expires = DateTime.Now.AddMinutes(10);
    //        //min and max for random number
    //        int num = randomNumber.Next(0,100);
    //        //adding a new cookie
    //        Response.Cookies.Append("randomNumber", num.ToString(), MyCookie);
    //        //assigning num to Rnd
    //        Rnd = num;
    //    }
    //    else 
    //    {
    //        //Conversion the cookie from string to int
    //        Rnd = int.Parse(RandomNumCookie);
    //    }

    //    ViewBag.Number = Models.GameLogic.GuessTheNumber(GuessByUser, Rnd);
    //    return View();

    //}
}

