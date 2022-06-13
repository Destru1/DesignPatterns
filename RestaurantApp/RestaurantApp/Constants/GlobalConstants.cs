using RestaurantApp.Models.Meals;
using System.Collections.Generic;

namespace RestaurantApp
{
    public static class GlobalConstants
    {
        public static List<Meal> Meals = new List<Meal>()
        {
            new Burger("BeefBurger",7.90m),
            new Burger("ChickenBurger",6.90m),
            new Burger("VeganBurger",9.30m),
            new Pizza("Margherita",6),
            new Pizza("Pepperoni",8.99m),
            new Pizza("Prosciutto",10.20m),
            new Salad("CesarSalad",10.50m),
            new Salad("GreekSalad",7.40m),
            new Salad("ShopskaSalad",6.20m),
        };


        public static bool IsAppRun = true;
    }
}
