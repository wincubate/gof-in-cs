namespace Poker
{
    class HandEvaluatorChainFactory : IHandEvaluatorChainFactory
    {
        public IHandEvaluator Create()
        {
            IHandEvaluator chain = new RoyalFlushEvaluator();

            // TODO: Construct the rest of the chain of responsibility using the many
            // IHandEvaluator instances and return it

            return chain;
        }
    }
}
