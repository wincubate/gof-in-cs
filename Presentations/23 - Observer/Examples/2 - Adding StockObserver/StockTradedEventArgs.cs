using System;

namespace Wincubate.ObserverExamples
{
    class StockTradedEventArgs : EventArgs
    {
        public string Ticker { get; }
        public decimal Price { get; }
        public DateTime Time { get; } = DateTime.Now;

        public StockTradedEventArgs( string ticker, decimal price )
        {
            Ticker = ticker;
            Price = price;
        }
    }
}
