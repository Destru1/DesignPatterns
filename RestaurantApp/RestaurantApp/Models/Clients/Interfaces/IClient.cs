using RestaurantApp.Models.Interfaces;

namespace RestaurantApp.Models.Clients
{
    public interface IClient
    {
        string Name { get; }

        decimal Balance { get; }

        public IRestaurant Restaurant { get; set; }
        void GetMeal(string name);

        void Tip(decimal amount);

        void RemoveMeal(string name);

    }
}
