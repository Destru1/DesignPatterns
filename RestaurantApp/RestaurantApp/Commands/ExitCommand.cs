using RestaurantApp.Commands.Interfaces;
using RestaurantApp.Constants;
using RestaurantApp.Models.Interfaces;

namespace RestaurantApp.Commands
{
    public class ExitCommand : ICommand
    {
        public string Execute(IRestaurant restaurant, params string[] arguments)
        {
            string message = string.Format(OutputMessages.SHUTDOWN_APP);
            restaurant.EarnedToday();
            GlobalConstants.IsAppRun = false;
            return message;

        }
    }
}
