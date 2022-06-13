using RestaurantApp.Models.Clients;
using RestaurantApp.Models.Meals;

namespace RestaurantApp.Models.Interfaces
{
    public interface IRestaurant
    {
        string RegisterClient(Client client);

        Meal BuyMeal(Client client, string mealName);

        void RemoveMealFromClient(Client client, Meal meal);

        string ShowClientBill(string clientName);

        string ShowMenu();
        void EarnedToday();

        IClient FindClientByName(string name);
    }
}
