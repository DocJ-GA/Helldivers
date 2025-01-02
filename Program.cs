using Helldivers.Api;

namespace Helldivers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var client = new ApiClient("api.dev.thejacksons.us", "admin@thejacksons.us");
            var planets = client.GetPlanetEvents().Result;
            Console.WriteLine(planets.Count() + " events");
            Console.WriteLine("Done");
            _ = Console.ReadLine();
        }
    }
}
