using System;

namespace Wincubate.NullObjectExamples
{
    class Lion : AnimalBase
    {
        public Lion() : base("Simba") { }

        override public void MakeSound()
        {
            Console.WriteLine( "Rooooooaarrrrrrrrrr..!" );
        }
    }
}
