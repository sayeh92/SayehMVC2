using Microsoft.AspNetCore.Mvc;
using SayehMVC.Controllers;

namespace SayehMVC.Models
{
    public class GameLogic : GameController
    {
        public static string GuessTheNumber(int GuessByUser, int Rnd)
        {

           while( GuessByUser == Rnd)
            {

             
                if (GuessByUser > Rnd)
                {
                    return "Your Number is too high";
                }
                if (GuessByUser < Rnd)
                {
                    return "Your Number is too low";
                }
                else
                {
                    return "Yout got it";
                }

                

            }

            return "...";

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
