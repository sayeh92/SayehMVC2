using Microsoft.AspNetCore.Mvc;
using SayehMVC.Controllers;

namespace SayehMVC.Models
{
    public class GameLogic : GameController
    {
        public static string GuessTheNumber(int guess, int Rnd)
        {

           

            if (guess > Rnd)
                {
                    return "Your Number "+ guess + "  is too high";
                }
                else if (guess < Rnd)
                {
                    return "Your Number "+ guess + " is too low";
                }
                else
                {
                    return "You got it";
                }

        


        }

      //  public static int randomnumber()
       // {
            //int mynumbernum;
            //random random = new random();
            //mynumbernum = random.next(0,100);
            //return mynumbernum;
          //  random myrandomnum = new random();
           // return myrandomnum.next(0,100);
        //}

        internal static string GuessTheNumber(int v)
        {
            throw new NotImplementedException();
        }

      
    }
}
