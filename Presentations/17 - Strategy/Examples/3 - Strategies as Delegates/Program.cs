using System;

namespace Wincubate.StrategyExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Order, decimal> normalBillingStrategy = order => order.SuggestedSubtotal;
            Func<Order, decimal> studentBillingStrategy = order =>
                (order.Product is Beer ?
                    order.SuggestedSubtotal - (order.Count * 5) :
                    order.SuggestedSubtotal);
            Func<Order, decimal> regularBillingStrategy = order => 0.9m * order.SuggestedSubtotal;

            Customer customer = new Customer( normalBillingStrategy );

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
