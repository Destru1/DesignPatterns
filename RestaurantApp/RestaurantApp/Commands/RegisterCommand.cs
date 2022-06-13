using RestaurantApp.Commands.Interfaces;
using RestaurantApp.Factories;
using RestaurantApp.IO.Interfaces;
using RestaurantApp.Models;
using RestaurantApp.Models.Clients;
using RestaurantApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApp.Commands
{
    public class RegisterCommand : ICommand
    {
        private readonly ClientFactory client;

        public RegisterCommand()
        {
            this.client = new ClientFactory();
        }
        public string Execute(IRestaurant restaurant, params string[] arguments)
        {
            Client client = this.client.Create(arguments);

            string message = restaurant.RegisterClient(client); 
            return message;

        }
    }
}
