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
        private List<Card> _cards;

        public Deck()
        {
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

        public void Load( StorageFormat format )
        {
            switch (format)
            {
                case StorageFormat.Json:
                    string serialized = File.ReadAllText(@"deck.json");
                    _cards = JsonConvert.DeserializeObject<List<Card>>(serialized);
                    break;
                case StorageFormat.Binary:
                    using (FileStream input = File.OpenRead(@"deck.bin"))
                    {
                        byte[] bytes = new byte[2 * 52];
                        int read = input.Read(bytes, 0, bytes.Length);

                        List<Card> loaded = new List<Card>();

                        int i = 0;
                        while (i+1 < read)
                        {
                            loaded.Add(new Card((Suit)bytes[i], (Rank)bytes[i + 1]));
                            i += 2;
                        }

                        _cards = loaded;
                    }
                    break;
                default:
                    throw new NotSupportedException($"Storage format {format} not supported");
            }
        }

        public void Save( StorageFormat format )
        {
            switch (format)
            {
                case StorageFormat.Json:
                    string serialized = JsonConvert.SerializeObject(_cards);
                    File.WriteAllText(@"deck.json", serialized);
                    break;
                case StorageFormat.Binary:
                    using (FileStream output = File.Create(@"deck.bin"))
                    {
                        byte[] bytes = _cards
                            .SelectMany(c => new byte[2] { (byte)c.Suit, (byte)c.Rank })
                            .ToArray();

                        output.Write(bytes, 0, bytes.Length);
                    }
                    break;
                default:
                    throw new NotSupportedException($"Storage format {format} not supported");
            }
        }

        #endregion
    }
}
