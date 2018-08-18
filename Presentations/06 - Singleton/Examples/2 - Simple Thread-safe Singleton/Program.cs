using System;

namespace Wincubate.SingletonExamples
{
    class Program
    {
        static void Main( string[] args )
        {
            Magic m1 = Magic.Instance;
            Console.WriteLine(m1.Number);

            Magic m2 = Magic.Instance;
            Console.WriteLine(m2.Number);
        }
    }
}
