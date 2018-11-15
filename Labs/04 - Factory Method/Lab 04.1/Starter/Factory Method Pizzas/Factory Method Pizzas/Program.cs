using System;
using System.Collections.Generic;

namespace Wincubate.FactoryMethodLabs
{
    class Program
    {
        static void Main(string[] args)
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

            Pizza pepperoni = new Pizza
            {
                Crust = CrustKind.Pan,
                HasSauce = true,
                Cheese = CheeseKind.Extra,
                Toppings = new List<ToppingKind>
                {
                    ToppingKind.Pepperoni,
                    ToppingKind.Pineapple,
                    ToppingKind.Jalapenos,
                    ToppingKind.Mushrooms
                },
                Oregano = true
            };

            Console.WriteLine(pepperoni);

        }
    }
}
