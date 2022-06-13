using RestaurantApp.Constants;
using RestaurantApp.Helpers;
using RestaurantApp.IO;
using RestaurantApp.IO.Interfaces;
using RestaurantApp.Models.Clients;
using RestaurantApp.Models.Interfaces;
using RestaurantApp.Models.Meals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantApp.Models
{
    public class Restaurant : IRestaurant
    {
        private readonly ICollection<Meal> meals;
        private readonly ICollection<Client> clients;
        private readonly IDictionary<Client, List<Meal>> clientMeal;
        private readonly IWriter writer;
        public Restaurant()
        {
            this.meals = GlobalConstants.Meals;
            this.clients = new List<Client>();
            this.clientMeal = new Dictionary<Client, List<Meal>>();
            this.writer = new ConsoleWriter();


        }

        public string RegisterClient(Client client)
        {
            bool isAlreadyRegistered = this.clients.Any(c => c.Name == client.Name);

            if (isAlreadyRegistered)
            {
                string errorMessage = string.Format(ExceptionMessages.CLIENT_ALREADY_REGISTERED, client.Name);
                throw new ArgumentException(errorMessage);

            }

            this.clients.Add(client);
            this.clientMeal.Add(client, new List<Meal> { });
            client.Restaurant = this;

            string message = string.Format(OutputMessages.CLIENT_REGISTERED, client.Name);

            return message;
        }

        public Meal BuyMeal(Client client, string mealName)
        {
            Meal meal = this.FindMealByName(mealName);

            client.Balance += meal.Price;
            this.clientMeal[client].Add(meal);

            return meal;
        }



        public string ShowClientBill(string clientName)
        {
            StringBuilder stringBuilder = new StringBuilder();

            Client client = (Client)FindClientByName(clientName);

            string message = this.clientMeal[client].Count == 0 ? "Bill: nothing ordered for" : "Bill for";

            stringBuilder.AppendLine(message + " " + client.Name);
            foreach (var item in this.clientMeal[client])
            {
                stringBuilder.AppendLine(item.Name.ToString() + " " + item.Price.ToString());


            }

            decimal currentBalance = client.Balance;
            string totalBalanceMessage = $"Total {currentBalance}$";
            stringBuilder.AppendLine(new string('-', 20));
            stringBuilder.AppendLine(totalBalanceMessage);

            return stringBuilder.ToString().Trim();
        }

        public void RemoveMealFromClient(Client client, Meal meal)
        {
            bool isValid = this.clientMeal[client].Contains(meal);

            if (isValid == false)
            {
                string message = string.Format(ExceptionMessages.MEAL_NOT_FOUND_IN_CLIENT_ORDER, meal, client);
                throw new Exception(message);

            }
            client.Balance = client.Balance - meal.Price;
            this.clientMeal[client].Remove(meal);


        }

        public void EarnedToday()
        {
            decimal earnedToday = 0;

            foreach (var item in this.clients)
            {
                earnedToday += item.Balance;
            }
            string message = $"Today's total: {earnedToday}";

            writer.WriteLine(message);


        }
        public IClient FindClientByName(string name)
        {
            IClient client = this.clients.SingleOrDefault(x => x.Name.ToLower() == name.ToLower());

            bool isNull = CustomValidator.IsNull(client);
            if (isNull)
            {
                string message = string.Format(ExceptionMessages.CLIENT_NOT_FOUND, name);
                throw new Exception(message);

            }


            return client;
        }


        private Meal FindMealByName(string mealName)
        {
            Meal meal = null;
            bool isMealInMenu = false;

            foreach (var item in clientMeal)
            {
                isMealInMenu = item.Value.Any(m => m.Name == mealName);

                meal = item.Value.SingleOrDefault(meal => meal.Name == mealName);
            }

            meal = this.meals.SingleOrDefault(m => m.Name.ToLower() == mealName.ToLower());

            return meal;
        }

    }
}
