using Microsoft.AspNetCore.Mvc;
using SayehMVC.Controllers;

namespace SayehMVC.Models
{
    public class GameLogic : GameController
    {
        public static string GuessTheNumber(int GuessByUser, int Rnd)
        {



            if (GuessByUser > Rnd)
                {
                    return "Your Number "+ GuessByUser +"  is too high";
                }
                else if (GuessByUser < Rnd)
                {
                    return "Your Number "+ GuessByUser + " is too low";
                }
                else
                {
                    return "You got it";
                }

        


        }

        //public static int RandomNumber()
        //{
        //    int MyNumberNum;
        //    Random random = new Random();
        //    MyNumberNum = random.Next(1,100);
        //    return MyNumberNum;
        //}

        //internal static string GuessTheNumber(int v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
