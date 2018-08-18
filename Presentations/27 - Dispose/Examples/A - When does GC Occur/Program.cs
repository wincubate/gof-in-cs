using System;

namespace Wincubate.DisposeExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Press ENTER to generate objects");
                Console.ReadLine();

                for (int i = 0; i < 10000; i++)
                {
                    A a = new A();
                }

                Console.WriteLine("There are currently {0} instances of A", A.InstanceCount);
            }
        }
    }
}
