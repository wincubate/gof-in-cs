using System;

namespace Wincubate.ObserverLabs
{
    class StockObserver
    {
        public string Ticker { get; set; }
        public decimal Threshold { get; set; }

        private StockMarket _stockMarket;
        private bool _isPositionOpen;

        public StockObserver(
            string ticker,
            decimal threshold )
        {
            Ticker = ticker;
            Threshold = threshold;

            _isPositionOpen = true;
        }


        public void Register( StockMarket stockMarket )
        {
            stockMarket.StockTraded += OnStockTraded;

            _stockMarket = stockMarket;
        }


        public void Deregister()
        {
            _stockMarket.StockTraded -= OnStockTraded;

            _stockMarket = null;
        }

        private void OnStockTraded( object sender, StockTradedEventArgs e )
        {
            if (e.Ticker == Ticker)
            {
                if (e.Price > Threshold && _isPositionOpen == true)
                {
                    Console.WriteLine($"Selling {Ticker} position");
                    _isPositionOpen = false;
                }
            }
        }
    }
}