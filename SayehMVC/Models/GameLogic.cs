using Microsoft.AspNetCore.Mvc;
using SayehMVC.Controllers;

namespace SayehMVC.Models
{
    public class GameLogic : GameController
    {
        public static string GuessTheNumber(int Guess, int MyRandomNum)
        {

           

            if (Guess > MyRandomNum)
                {
                    return "Your Number "+ Guess + "  is too high";
                }
                else if (Guess < MyRandomNum)
                {
                    return "Your Number "+ Guess + " is too low";
                }
                else
                {
                    return "You got it";
                }

        


        }

        public static int RandomNumber()
        {
            //int MyNumberNum;
            //Random random = new Random();
            //MyNumberNum = random.Next(0,100);
            //return MyNumberNum;
            Random MyRandomNum = new Random();
            return MyRandomNum.Next(0,100);
        }

        internal static string GuessTheNumber(int v)
        {
            throw new NotImplementedException();
        }

      
    }
}
