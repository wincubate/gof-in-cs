using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Wincubate.NullObjectExamples
{
    class AnimalFactory : IAnimalFactory
    {
        private readonly Dictionary<string, Type> _animalTypes;

        public AnimalFactory()
        {
            _animalTypes = new Dictionary<string, Type>();
            InitializeAnimalTypes();
        }

        public IAnimal Create( string description )
        {
            string processedDescription = description
                .Replace(" ", "")
                .Trim()
                .ToLower();
            if (_animalTypes.TryGetValue(processedDescription, out Type animalType))
            {
                return Activator.CreateInstance(animalType) as IAnimal;
            }

            return AnimalBase.Null;
        }

        private void InitializeAnimalTypes()
        {
            IEnumerable<Type> allAnimalTypes = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.GetInterface(nameof(IAnimal)) != null);

            foreach (Type t in allAnimalTypes)
            {
                _animalTypes.Add(t.Name.ToLower(), t);
            }
        }
    }
}