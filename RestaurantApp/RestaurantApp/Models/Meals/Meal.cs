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


    }
}
