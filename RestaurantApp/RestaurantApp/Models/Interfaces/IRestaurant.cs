using RestaurantApp.Models.Clients;
using RestaurantApp.Models.Meals;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApp.Models.Interfaces
{
    public interface IRestaurant
    {
        string RegisterClient(Client client);

        Meal BuyMeal(Client client, string mealName);

        void RemoveMealFromClient(Client client,Meal meal);

        string ShowClientBill(string clientName);
        IClient FindClientByName(string name);
    }
}
