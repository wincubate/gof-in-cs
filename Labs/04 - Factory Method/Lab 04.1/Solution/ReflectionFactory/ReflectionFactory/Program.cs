using System;
using System.Collections.Generic;

namespace Wincubate.FactoryMethodLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizzaFactory factory = new ReflectionPizzaFactory();

            List<string> pizzasToCreate = new List<string>
            {
                "margherita pizza",
                "meat lover pizza",
                "El Diablo pizza",
                "Hawaii Pizza"
            };

            foreach (string description in pizzasToCreate)
            {
                IPizza pizza = factory?.Create(description);
                Console.WriteLine( pizza );
            }
        }
    }
}
