using System;

namespace Wincubate.NullObjectExamples
{
    class Dog : AnimalBase
    {
        public Dog() : base("Fido") { }

        override public void MakeSound()
        {
            Console.WriteLine("Woof");
        }
    }
}
