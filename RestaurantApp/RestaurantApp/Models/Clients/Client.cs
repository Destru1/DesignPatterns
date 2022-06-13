using RestaurantApp.Helpers;
using RestaurantApp.Models.Interfaces;
using RestaurantApp.Models.Meals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantApp.Models.Clients
{
    public class Client : IClient
    {
        private string name;
        private decimal balance;
        private readonly ICollection<Meal> meals;

        public Client()
        {
            this.meals = new List<Meal>();
        }

        public Client(string name, decimal balance)
            : this()
        {
            this.Name = name;
            this.Balance = balance;
        }

        public string Name
        {
            get => this.name;
            private set { this.name = value; }
        }

        public decimal Balance
        {
            get => balance; set
            {
                balance = value;
            }
        }
        public IRestaurant Restaurant { get; set; }

        public void GetMeal(string name)
        {
            Meal meal = this.Restaurant.BuyMeal(this, name);
            this.meals.Add(meal);
        }

        public void Tip(decimal amount)
        {
            if (amount > 0)
            {
                this.balance += amount;

            }
   

        }
        public void RemoveMeal(string mealName)
        {
            Meal meal = this.FindMealByName(mealName);

            bool isNull = CustomValidator.IsNull(meal);
            if (isNull)
            {
                //Todo exception message invalid item
            }

            this.meals.Remove(meal);
            this.Restaurant.RemoveMealFromClient(this, meal);
        }
       
        private Meal FindMealByName(string mealName)
        {
            return this.meals.FirstOrDefault(m => m.Name.ToLower() == mealName.ToLower());
        }
    }
}
