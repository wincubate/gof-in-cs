using System;

namespace Wincubate.ObserverLabs
{
    class StockTradedInfo
    {
        public string Ticker { get; }
        public decimal Price { get; }
        public DateTime Time { get; } = DateTime.Now;

        public StockTradedInfo( string ticker, decimal price )
        {
            Ticker = ticker;
            Price = price;
        }
    }
}