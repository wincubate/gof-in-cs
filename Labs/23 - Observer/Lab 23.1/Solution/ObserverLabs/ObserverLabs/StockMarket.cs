using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Wincubate.ObserverLabs
{
    sealed class StockMarket : IObservable<StockTradedInfo>, IDisposable
    {
        #region IObservable<StockTradeInfo> Members

        public IDisposable Subscribe( IObserver<StockTradedInfo> observer )
        {
            _observers.Add(observer);

            return new SubscriptionCookie(() => _observers.Remove(observer));
        }

        #endregion

        #region SubscriptionCookie Class

        private class SubscriptionCookie : IDisposable
        {
            #region IDisposable Members

            void IDisposable.Dispose() => _unsubscribeAction?.Invoke();

            #endregion

            private readonly Action _unsubscribeAction;

            public SubscriptionCookie( Action unsubscribeAction )
            {
                _unsubscribeAction = unsubscribeAction;
            }
        }

        #endregion

        private readonly IList<IObserver<StockTradedInfo>> _observers;

        public StockMarket()
        {
            _observers = new List<IObserver<StockTradedInfo>>();

            Initialize();
        }

        private void OnStockTraded( string ticker, decimal latest )
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"{ticker} traded at USD {latest:f2}");
            Console.ResetColor();

            StockTradedInfo value = new StockTradedInfo(ticker, latest);
            NotifyObservers(observer => observer.OnNext(value));
        }

        private void NotifyObservers( Action<IObserver<StockTradedInfo>> notifyAction )
        {
            // If this was not an exercise you would consider thread-safety here ;-)
            foreach (IObserver<StockTradedInfo> observer in _observers)
            {
                try
                {
                    notifyAction(observer);
                }
                catch
                {
                    // Don't let any observer's error(s) crash the observable
                }
            }
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
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Exception occurred. Message: {exception.Message}");
                Console.ResetColor();

                NotifyObservers(observer => observer.OnError(exception));
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            _timer?.Dispose();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Stock Market closing...");
            Console.ResetColor();

            NotifyObservers(observer => observer.OnCompleted());
        }

        #endregion

        #endregion
    }
}