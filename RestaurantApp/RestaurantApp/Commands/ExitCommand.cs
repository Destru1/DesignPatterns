using RestaurantApp.Commands.Interfaces;
using RestaurantApp.Models;
using RestaurantApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApp.Commands
{
    public class ExitCommand : ICommand
    {
        public string Execute(IRestaurant restaurant, params string[] arguments)
        {
            GlobalConstants.IsAppRun = false;
            string message = "Shutting down app.";
            return message;
            //Todo add constant message
           
        }
    }
}
