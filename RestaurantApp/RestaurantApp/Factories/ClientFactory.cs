using RestaurantApp.IO;
using RestaurantApp.IO.Interfaces;
using RestaurantApp.Models.Clients;

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

            return client;




        }
    }
}
