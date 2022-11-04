namespace SayehMVC.Models
{
    public class Docter
    {
        public static string FeverCheck (Double temp)
        {
            return (temp > 37) ? "Doctor Vader says you have fever...have a cookie" : "Doctor Vader says you don't have any fever...so no cookie";
        }
    }
}

