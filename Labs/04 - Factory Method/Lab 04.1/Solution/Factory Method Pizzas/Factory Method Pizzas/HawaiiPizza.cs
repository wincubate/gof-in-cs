using System.Collections.Generic;

namespace Wincubate.FactoryMethodLabs
{
    public class HawaiiPizza : Pizza
    {
        protected override void CreateContents()
        {
            Crust = CrustKind.Classic;
            HasSauce = true;
            Cheese = CheeseKind.Regular;
            Toppings = new List<ToppingKind>
            {
                ToppingKind.Ham,
                ToppingKind.Pineapple
            };
            Oregano = true;
        }
    }
}
