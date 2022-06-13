using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApp.Models.Meals
{
    public class Salad : Meal
    {
        public Salad(string name, decimal price) : base(name, price)
        {
        }
    }
}
