using System;
using System.Collections;

namespace Wincubate.IteratorExamples
{
    class Program
    {
        static void Main( string[] args )
        {
            int[] numbers = { 42, 47, 112, 176, 209 };

            IEnumerator enumerator = numbers.GetEnumerator();
            enumerator.Reset();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
