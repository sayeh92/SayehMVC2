using Microsoft.AspNetCore.Mvc;
using SayehMVC.Controllers;

namespace SayehMVC.Models
{
    public class GameLogic : GameController
    {
        public static string GuessTheNumber(int num, int MyNumberNum)
        {
          
            if (num > MyNumberNum)
            {
                return "Your Number is too high";
            }
            if (num < MyNumberNum)
            {
                return "Your Number is too low";
            }
            else /*(num == MyNumberNum)*/
            {
                return "Yout got it";
            }
        }

        public static int RandomNumber()
        {
            int MyNumberNum;
            Random random = new Random();
            MyNumberNum = random.Next(1,100);
            return MyNumberNum;
        }

    }
}
