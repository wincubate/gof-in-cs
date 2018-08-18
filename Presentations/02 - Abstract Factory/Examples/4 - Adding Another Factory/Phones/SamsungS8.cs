using System;

namespace Wincubate.AbstractFactoryExamples
{
    enum S8Kind
    {
        Regular,
        Plus
    }

    class SamsungS8 : IMobilePhone
    {
        public S8Kind Kind { get; }

        public SamsungS8( S8Kind kind )
        {
            Kind = kind;
        }

        public void Call( string who )
        {
            Console.WriteLine($"Calling {who} from an Samsung S8{(Kind == S8Kind.Plus ? "+" : "")}");
        }
    }
}
