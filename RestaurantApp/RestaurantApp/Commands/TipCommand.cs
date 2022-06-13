using RestaurantApp.Commands.Interfaces;
using RestaurantApp.Constants;
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
                message = string.Format(ExceptionMessages.CLIENT_TRIED_TO_TAKE_MONEY,clientName,Math.Abs(tipAmount));
            }
            else
            {
                message = string.Format(OutputMessages.CLIENT_TIPPED, clientName, tipAmount);
            }
            
            return message;



        }
    }
}
