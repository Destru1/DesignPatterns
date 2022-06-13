using RestaurantApp.Models.Interfaces;

namespace RestaurantApp.Commands.Interfaces
{
    public interface ICommand
    {
        public string Execute(IRestaurant restaurant, params string[] arguments);
    }
}
