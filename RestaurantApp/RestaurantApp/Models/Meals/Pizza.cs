using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApp.Models.Meals
{
    public class Pizza : Meal
    {
        public Pizza(string name, decimal price) : base(name, price)
        {
        }
    }
}
