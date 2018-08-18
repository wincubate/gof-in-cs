namespace Poker
{
    class PairEvaluator : HandEvaluatorBase
    {
        public override HandEvaluation Evaluate( Hand hand )
        {
            if (HasAtLeastOfAKind( hand, 2 ) )
            {
                return HandEvaluation.Pair;
            }
            else
            {
                return _next.Evaluate(hand);
            }
        }
    }
}

