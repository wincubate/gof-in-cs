using System.Collections.Generic;
using System.Text;

namespace Wincubate.FactoryMethodLabs
{
    abstract public class Pizza
    {
        public CrustKind Crust { get; protected set; }
        public bool HasSauce { get; protected set; }
        public IEnumerable<ToppingKind> Toppings { get; protected set; }
        public CheeseKind? Cheese { get; protected set; }
        public bool Oregano { get; protected set; }

        protected abstract void CreateContents(); // <-- The Factory Method

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Crust} pizza {(HasSauce ? "with" : "without")} sauce with ");
            sb.AppendLine($"{Cheese?.ToString().ToLower() ?? "no"} cheese. Toppings: ");

            foreach (ToppingKind topping in Toppings)
            {
                sb.AppendLine($"\t{topping}");
            }

            if (Oregano)
            {
                sb.AppendLine("with oregano on top");
            }

            return sb.ToString();
        }

        public Pizza()
        {
            CreateContents();
        }
    }
}