using RestaurantApp.Core;
using RestaurantApp.Core.Interfaces;
using RestaurantApp.IO;
using RestaurantApp.IO.Interfaces;

namespace RestaurantApp
{
    public class StartUp
    {
        public static void Main()
        {

            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            IEngine engine = new Engine(reader, writer);
            engine.Run();

        }
    }
}
