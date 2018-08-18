using System;

namespace Wincubate.ObserverLabs
{
    class StockObserver : IObserver<StockTradedInfo>
    {
        public string Ticker { get; set; }
        public decimal Threshold { get; set; }

        private bool _isPositionOpen;

        #region IObserver<StockTradedInfo>

        public void OnNext( StockTradedInfo value )
        {
            if (value.Ticker == Ticker)
            {
                if (value.Price > Threshold && _isPositionOpen == true )
                {
                    Console.WriteLine($"Selling {Ticker} position");
                    _isPositionOpen = false;
                }
            }
        }

        public void OnCompleted()
        {
            Console.WriteLine($"Completed observing {Ticker}");
        }

        public void OnError( Exception error )
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Received an Exception from Observable: {error}");
            Console.ResetColor();
        }

        #endregion

        public StockObserver(
            string ticker,
            decimal threshold )
        {
            Ticker = ticker;
            Threshold = threshold;

            _isPositionOpen = true;
        }
    }
}