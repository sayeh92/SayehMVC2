using Microsoft.AspNetCore.Mvc;
using SayehMVC.Controllers;

namespace SayehMVC.Models
{
    public class GameLogic : GameController
    {
        public static string GuessTheNumber(int GuessByUser, int MyRandomNum)
        {

           

            if (GuessByUser > MyRandomNum)
                {
                    return "Your Number "+ GuessByUser +"  is too high";
                }
                else if (GuessByUser < MyRandomNum)
                {
                    return "Your Number "+ GuessByUser + " is too low";
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
