using RestaurantApp.Commands.Interfaces;
using RestaurantApp.Factories;
using RestaurantApp.Factories.Interfaces;
using RestaurantApp.Models;
using RestaurantApp.Models.Interfaces;
using System;
using System.Linq;

namespace RestaurantApp.Core
{
    public class CommandInterpreter
    {
        private readonly IRestaurant restaurant;
        private readonly IFactory<ICommand> commandFactory;
            

        public CommandInterpreter(IRestaurant restaurant)
        {
            
            this.restaurant = restaurant;
            this.commandFactory = new CommandFactory();
        }

        public string ProcessCommand(string input)
        {
            string[] tokens = input.Split(' ').ToArray();

            string commandType = tokens.First();
            string[] arguments = tokens.Skip(1).ToArray();

            ICommand command = this.commandFactory.Create(commandType);

            string result = command.Execute(this.restaurant, arguments);
            return result;

        
             
        }
    }
}
