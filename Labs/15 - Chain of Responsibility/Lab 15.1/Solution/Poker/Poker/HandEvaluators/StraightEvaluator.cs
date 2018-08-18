using System.Linq;

namespace Poker
{
    class StraightEvaluator : HandEvaluatorBase
    {
        public override HandEvaluation Evaluate( Hand hand )
        {
            if (HasStraight( hand ))
            {
                return HandEvaluation.Straight;
            }
            else
            {
                return _next.Evaluate(hand);
            }
        }
    }
}
