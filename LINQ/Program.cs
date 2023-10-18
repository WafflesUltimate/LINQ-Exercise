namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
           List <string> videoGames = new List<string>() { "Valorant", "Mass Effect", "Stellaris", "Halo"};

           var videoGamesOrdered = videoGames.OrderBy(x => x.Length);

           foreach(var videoGame in videoGamesOrdered) { Console.WriteLine(videoGame); } 

        }
    }
}
