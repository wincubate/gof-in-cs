using System.Collections.Generic;

namespace Wincubate.FactoryMethodLabs
{
    class ElDiabloPizza : Pizza
    {
        public ElDiabloPizza()
        {
            Crust = CrustKind.Classic;
            HasSauce = true;
            Toppings = new List<ToppingKind>
            {
                ToppingKind.Mushrooms,
                ToppingKind.Jalapenos,
                ToppingKind.Tomatoes,
                ToppingKind.Onions,
                ToppingKind.Sausage,
                ToppingKind.BlackOlives,
            };
            Cheese = CheeseKind.Regular;
            Oregano = true;
        }
    }
}
