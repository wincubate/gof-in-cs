namespace Poker
{
    class HighCardEvaluator : HandEvaluatorBase
    {
        public override HandEvaluation Evaluate( Hand hand ) => HandEvaluation.HighCard;
    }
}
