using RestaurantApp.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

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
