using System;

namespace Wincubate.ObserverExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StockMarket market = new StockMarket())
            {
                Console.ReadLine();
            }
        }
    }
}
