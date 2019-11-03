using System.Linq;

namespace Poker
{
    class FullHouseEvaluator : HandEvaluatorBase
    {
        public override HandEvaluation Evaluate( Hand hand )
        {
            var rankGroups = hand
                .GroupBy(card => card.Rank)
                ;
            if ( rankGroups.Count() == 2 &&
                 rankGroups.All( g => g.Count() >= 2 )
            )
            {
                return HandEvaluation.FullHouse;
            }
            else
            {
                return _next.Evaluate(hand);
            }
        }
    }
}
