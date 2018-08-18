namespace Wincubate.NullObjectExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimalFactory factory = new AnimalFactory();
            IAnimal animal = factory.Create("fish");
            animal.MakeSound();
        }
    }
}
