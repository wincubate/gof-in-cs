namespace Poker
{
    class ThreeOfAKindEvaluator : HandEvaluatorBase
    {
        public override HandEvaluation Evaluate( Hand hand )
        {
            if (HasAtLeastOfAKind(hand, 3))
            {
                return HandEvaluation.ThreeOfAKind;
            }
            else
            {
                return _next.Evaluate(hand);
            }
        }
    }
}

