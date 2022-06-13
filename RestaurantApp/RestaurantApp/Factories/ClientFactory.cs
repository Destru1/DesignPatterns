using RestaurantApp.IO;
using RestaurantApp.IO.Interfaces;
using RestaurantApp.Models.Clients;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApp.Factories
{
    public class ClientFactory
    {
        private readonly IWriter writer;

        public ClientFactory()
        {
            this.writer = new ConsoleWriter();
        }
        public Client Create(object[] arguments)
        {
            string name = arguments[0].ToString();

            Client client = new Client(name, 0);

         
           // writer.WriteLine($" Client registered {client.Name}");
            return client;

            


        }
    }
}
