namespace Poker
{
    class HandEvaluatorChainFactory : IHandEvaluatorChainFactory
    {
        public IHandEvaluator Create()
        {
            IHandEvaluator chain = new RoyalFlushEvaluator();
            chain.AttachNext(new StraightFlushEvaluator())
                .AttachNext(new FourOfAKindEvaluator())
                .AttachNext(new FullHouseEvaluator())
                .AttachNext(new FlushEvaluator())
                .AttachNext(new StraightEvaluator())
                .AttachNext(new ThreeOfAKindEvaluator())
                .AttachNext(new TwoPairsEvaluator())
                .AttachNext(new PairEvaluator())
                .AttachNext(new HighCardEvaluator());

            return chain;
        }
    }
}
