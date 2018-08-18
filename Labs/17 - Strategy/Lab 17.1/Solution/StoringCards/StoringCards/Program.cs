using System;

namespace StoringCards
{
    class Program
    {
        static void Main( string[] args )
        {
            Deck deck = new Deck(new JsonStorageStrategy());
            //Deck deck = new Deck(new BinaryStorageStrategy());

            //deck.Load();
            deck.Shuffle();

            foreach (Card card in deck)
            {
                Console.Write($"{card} ");
            }

            deck.Save();

            Console.WriteLine();

        }
    }
}


