using System.Linq;

namespace Poker
{
    abstract class HandEvaluatorBase : IHandEvaluator
    {
        protected IHandEvaluator _next;

        public IHandEvaluator AttachNext( IHandEvaluator next ) => _next = next;

        public abstract HandEvaluation Evaluate( Hand hand );

        #region Helpers

        protected bool HasAtLeastOfAKind( Hand hand, int number )
        {
            int maxOfAKind = hand
                .GroupBy(card => card.Rank)
                .Select( group => group.Count() )
                .Max();

            return maxOfAKind >= number;
        }

        protected bool HasStraight(Hand hand) =>
            hand.Select(c => c.Rank).Distinct().Count() == 5 &&
            hand.Last().Rank - hand.First().Rank == 4;

        protected bool HasFlush( Hand hand ) =>
            hand.GroupBy(card => card.Suit)
                .Count()
                == 1;

        #endregion
    }
}
