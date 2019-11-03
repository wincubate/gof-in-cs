using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StoringCards
{
    class Deck : IEnumerable<Card>
    {
        private readonly IStorageStrategy _storageStrategy;
        private List<Card> _cards;

        public Deck( IStorageStrategy storageStrategy )
        {
            _storageStrategy = storageStrategy;
            _cards = new List<Card>();

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    _cards.Add(new Card(suit, rank));
                }
            }
        }

        public Card Deal()
        {
            if (_cards.Any())
            {
                Card top = _cards[0];
                _cards.RemoveAt(0);
                return top;
            }

            throw new InvalidOperationException("No more cards left to deal");
        }

        public void Shuffle()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < _cards.Count; i++)
            {
                int j = random.Next(_cards.Count);
                Card temp = _cards[i];
                _cards[i] = _cards[j];
                _cards[j] = temp;
            }
        }

        public void Arrange()
        {
            _cards.Sort();
        }

        #region IEnumerable<Card> Members

        public IEnumerator<Card> GetEnumerator()
        {
            foreach (Card card in _cards)
            {
                yield return card;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        #endregion

        #region Load and Save

        public void Load() => _cards = _storageStrategy
            .Load()
            .ToList()
            ;

        public void Save() => _storageStrategy
            .Save(_cards)
            ;

        #endregion
    }
}
