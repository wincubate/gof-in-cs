namespace Wincubate.NullObjectExamples
{
    abstract class AnimalBase : IAnimal
    {
        public static IAnimal Null
        {
            get => _null;
        }

        #region Null Object

        private readonly static IAnimal _null = new NullAnimal();

        private class NullAnimal : AnimalBase
        {
            public NullAnimal() : base(string.Empty) { }

            public override void MakeSound() { }
        }

        #endregion

        public string Name { get; }

        public AnimalBase( string name )
        {
            Name = name;
        }

        abstract public void MakeSound();
    }
}
