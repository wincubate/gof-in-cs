using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading;

namespace Wincubate.ObserverExamples
{
    sealed class StockMarket : IDisposable
    {
        public StockMarket()
        {
            Initialize();
        }

        private void OnStockTraded( string ticker, decimal latest )
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine( $"{ticker} traded at USD {latest:f2}");
            Console.ResetColor();
        }

        #region Nasty Setup Code :-)

        private ConcurrentDictionary<string, decimal> _stocks;
        private Random _random;
        private Timer _timer;

        private void Initialize()
        {
            _stocks = new ConcurrentDictionary<string, decimal>
            {
                ["MSFT"] = 87m,
                ["FB"] = 176m,
                ["GOOG"] = 1234.56m
            };
            _random = new Random((int)DateTime.Now.Ticks);
            _timer = new Timer(Tick, null, 1000 + _random.Next(1000), 1000 + _random.Next(1000));
        }

        private void Tick( object state )
        {
            try
            {
                // Choose random stock ticker
                int index = _random.Next(_stocks.Count);
                string ticker = _stocks.Keys.ToList()[index];
                decimal latest = _stocks[ticker] += (_random.Next(100) / 200m);
                _stocks[ticker] = latest;

                OnStockTraded(ticker, latest);
            }
            catch(Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Exception occurred. Message: {exception.Message}");
                Console.ResetColor();
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            _timer?.Dispose();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Stock Market closing...");
            Console.ResetColor();
        }

        #endregion

        #endregion
    }
}
