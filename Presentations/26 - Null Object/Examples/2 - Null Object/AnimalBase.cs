namespace Wincubate.NullObjectExamples
{
    abstract class AnimalBase : IAnimal
    {
        public static IAnimal Null
        {
            get => _null;
        }
        private readonly static IAnimal _null = new NullAnimal();

        public string Name { get; }

        public AnimalBase( string name )
        {
            Name = name;
        }

        abstract public void MakeSound();
    }
}
