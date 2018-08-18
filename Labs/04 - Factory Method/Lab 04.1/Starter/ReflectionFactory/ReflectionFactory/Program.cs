using System.Collections.Generic;

namespace Wincubate.FactoryMethodLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizzaFactory factory = null; // TODO: Add concrete reflection factory here

            List<string> pizzasToCreate = new List<string>
            {
                "margherita pizza",
                "meat lover pizza",
                "El Diablo pizza",
                "Hawaii Pizza"
            };

            // TODO: Instantiate objects corresponding to the string descriptions in pizzasToCreate
        }
    }
}
