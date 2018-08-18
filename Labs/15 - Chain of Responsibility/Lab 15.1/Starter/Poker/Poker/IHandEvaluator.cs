namespace Poker
{
    interface IHandEvaluator
    {
        IHandEvaluator AttachNext( IHandEvaluator next );

        // TODO: Add method signature corresponding to a single
        // hand evaluation being computed.
    }
}
