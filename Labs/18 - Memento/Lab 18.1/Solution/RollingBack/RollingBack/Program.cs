using System;

namespace RollingBack
{
    class Program
    {
        static void Main( string[] args )
        {
            Deck deck = new Deck();

            // Save initial deck
            Console.WriteLine("Saving...");
            IMemento memento = deck.Memento;

            // Shuffle deck and print
            deck.Shuffle();
            foreach (Card card in deck)
            {
                Console.Write($"{card} ");
            }
            Console.WriteLine();

            // Restore initial deck and print
            Console.WriteLine("Restoring...");
            deck.Memento = memento;
            foreach (Card card in deck)
            {
                Console.Write($"{card} ");
            }
            Console.WriteLine();
        }
    }
}


