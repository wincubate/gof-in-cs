namespace Wincubate.NullObjectExamples
{
    class NullAnimal : AnimalBase
    {
        public NullAnimal() : base( string.Empty ) { }

        public override void MakeSound() { }
    }
}
