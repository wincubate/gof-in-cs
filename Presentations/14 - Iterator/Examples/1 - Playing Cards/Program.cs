using System;

namespace Wincubate.IteratorExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle();
            Card card = deck.Deal();
            Console.WriteLine( card );
        }
    }
}
