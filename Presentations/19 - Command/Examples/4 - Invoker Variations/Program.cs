using Wincubate.CommandExamples.Hardware;
using System;

namespace Wincubate.CommandExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            IToggleable light = new DimmableLight();
            ISwitch button = new TimedSwitch(new ToggleCommand(light));

            while( true)
            {
                string input = Console.ReadLine();
                if( input.ToLower() == string.Empty )
                {
                    button.Click();
                }
                else
                {
                    break;
                }
            }
        }
    }
}