using RestaurantApp.Core.Interfaces;
using RestaurantApp.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApp.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }
        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
