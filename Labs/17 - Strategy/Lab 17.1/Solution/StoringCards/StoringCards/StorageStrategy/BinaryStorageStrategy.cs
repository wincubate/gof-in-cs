using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StoringCards
{
    class BinaryStorageStrategy : IStorageStrategy
    {
        private readonly string _filePath;

        public BinaryStorageStrategy( string filePath = @"deck.bin" )
        {
            _filePath = filePath;
        }

        public IEnumerable<Card> Load()
        {
            using (FileStream input = File.OpenRead(_filePath))
            {
                byte[] bytes = new byte[2 * 52];
                int read = input.Read(bytes, 0, bytes.Length);

                IList<Card> loaded = new List<Card>();

                int i = 0;
                while (i + 1 < read)
                {
                    loaded.Add(new Card((Suit)bytes[i], (Rank)bytes[i + 1]));
                    i += 2;
                }

                return loaded;
            }
        }

        public void Save( IEnumerable<Card> cards )
        {
            using (FileStream output = File.Create(_filePath))
            {
                byte[] bytes = cards
                    .SelectMany(c => new byte[2] { (byte)c.Suit, (byte)c.Rank })
                    .ToArray();

                output.Write(bytes, 0, bytes.Length);
            }
        }
    }
}
