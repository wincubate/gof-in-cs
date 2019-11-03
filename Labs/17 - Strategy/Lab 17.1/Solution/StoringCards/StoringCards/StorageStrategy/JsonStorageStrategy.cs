using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace StoringCards
{
    class JsonStorageStrategy : IStorageStrategy
    {
        private readonly string _filePath;

        public JsonStorageStrategy( string filePath = @"deck.json" )
        {
            _filePath = filePath;
        }

        public IEnumerable<Card> Load()
        {
            string serialized = File.ReadAllText(_filePath);
            IEnumerable<Card> cards = JsonConvert.DeserializeObject<IEnumerable<Card>>(serialized);

            return cards;
        }

        public void Save( IEnumerable<Card> cards )
        {
            string serialized = JsonConvert.SerializeObject(cards);
            File.WriteAllText(_filePath, serialized);
        }
    }
}
