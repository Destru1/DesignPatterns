namespace RestaurantApp.Helpers
{
    public static class CustomValidator
    {
        public static bool IsNullOrWhiteSpace(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static bool IsNull(object obj)
        {
            return obj == null;
        }

    }
}
