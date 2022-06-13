using RestaurantApp.Core.Interfaces;
using RestaurantApp.IO.Interfaces;
using RestaurantApp.Models;
using RestaurantApp.Models.Interfaces;
using System;

namespace RestaurantApp.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IRestaurant restaurant;
        private readonly CommandInterpreter commandInterpreter;

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
            this.restaurant = new Restaurant();
            this.commandInterpreter = new CommandInterpreter(this.restaurant);
        }
        public void Run()
        {

            while (GlobalConstants.IsAppRun)
            {

                try
                {
                    string input = this.reader.ReadLine();
                    string message = this.commandInterpreter.ProcessCommand(input);
                    this.writer.WriteLine(message);
                }
                catch (Exception e)
                {

                    this.writer.WriteLine(e.Message);
                }
            }
        }
    }
}
