using System;

namespace Wincubate.ObserverLabs
{
    class Program
    {
        static void Main( string[] args )
        {
            using (StockMarket market = new StockMarket())
            {
                StockObserver msftObserver = new StockObserver("MSFT", 87.5m);
                StockObserver fbObserver = new StockObserver("FB", 177m);

                using (market.Subscribe(msftObserver))
                using (market.Subscribe(fbObserver))
                {
                    Console.ReadLine();
                }
            }
        }
    }
}
