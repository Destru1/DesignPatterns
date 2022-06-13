using RestaurantApp.Models;
using RestaurantApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApp.Commands.Interfaces
{
    public interface ICommand
    {
        public string Execute(IRestaurant restaurant, params string[] arguments);
    }
}
