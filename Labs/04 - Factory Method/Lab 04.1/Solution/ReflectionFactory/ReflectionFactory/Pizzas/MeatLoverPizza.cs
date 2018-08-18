using System.Collections.Generic;

namespace Wincubate.FactoryMethodLabs
{
    class MeatLoverPizza : Pizza
    {
        public MeatLoverPizza()
        {
            Crust = CrustKind.Classic;
            HasSauce = true;
            Toppings = new List<ToppingKind>
            {
                ToppingKind.Bacon,
                ToppingKind.Pepperoni,
                ToppingKind.Sausage
            };
            Cheese = CheeseKind.Extra;
            Oregano = true;
        }
    }
}
