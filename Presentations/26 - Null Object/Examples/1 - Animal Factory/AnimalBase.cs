namespace Wincubate.NullObjectExamples
{
    abstract class AnimalBase : IAnimal
    {
        public string Name { get; }

        public AnimalBase( string name )
        {
            Name = name;
        }

        abstract public void MakeSound();
    }
}
