using RestaurantApp.Models.Meals;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApp
{
   public class GlobalConstants
    {
        public static List<Meal> Meals = new List<Meal>()
        {
            new Burger("BeefBurger",7.40m),
           
        };


        public static bool IsAppRun = true;
    }
}
