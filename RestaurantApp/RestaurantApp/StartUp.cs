using RestaurantApp.Core;
using RestaurantApp.Core.Interfaces;
using RestaurantApp.IO;
using RestaurantApp.IO.Interfaces;
using System;

namespace RestaurantApp
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            IEngine engine = new Engine(reader, writer);
            engine.Run();
        }
    }
}
