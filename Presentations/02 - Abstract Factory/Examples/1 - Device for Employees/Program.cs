using System;

namespace Wincubate.AbstractFactoryExamples
{
    class Program
    {
        static void Main( string[] args )
        {
            // HR New Employee Process

            Iphone7 phone = new Iphone7(32);
            phone.Call("+45 12345678");

            Ipad tablet = new Ipad("Air 3", 9.7);
            tablet.PowerOn();
            tablet.PowerOff();
        }
    }
}