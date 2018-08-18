namespace Poker
{
    class FourOfAKindEvaluator : HandEvaluatorBase
    {
        public override HandEvaluation Evaluate( Hand hand )
        {
            if (HasAtLeastOfAKind(hand, 4))
            {
                return HandEvaluation.FourOfAKind;
            }
            else
            {
                return _next.Evaluate(hand);
            }
        }
    }
}

