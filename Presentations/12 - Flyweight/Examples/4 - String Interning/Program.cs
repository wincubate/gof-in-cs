using System;

namespace Wincubate.FlyweightExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            string s2 = "Hello";
            //string s3 = string.Intern( Console.ReadLine() );

            Console.WriteLine(ReferenceEquals(s1, s2));
        }
    }
}
