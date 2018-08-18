using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrewingCoffee.Test
{
    [TestClass]
    public class CoffeeTest
    {
        private ICoffeeFactory _factory;

        [TestInitialize]
        public void TestInitialize()
        {
            _factory = new CoffeeFactory();
        }

        [TestMethod]
        public void Test_Equals_Ok()
        {
            ICoffee c1 = _factory.CreateCoffee("Espresso");
            ICoffee c2 = _factory.CreateCoffee("Espresso");

            Assert.IsTrue(c1.Equals(c2));
        }

        [TestMethod]
        public void Test_Equals_NotOk()
        {
            ICoffee c1 = _factory.CreateCoffee("Espresso");
            ICoffee c2 = _factory.CreateCoffee("Cappuccino");

            Assert.IsFalse(c1.Equals(c2));
        }

        [TestMethod]
        public void Test_OperatorEquality_Ok()
        {
            ICoffee c1 = _factory.CreateCoffee("Espresso");
            ICoffee c2 = _factory.CreateCoffee("Espresso");

            Assert.IsTrue(c1 == c2);
        }

        [TestMethod]
        public void Test_OperatorEquality_NotOk()
        {
            ICoffee c1 = _factory.CreateCoffee("Espresso");
            ICoffee c2 = _factory.CreateCoffee("Cappuccino");

            Assert.IsFalse(c1 == c2);
        }

        [TestMethod]
        public void Test_OperatorInequality_Ok()
        {
            ICoffee c1 = _factory.CreateCoffee("Espresso");
            ICoffee c2 = _factory.CreateCoffee("Cappuccino");

            Assert.IsTrue(c1 != c2);
        }

        [TestMethod]
        public void Test_OperatorInequality_NotOk()
        {
            ICoffee c1 = _factory.CreateCoffee("Espresso");
            ICoffee c2 = _factory.CreateCoffee("Espresso");

            Assert.IsFalse(c1 != c2);
        }

        [TestMethod]
        public void Test_GetHashCode_Ok()
        {
            ICoffee c1 = _factory.CreateCoffee("Espresso");
            ICoffee c2 = _factory.CreateCoffee("Espresso");

            Assert.AreEqual(c1.GetHashCode(), c2.GetHashCode());
        }

        [TestMethod]
        public void Test_GetHashCode_NotOk()
        {
            ICoffee c1 = _factory.CreateCoffee("Espresso");
            ICoffee c2 = _factory.CreateCoffee("Cappuccino");

            Assert.AreNotEqual(c1.GetHashCode(), c2.GetHashCode());
        }
    }
}
