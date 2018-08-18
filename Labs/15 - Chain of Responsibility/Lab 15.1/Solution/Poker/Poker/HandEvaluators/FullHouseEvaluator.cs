using System.Linq;

namespace Poker
{
    class FullHouseEvaluator : HandEvaluatorBase
    {
        public override HandEvaluation Evaluate( Hand hand )
        {
            if( hand.GroupBy( card => card.Rank ).Count() == 2 &&
                hand.First().Rank != hand.Last().Rank )
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
