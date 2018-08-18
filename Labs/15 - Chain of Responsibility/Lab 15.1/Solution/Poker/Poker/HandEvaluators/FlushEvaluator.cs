using System.Linq;

namespace Poker
{
    class FlushEvaluator : HandEvaluatorBase
    {
        public override HandEvaluation Evaluate( Hand hand )
        {
            if (HasFlush(hand))
            {
                return HandEvaluation.Flush;
            }
            else
            {
                return _next.Evaluate(hand);
            }
        }
    }
}
