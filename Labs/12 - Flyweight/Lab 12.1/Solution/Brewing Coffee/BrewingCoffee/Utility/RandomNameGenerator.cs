using System;

namespace BrewingCoffee.Utility
{
    public class RandomNameGenerator
    {
        private static string[] _firstNames =
        {
            "Peter", "Jens", "John", "Jørgen", "Jesper", "Noah", "Bo", "Henrik", "Nils", "Rasmus",
            "Nina", "Frederikke", "Ane", "Heidi", "Lone", "Maria", "Consuela", "Annie"
        };
        private static string[] _lastNames =
        {
            "Graulund", "Jensen", "Doe", "Gulmann", "Henriksen", "Kirk", "Rammstein", "Thomassen",
            "Mortensen", "Leth", "Olsen", "Christensen", "Martinez", "Bundu", "Sana", "Riel"
        };

        private Random _random;

        public RandomNameGenerator()
        {
            _random = new Random((int)DateTime.Now.Ticks);        
        }

        public string GetRandomName() =>
            $"{_firstNames[_random.Next(0, _firstNames.Length)]} " +
            $"{_lastNames[_random.Next(0, _lastNames.Length)]} ";
    }
}
