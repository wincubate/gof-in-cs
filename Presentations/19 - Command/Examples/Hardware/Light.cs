using System;

namespace Wincubate.CommandExamples.Hardware
{
    public class Light : IToggleable
    {
        private bool _on;

        public Light() => _on = false;

        public void Toggle()
        {
            _on = !_on;

            DisplayState();
        }

        private void DisplayState()
        {
            ConsoleColor old = Console.ForegroundColor;
            if (_on == true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine(
                    @"    |=|    " + Environment.NewLine +
                    @"    / \    " + Environment.NewLine +
                    @"---(   )---" + Environment.NewLine +
                    @"   .`-'.   " + Environment.NewLine +
                    @"  /  |  \  " + Environment.NewLine +
                    @" '   |   ' " + Environment.NewLine);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine(
                    @"    |=|    " + Environment.NewLine +
                    @"    / \    " + Environment.NewLine +
                    @"   (   )   " + Environment.NewLine +
                    @"    `-'    " + Environment.NewLine);
            }

            Console.ForegroundColor = old;
        }
    }
}