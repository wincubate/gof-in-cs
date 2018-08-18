using System;
using Wincubate.NullObjectExamples.Logging;

namespace Wincubate.NullObjectExamples
{
    class Program
    {
        static void Main( string[] args )
        {
            ILoggerFactory loggerFactory = new FileLoggerFactory();

            BankAccount from = new BankAccount();
            from.Deposit(176);
            Console.WriteLine(from.Balance);

            BankAccount to = new BankAccount();
            to.Deposit(87);

            Bank bank = new Bank(loggerFactory);
            bank.Transfer(from, 42, to);
        }
    }
}
