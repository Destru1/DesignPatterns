using RestaurantApp.Commands.Interfaces;
using RestaurantApp.Constants;
using RestaurantApp.Models.Clients;
using RestaurantApp.Models.Interfaces;

namespace RestaurantApp.Commands
{
    public class OrderCommand : ICommand
    {
        public string Execute(IRestaurant restaurant, params string[] arguments)
        {
            string mealName = arguments[0].ToString();
            string clientName = arguments[1].ToString();


            IClient client = restaurant.FindClientByName(clientName);
            client.GetMeal(mealName);
            string message = string.Format(OutputMessages.MEAL_ADDED_TO_CLIENT, mealName, clientName);
            return message;

        }
    }
}
