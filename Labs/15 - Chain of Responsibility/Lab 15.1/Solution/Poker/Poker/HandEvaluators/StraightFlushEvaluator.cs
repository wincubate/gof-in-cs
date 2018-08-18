namespace Poker
{
    class StraightFlushEvaluator : HandEvaluatorBase
    {
        public override HandEvaluation Evaluate( Hand hand )
        {
            if (HasStraight(hand) && HasFlush(hand))
            {
                return HandEvaluation.StraightFlush;
            }
            else
            {
                return _next.Evaluate(hand);
            }
        }
    }
}
