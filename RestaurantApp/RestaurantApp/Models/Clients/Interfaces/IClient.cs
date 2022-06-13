using RestaurantApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApp.Models.Clients
{
    public interface IClient
    {
        string Name { get; }

        decimal Balance { get; }

        public IRestaurant Restaurant { get; set; }
        void GetMeal(string name);

        void RemoveMeal(string name);

    }
}
