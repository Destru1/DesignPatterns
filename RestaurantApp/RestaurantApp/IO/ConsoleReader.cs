using RestaurantApp.IO.Interfaces;
using System;

namespace RestaurantApp.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
