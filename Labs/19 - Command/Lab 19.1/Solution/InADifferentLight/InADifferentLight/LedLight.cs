using System;

namespace InADifferentLight
{
    class LedLight : IUnit
    {
        public int CurrentIntensity { get; private set; }

        private ConsoleColor Color { get; }

        public LedLight( ConsoleColor color )
        {
            Color = color;
            CurrentIntensity = 0;
        }

        public void SetIntensity( int intensityPercentage )
        {
            if (intensityPercentage < 0)
            {
                intensityPercentage = 0;
            }
            else if (intensityPercentage > 100)
            {
                intensityPercentage = 100;
            }

            CurrentIntensity = intensityPercentage;

            DisplayState();
        }

        private void DisplayState()
        {
            ConsoleColor old = Console.ForegroundColor;

            Console.ForegroundColor = Color;
            Console.WriteLine($"LED Intensity: {CurrentIntensity,3}% {new string('*', CurrentIntensity / 5)}");

            Console.ForegroundColor = old;
        }
    }
}
