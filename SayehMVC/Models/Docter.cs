namespace SayehMVC.Models
{
    public class Docter
    {
        public static string FeverCheck (Double temp)
        {
            return (temp > 37) ? "Fever Alert, Do something" : "No fever, You are fine";
        }
    }
}

