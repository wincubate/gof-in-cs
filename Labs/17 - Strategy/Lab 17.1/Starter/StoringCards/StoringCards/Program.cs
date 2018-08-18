using System;

namespace StoringCards
{
    class Program
    {
        static void Main( string[] args )
        {
            Deck deck = new Deck();
            //deck.Load(StorageFormat.Json);
            //deck.Load(StorageFormat.Binary);

            foreach (Card card in deck)
            {
                Console.Write($"{card} ");
            }

            //deck.Save(StorageFormat.Json);
            //deck.Save(StorageFormat.Binary);
            Console.WriteLine();

        }
    }
}


