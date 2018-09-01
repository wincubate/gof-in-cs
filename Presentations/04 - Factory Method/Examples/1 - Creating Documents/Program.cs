using System;

namespace Wincubate.FactoryMethodExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Publication fiction = new Publication("Harry Porter goes Beer-binging")
            {
                new Chapter( 1 ),
                new Chapter( 2 ),
                new Chapter( 3 )
            };
            fiction.Print();

            Console.WriteLine();

            Publication technicalBook = new Publication("Gang of Four Design Patterns in C#")
            {
                new Foreword(),
                new Chapter( 1 ),
                new Chapter( 2 ),
                new Chapter( 3 ),
                new Index()
            };
            technicalBook.Print();

            Console.WriteLine();

            Publication tabloid = new Publication("Krazy W00rld")
            {
                new FakeNews(),
                new Gossip(),
                new Gossip(),
                new FakeNews()
            };
            tabloid.Print();
        }
    }
}