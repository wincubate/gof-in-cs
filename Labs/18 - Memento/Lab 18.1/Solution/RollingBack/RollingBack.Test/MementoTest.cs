using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace RollingBack.Test
{
    [TestClass]
    public class MementoTest
    {
        [TestMethod]
        public void Test_Memento_Ok()
        {
            Deck deck = new Deck();

            // Create State 1
            deck.Shuffle();

            // Save State 1
            IMemento memento = deck.Memento;
            IEnumerable<Card> expected = deck.ToList();

            // Create State 2
            deck.Shuffle();

            // Restore State 1 (discarding State 2)
            deck.Memento = memento;
            IEnumerable<Card> actual = deck.ToList();

            Assert.IsTrue(expected.SequenceEqual(actual));
        }
    }
}
