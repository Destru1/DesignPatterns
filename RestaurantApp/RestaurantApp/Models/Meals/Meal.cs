using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApp.Models.Meals
{
    public abstract class Meal
    {
        protected Meal(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name { get; set; }

        public decimal Price { get; set; }


        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{this.GetType().Name}");
            stringBuilder.AppendLine($"{this.Price}");

            return stringBuilder.ToString().Trim();
        }
    }
}
