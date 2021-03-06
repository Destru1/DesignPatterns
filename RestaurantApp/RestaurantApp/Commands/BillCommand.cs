using RestaurantApp.Commands.Interfaces;
using RestaurantApp.Models.Interfaces;

namespace RestaurantApp.Commands
{
    public class BillCommand : ICommand
    {

        public string Execute(IRestaurant restaurant, params string[] arguments)
        {
            string clientName = arguments[0].ToString();
            string showBill = restaurant.ShowClientBill(clientName);

            return showBill;
        }
    }
}
