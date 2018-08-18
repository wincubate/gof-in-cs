namespace Poker
{
    interface IHandEvaluator
    {
        IHandEvaluator AttachNext( IHandEvaluator next );
        HandEvaluation Evaluate( Hand hand );
    }
}
