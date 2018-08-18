using System;

namespace Wincubate.NullObjectExamples
{
    public class BankAccount
    {
        public decimal Balance { get; private set; }

        public void Deposit( decimal amount )
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            Balance += amount;
        }

        public void Withdraw( decimal amount )
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Insufficient funds in account");
            }

            Balance -= amount;
        }
    }
}
