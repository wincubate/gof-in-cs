namespace Wincubate.AbstractFactoryExamples
{
    class SamsungFactory : IDeviceFactory
    {
        public IMobilePhone CreateMobilePhone() => new SamsungS8(S8Kind.Plus);
        public ITablet CreateTablet() => new SamsungGalaxyTab("S3");
    }
}
