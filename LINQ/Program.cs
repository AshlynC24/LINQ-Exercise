using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            //list of video game names 
            //order list of games by length of game name
            //use => expression and method syntax
            var GameNames = new List<string>() { "Super Mario", "COD", "Rocket League", "Destiny", "Diablo" };

           
            GameNames.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));
        }
        
    }
}
