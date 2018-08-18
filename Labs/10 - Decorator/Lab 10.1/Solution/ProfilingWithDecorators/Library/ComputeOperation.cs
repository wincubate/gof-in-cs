using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Library
{
    public sealed class ComputeOperation : IComputeOperation
    {
        private readonly Random _random;

        public ComputeOperation()
        {
            _random = new Random(DateTime.Now.Millisecond);
        }

        public void Compute( int range )
        {
            IEnumerable<int> query = Enumerable
                .Range(0, range)
                .Where(IsEven);

            foreach (int i in query)
            {
                Console.WriteLine( i );
            }
        }

        private bool IsEven( int i )
        {
            Thread.Sleep(_random.Next(0, 100));

            return i % 2 == 0;
        }
    }
}