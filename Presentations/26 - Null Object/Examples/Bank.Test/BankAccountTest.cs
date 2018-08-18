using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Wincubate.NullObjectExamples.Test
{
    [TestClass]
    public class BankAccountTest
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestWithdraw()
        {
            BankAccount account = new BankAccount();
            account.Withdraw(87);
        }

        [TestMethod]
        public void TestDeposit_Positive()
        {
            BankAccount account = new BankAccount();
            decimal expected = 87;
            account.Deposit(expected);
            decimal actual = account.Balance;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestDeposit_CannotDepositNegative()
        {
            BankAccount account = new BankAccount();
            decimal expected = -87;
            account.Deposit(expected);
        }

        [TestMethod]
        public void TestWithdraw_OK()
        {
            BankAccount account = new BankAccount();
            decimal expected1 = 87;
            account.Deposit(expected1);
            decimal expected2 = 42;
            account.Withdraw(expected2);
            decimal actual = account.Balance;

            Assert.AreEqual(expected1 - expected2, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestWithdraw_CannotWithdrawNegative()
        {
            BankAccount account = new BankAccount();
            decimal expected1 = 87;
            account.Deposit(expected1);
            decimal expected2 = -42;
            account.Withdraw(expected2);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestWithdraw_InsufficientBalance()
        {
            BankAccount account = new BankAccount();
            decimal expected1 = 42;
            account.Deposit(expected1);
            decimal expected2 = 87;
            account.Withdraw(expected2);
        }
    }
}