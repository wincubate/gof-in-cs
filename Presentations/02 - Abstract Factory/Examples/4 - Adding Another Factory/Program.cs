namespace Wincubate.AbstractFactoryExamples
{
    class Program
    {
        static void Main( string[] args )
        {
            // HR New Employee Process

            IDeviceFactory factory = new SamsungFactory();

            IMobilePhone phone = factory.CreateMobilePhone();
            phone.Call("+45 12345678");

            ITablet tablet = factory.CreateTablet();
            tablet.PowerOn();
            tablet.PowerOff();
        }
    }
}