using RestaurantApp.Commands.Interfaces;
using RestaurantApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApp.Commands
{
    public class MenuCommand : ICommand
    {
        public string Execute(IRestaurant restaurant, params string[] arguments)
        {
            string message = restaurant.ShowMenu();
            return message;
        }
    }
}
