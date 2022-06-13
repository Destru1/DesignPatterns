using RestaurantApp.Commands.Interfaces;
using RestaurantApp.Constants;
using RestaurantApp.Models.Clients;
using RestaurantApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApp.Commands
{
    public class RemoveMealCommand : ICommand
    {
        public string Execute(IRestaurant restaurant, params string[] arguments)
        {
            string clientName = arguments[0].ToString();
            string mealName = arguments[1].ToString();

            IClient client = restaurant.FindClientByName(clientName);
            client.RemoveMeal(mealName);

            string message = string.Format(OutputMessages.MEAL_REMOVED_FROM_CLIENT, mealName, clientName);
            return message;

        }
    }
}
