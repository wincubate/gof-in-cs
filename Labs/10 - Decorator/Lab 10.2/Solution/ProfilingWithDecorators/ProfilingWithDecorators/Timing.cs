using Library;
using System;
using System.Diagnostics;

namespace ProfilingWithDecorators
{
    class Timing : ComputeOperationDecorator
    {
        private readonly Stopwatch _stopwatch;

        public Timing( IComputeOperation decoratee ) : base(decoratee)
        {
            _stopwatch = new Stopwatch();
        }

        public override void Compute( int range )
        {
            _stopwatch.Start();
            base.Compute(range);
            _stopwatch.Stop();

            Console.WriteLine( $"Execution time was {_stopwatch.Elapsed}");
        }
    }
}
