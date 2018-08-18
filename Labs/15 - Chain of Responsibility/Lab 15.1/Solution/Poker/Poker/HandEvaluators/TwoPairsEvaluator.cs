using System.Linq;

namespace Poker
{
    class TwoPairsEvaluator : HandEvaluatorBase
    {
        public override HandEvaluation Evaluate( Hand hand )
        {
            if (hand.GroupBy(card => card.Rank)
                    .Where( group => group.Count() >= 2 )
                    .Count()
                    >= 2)
            {
                return HandEvaluation.TwoPairs;
            }
            else
            {
                return _next.Evaluate(hand);
            }
        }
    }
}

