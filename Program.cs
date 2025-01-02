using Helldivers.Api;

namespace Helldivers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var client = new ApiClient("api.dev.thejacksons.us", "admin@thejacksons.us");
            var planet = client.GetPlanet(61).Result;
            Console.WriteLine(planet.Name);
            Console.WriteLine("Done");
            _ = Console.ReadLine();
        }
    }
}
