using System;

namespace Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle();

            Hand hand = new Hand();
            for (int i = 0; i < 5; i++)
            {
                Card card = deck.Deal();
                hand.PickUp(card);
            }

            Console.WriteLine( hand );

            IHandEvaluatorChainFactory factory = new HandEvaluatorChainFactory();
            IHandEvaluator chain = factory.Create();

            Console.WriteLine( $"Hand evaluation of {hand} is {chain.Evaluate(hand)}");
        }
    }
}


