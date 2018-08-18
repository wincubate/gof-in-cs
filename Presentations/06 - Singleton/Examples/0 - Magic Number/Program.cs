using System;

namespace Wincubate.SingletonExamples
{
    class Program
    {
        static void Main( string[] args )
        {
            Magic m1 = new Magic();
            Console.WriteLine(m1.Number);

            Magic m2 = new Magic();
            Console.WriteLine(m2.Number);
        }
    }
}
