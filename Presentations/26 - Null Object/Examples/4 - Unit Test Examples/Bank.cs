using System;
using Wincubate.NullObjectExamples.Logging;

namespace Wincubate.NullObjectExamples
{
    public class Bank
    {
        private readonly ILoggerFactory _loggerFactory;

        public Bank( ILoggerFactory loggerFactory )
        {
            _loggerFactory = loggerFactory;
        }

        public void Transfer( BankAccount from, decimal amount, BankAccount to )
        {
            ILogger logger = _loggerFactory.Create(nameof(Bank));
            logger.Enter();

            try
            {
                from.Withdraw(amount);
                to.Deposit(amount);

                logger.Info($"Successfully transferred {amount}");
            }
            catch (Exception exception)
            {
                logger.Error(exception);
            }

            logger.Exit();
        }
    }
}