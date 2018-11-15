using System.Collections.Generic;

namespace Wincubate.FactoryMethodLabs
{
    public class PepperoniPizza : Pizza
    {
        protected override void CreateContents()
        {
            Crust = CrustKind.Pan;
            HasSauce = true;
            Cheese = CheeseKind.Extra;
            Toppings = new List<ToppingKind>
            {
                ToppingKind.Pepperoni,
                ToppingKind.Pineapple,
                ToppingKind.Jalapenos,
                ToppingKind.Mushrooms
            };
            Oregano = true;
        }
    }
}
