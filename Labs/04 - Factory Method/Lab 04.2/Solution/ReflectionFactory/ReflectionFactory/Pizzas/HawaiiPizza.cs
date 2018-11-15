using System.Collections.Generic;

namespace Wincubate.FactoryMethodLabs
{
    class HawaiiPizza : Pizza
    {
        public HawaiiPizza()
        {
            Crust = CrustKind.Classic;
            HasSauce = true;
            Toppings = new List<ToppingKind>
            {
                ToppingKind.Ham,
                ToppingKind.Pineapple
            };
            Cheese = CheeseKind.Regular;
            Oregano = true;
        }
    }
}
