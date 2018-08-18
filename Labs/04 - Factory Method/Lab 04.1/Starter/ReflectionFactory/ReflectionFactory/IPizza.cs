using System.Collections.Generic;

namespace Wincubate.FactoryMethodLabs
{
    interface IPizza
    {
        CrustKind Crust { get; }
        bool HasSauce { get; }
        IEnumerable<ToppingKind> Toppings { get; }
        CheeseKind? Cheese { get; }
        bool Oregano { get; }
    }
}
