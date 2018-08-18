namespace Poker
{
    class RoyalFlushEvaluator : HandEvaluatorBase
    {
        public override HandEvaluation Evaluate( Hand hand )
        {
            if (HasStraight(hand) && HasFlush(hand) && hand.HighestCardRank == Rank.Ace )
            {
                return HandEvaluation.RoyalFlush;
            }
            else
            {
                return _next.Evaluate(hand);
            }
        }
    }
}
