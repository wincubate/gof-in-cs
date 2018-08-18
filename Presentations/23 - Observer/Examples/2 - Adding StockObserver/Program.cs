using System;

namespace Wincubate.ObserverExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StockMarket market = new StockMarket())
            {
                StockObserver msftObserver = new StockObserver("MSFT", 87.5m);
                msftObserver.Register(market);
                StockObserver fbObserver = new StockObserver("FB", 177m);
                fbObserver.Register(market);

                Console.ReadLine();

                msftObserver.Deregister();
                fbObserver.Deregister();
            }
        }
    }
}
