using Wincubate.CommandExamples.Hardware;
using System;

namespace Wincubate.CommandExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Light light = new Light();

            while( true)
            {
                string input = Console.ReadLine();
                if( input.ToLower() == "toggle" )
                {
                    light.Toggle();
                }
                else
                {
                    break;
                }
            }
        }
    }
}
