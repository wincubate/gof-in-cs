namespace Wincubate.StrategyExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer( new NormalBillingStrategy() );

            customer.PlaceOrder(new Order
            {
                Product = new Peanuts(),
                Count = 1
            });

            customer.PlaceOrder(new Order
            {
                Product = new Beer(),
                Count = 3
            });

            customer.PlaceOrder(new Order
            {
                Product = new PepsiMax(),
                Count = 2
            });

            customer.Tab.Print();
        }
    }
}
