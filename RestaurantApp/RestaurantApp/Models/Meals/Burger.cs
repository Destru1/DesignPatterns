using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApp.Models.Meals
{
    public class Burger : Meal
    {
        public Burger(string name, decimal price) : base(name, price)
        {
        }
    }
}
