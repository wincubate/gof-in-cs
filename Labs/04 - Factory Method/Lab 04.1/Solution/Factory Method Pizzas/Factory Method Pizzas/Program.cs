using System;

namespace Wincubate.FactoryMethodLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza hawaii = new HawaiiPizza();
            Console.WriteLine(hawaii);

            Pizza pepperoni = new PepperoniPizza();
            Console.WriteLine(pepperoni);
        }
    }
}
