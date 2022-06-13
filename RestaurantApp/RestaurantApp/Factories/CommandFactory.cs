using RestaurantApp.Commands.Interfaces;
using RestaurantApp.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace RestaurantApp.Factories
{
    public class CommandFactory : IFactory<ICommand>
    {
        public const string COMMAND = "command";
        public ICommand Create(params string[] input)
        {
            string commandInput = input[0].ToLower() + COMMAND;


            Type commandType = Assembly.GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name.ToLower() == commandInput);

            ICommand command = (ICommand)Activator.CreateInstance(commandType);

            return command;
        }
    }
}
