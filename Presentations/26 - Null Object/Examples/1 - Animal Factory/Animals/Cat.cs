using System;

namespace Wincubate.NullObjectExamples
{
    class Cat : AnimalBase
    {
        public Cat() : base( "Kitty") { }

        override public void MakeSound()
        {
            Console.WriteLine( "Miiiaaauuuw" );
        }
    }
}
