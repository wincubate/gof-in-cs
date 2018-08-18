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

        public List<Card> Load()
        {
            string serialized = File.ReadAllText(_filePath);
            List<Card> cards = JsonConvert.DeserializeObject<List<Card>>(serialized);

            return cards;
        }

        public void Save( List<Card> cards )
        {
            string serialized = JsonConvert.SerializeObject(cards);
            File.WriteAllText(_filePath, serialized);
        }
    }
}
