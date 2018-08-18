using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    /// <summary>
    /// Poker hand of at most 5 cards.
    /// </summary>
    /// <remarks>
    /// Uses the representation invariant that the cards are always sorted by rank.
    /// </remarks>
    class Hand : IEnumerable<Card>
    {
        private readonly List<Card> _cards;

        #region IEnumerable<Card> Members

        public IEnumerator<Card> GetEnumerator() => _cards.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        #endregion

        public Card this[int index]
        {
            get
            {
                if (0 <= index && index < _cards.Count)
                {
                    return _cards[index];
                }

                throw new IndexOutOfRangeException(
                   string.Format("Card instances from Hand can only be retrieved by integer indices between {0} and {1}",
                      0,
                      _cards.Count - 1)
                );
            }
        }

        public override string ToString() => $"/{string.Join(" ", _cards)}/";


        public Rank HighestCardRank
        {
            get
            {
                if (_cards.Any())
                {
                    return _cards.Last().Rank;
                }
                else
                {
                    throw new InvalidOperationException("No card in hand");
                }
            }
        }

        public Hand()
        {
            _cards = new List<Card>();
        }

        public void PickUp( Card card )
        {
            if (_cards.Count < 5)
            {
                _cards.Add(card);
                _cards.Sort();
            }
            else
            {
                throw new InvalidOperationException($"Hand limit of 5 cards reached");
            }
        }
    }
}
