using System;

namespace RollingBack
{
    class Program
    {
        static void Main( string[] args )
        {
            Deck deck = new Deck();
            deck.Shuffle();

            foreach (Card card in deck)
            {
                Console.Write($"{card} ");
            }

            Console.WriteLine();
        }
    }
}


