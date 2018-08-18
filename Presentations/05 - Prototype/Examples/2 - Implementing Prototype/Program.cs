using System;

namespace Wincubate.PrototypeExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.SwapCards(10, 20);
            deck.TakeCard();
            deck.SwapCards(0, 30);
            deck.SwapCards(1, 29);
            deck.TakeCard();
            deck.SwapCards(0, 30);
            deck.SwapCards(1, 42);
            deck.TakeCard();
            deck.SwapCards(42, 17);
            deck.Shuffle();
            deck.SwapCards(19, 29);
            deck.TakeCard();

            Deck copy = deck.Clone() as Deck;

            Console.WriteLine( deck );
            Console.WriteLine( copy );
            
        }
    }
}
