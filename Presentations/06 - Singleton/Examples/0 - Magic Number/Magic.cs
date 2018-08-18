using System;
using System.Threading;

namespace Wincubate.SingletonExamples
{
    class Magic
    {
        public int Number { get; }

        public Magic()
        {
            int[] numbers = { 42, 87, 112, 176, 1880 };

            Thread.Sleep(20); // <-- emulates that number is resource-intensive to create

            Random random = new Random(DateTime.Now.Millisecond);
            Number = numbers[random.Next(numbers.Length)];
        }
    }
}
