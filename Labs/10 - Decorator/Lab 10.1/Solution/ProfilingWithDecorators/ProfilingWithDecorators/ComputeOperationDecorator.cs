using Library;

namespace ProfilingWithDecorators
{
    abstract class ComputeOperationDecorator : IComputeOperation
    {
        protected readonly IComputeOperation _decoratee;

        public ComputeOperationDecorator( IComputeOperation decoratee )
        {
            _decoratee = decoratee;
        }

        public virtual void Compute( int range ) => _decoratee.Compute(range);
    }
}
