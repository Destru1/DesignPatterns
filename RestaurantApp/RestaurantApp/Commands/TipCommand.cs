using RestaurantApp.Commands.Interfaces;
using RestaurantApp.Models.Clients;
using RestaurantApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApp.Commands
{
    public class TipCommand : ICommand
    {
        public string Execute(IRestaurant restaurant, params string[] arguments)
        {
            string clientName = arguments[0].ToString();
            decimal tipAmount = decimal.Parse((string)arguments[1]);

            IClient client = restaurant.FindClientByName(clientName);
            client.Tip(tipAmount);

            string message = string.Empty;

            if (tipAmount < 0)
            {
                message = $"Client {client.Name} tried to take {Math.Abs(tipAmount)}$.";
            }
            else
            {
                message = $"{client.Name} tipped {tipAmount}$";
            }
            
            return message;



        }
    }
}
