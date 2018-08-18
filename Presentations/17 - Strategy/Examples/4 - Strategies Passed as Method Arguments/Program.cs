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
            Func<Order, decimal> happyHourBillingStrategy = order => 0.5m * order.SuggestedSubtotal;

            Customer customer = new Customer( );

            customer.PlaceOrder(new Order
            {
                Product = new Peanuts(),
                Count = 1
            },
            normalBillingStrategy);

            customer.PlaceOrder(new Order
            {
                Product = new Beer(),
                Count = 3
            },
            happyHourBillingStrategy);

            // Happy Hour ends...

            customer.PlaceOrder(new Order
            {
                Product = new PepsiMax(),
                Count = 2
            },
            normalBillingStrategy);

            customer.Tab.Print();
        }
    }
}