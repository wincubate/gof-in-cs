using System;
using System.Threading;

namespace Wincubate.SingletonExamples
{
    sealed class Magic
    {
        public int Number { get; }

        private Magic()
        {
            int[] numbers = { 42, 87, 112, 176, 1880 };

            Thread.Sleep(20); // <-- emulates that number is resource-intensive to create

            Random random = new Random(DateTime.Now.Millisecond);
            Number = numbers[random.Next(numbers.Length)];
        }

        public static Magic Instance => _lazyInstance.Value;

        private static readonly Lazy<Magic> _lazyInstance = new Lazy<Magic>(() => new Magic());
    }
}
