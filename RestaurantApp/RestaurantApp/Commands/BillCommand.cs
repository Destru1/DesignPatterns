using RestaurantApp.Commands.Interfaces;
using RestaurantApp.Models;
using RestaurantApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApp.Commands
{
    public class BillCommand : ICommand
    {

        public string Execute(IRestaurant restaurant, params string[] arguments)
        {
            string clientName = string.Join(' ', arguments);
            string showBill = restaurant.ShowClientBill(clientName);

            return showBill;
        }
    }
}
