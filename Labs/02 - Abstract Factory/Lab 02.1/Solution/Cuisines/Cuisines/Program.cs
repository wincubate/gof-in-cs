namespace Cuisines
{
    class Program
    {
        static void Main(string[] args)
        {
            //ICuisine cuisine = new ItalianCuisine();
            ICuisine cuisine = new IndianCuisine();

            IMainCourse main = cuisine.CreateMainCourse();
            main.Consume();

            IDessert dessert = cuisine.CreateDessert();
            dessert.Enjoy();
        }
    }
}
