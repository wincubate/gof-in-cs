using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Wincubate.FactoryMethodLabs
{
    class ReflectionPizzaFactory : IPizzaFactory
    {
        private readonly Dictionary<string, Type> _pizzaTypes;

        public ReflectionPizzaFactory()
        {
            _pizzaTypes = new Dictionary<string, Type>();
            InitializePizzaTypes();
        }

        public IPizza Create( string description )
        {
            string processedDescription = description
                .Replace(" ", "")
                .Trim()
                .ToLower();
            if ( _pizzaTypes.TryGetValue(processedDescription, out Type pizzaType ) )
            {
                return Activator.CreateInstance(pizzaType) as IPizza;
            }

            return null;
        }

        private void InitializePizzaTypes()
        {
            IEnumerable<Type> allPizzaTypes = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.GetInterface(nameof(IPizza)) != null);

            foreach (Type t in allPizzaTypes)
            {
                _pizzaTypes.Add(t.Name.ToLower(), t);
            }
        }
    }
}