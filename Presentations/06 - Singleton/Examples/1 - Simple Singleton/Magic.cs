using System;
using System.Threading;

namespace Wincubate.SingletonExamples
{
    sealed class Magic // <-- Note: sealed
    {
        public int Number { get; }

        public static Magic Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Magic();
                }
                return _instance;
            }
        }
        private static Magic _instance;

        private Magic() // <-- Note: private
        {
            int[] numbers = { 42, 87, 112, 176, 1880 };

            Thread.Sleep(20); // <-- emulates that number is resource-intensive to create

            Random random = new Random(DateTime.Now.Millisecond);
            Number = numbers[random.Next(numbers.Length)];
        }
    }
}
