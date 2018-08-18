using System;

namespace Wincubate.AbstractFactoryExamples
{
    class Program
    {
        static void Main( string[] args )
        {
            // HR New Employee Process

            IMobilePhone phone = new Iphone7(32);
            phone.Call("+45 12345678");

            ITablet tablet = new Ipad("Air 3", 9.7);
            tablet.PowerOn();
            tablet.PowerOff();
        }
    }
}