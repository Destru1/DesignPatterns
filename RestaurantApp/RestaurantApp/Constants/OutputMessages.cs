using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApp.Constants
{
    public static class OutputMessages
    {
        public const string SHUTDOWN_APP = "Shutting down app...";
        public const string CLIENT_REGISTERED = "Client {0} registered.";
        public const string MEAL_ADDED_TO_CLIENT = "{0} added to {1}'s order.";
        public const string MEAL_REMOVED_FROM_CLIENT = "{0} removed from {1}'s order.";
        public const string CLIENT_TIPPED = "{0} tipped {1}$.";
    }
}
