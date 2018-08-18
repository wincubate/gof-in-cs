namespace Wincubate.AbstractFactoryExamples
{
    class AppleFactory : IDeviceFactory
    {
        public IMobilePhone CreateMobilePhone() => new Iphone7(32); // <-- now easy change to 64 GB
        public ITablet CreateTablet() => new Ipad("Air 3", 9.7); // <-- now easy change to 12.9"
    }
}