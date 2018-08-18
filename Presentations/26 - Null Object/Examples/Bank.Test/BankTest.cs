using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Wincubate.NullObjectExamples.Logging;
using Wincubate.NullObjectExamples.Test.Logging;

namespace Wincubate.NullObjectExamples.Test
{
    [TestClass]
    public class BankTest
    {
        private ILoggerFactory _loggerFactory;

        [TestInitialize]
        public void TestInitialize()
        {
            _loggerFactory = new FileLoggerFactory();
            //_loggerFactory = new NullLoggerFactory();
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [TestMethod]
        public void TestTransfer_EnoughMoney()
        {
            BankAccount from = new BankAccount();
            from.Deposit(176);

            BankAccount to = new BankAccount();
            to.Deposit(87);

            Bank bank = new Bank(_loggerFactory);
            bank.Transfer(from, 42, to);

            decimal fromExpectedBalance = 134;
            Assert.AreEqual(fromExpectedBalance, from.Balance);

            decimal toExpectedBalance = 129;
            Assert.AreEqual(toExpectedBalance, to.Balance);
        }
    }
}