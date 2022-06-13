using RestaurantApp.Constants;
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
            get
            {
                return this.name;
            }

            private set
            {
                this.ValidateName(value);
                this.name = value;
            }
        }

        public decimal Balance
        {
            get => balance;
            set
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
                string message = String.Format(ExceptionMessages.INVALID_MEAL_MESSAGE, mealName);
                throw new Exception(message);
            }

            this.meals.Remove(meal);
            this.Restaurant.RemoveMealFromClient(this, meal);
        }

        private Meal FindMealByName(string mealName)
        {
            return this.meals.FirstOrDefault(m => m.Name.ToLower() == mealName.ToLower());
        }

        private void ValidateName(string name)
        {
            bool isNullOrWhiteSpace = CustomValidator.IsNullOrWhiteSpace(name);
            if (isNullOrWhiteSpace)
            {
                string result = string.Format(ExceptionMessages.NAME_CANNOT_BE_NULL);
                throw new Exception(result);
            }
        }
    }
}
