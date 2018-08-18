using System;
using System.Collections.Generic;

namespace Wincubate.BuilderExamples
{
    class Program
    {
        static void Main( string[] args )
        {
            Pizza hawaii = new Pizza
            {
                Crust = CrustKind.Classic,
                HasSauce = true,
                Cheese = CheeseKind.Regular,
                Toppings = new List<ToppingKind>
                {
                    ToppingKind.Ham,
                    ToppingKind.Pineapple
                },
                Oregano = true
            };

            Console.WriteLine(hawaii);
        }
    }
}
