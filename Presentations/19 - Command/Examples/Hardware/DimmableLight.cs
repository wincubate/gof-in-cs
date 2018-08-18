using System;

namespace Wincubate.CommandExamples.Hardware
{
    internal enum DimmableDirection
    {
        Up,
        Down
    }

    public class DimmableLight : IToggleable
    {
        private readonly int _maxStep;
        private int _currentStep;
        private DimmableDirection _direction;

        ConsoleColor[] _colorSteps =
        {
            ConsoleColor.Black,
            ConsoleColor.DarkGray,
            ConsoleColor.Gray,
            ConsoleColor.White
        };

        public DimmableLight()
        {
            _maxStep = _colorSteps.Length - 1;
            _currentStep = 0;
            _direction = DimmableDirection.Up;
        }

        public void Toggle()
        {
            if (_direction == DimmableDirection.Up)
            {
                if (_currentStep < _maxStep)
                {
                    _currentStep++;
                }
                if (_currentStep == _maxStep)
                {
                    _direction = DimmableDirection.Down;
                }
            }
            else
            {
                if (0 < _currentStep)
                {
                    _currentStep--;
                }
                if (_currentStep == 0)
                {
                    _direction = DimmableDirection.Up;
                }
            }

            DisplayState();
        }

        private void DisplayState()
        {
            ConsoleColor old = Console.ForegroundColor;
            Console.ForegroundColor = _colorSteps[ _currentStep ];

            Console.WriteLine(
                @"    |=|    " + Environment.NewLine +
                @"    / \    " + Environment.NewLine +
                @"---(   )---" + Environment.NewLine +
                @"   .`-'.   " + Environment.NewLine +
                @"  /  |  \  " + Environment.NewLine +
                @" '   |   ' " + Environment.NewLine);

            Console.ForegroundColor = old;
        }
    }
}