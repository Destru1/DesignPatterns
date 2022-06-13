namespace RestaurantApp.Constants
{
    public static class ExceptionMessages
    {
        public const string INVALID_MEAL_MESSAGE = "Meal {0} not found";
        public const string CLIENT_ALREADY_REGISTERED = "{0} is already registered.";
        public const string CLIENT_NOT_FOUND = "Client {0} not found.";
        public const string MEAL_NOT_FOUND_IN_CLIENT_ORDER = "Can't find {0} in {1}'s order.";
        public const string CLIENT_TRIED_TO_TAKE_MONEY = "Client {0} tried to take {1}$.";
        public const string NAME_CANNOT_BE_NULL = "Name can't be null.";
    }
}
