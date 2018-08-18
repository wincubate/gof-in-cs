namespace Wincubate.DisposeExamples
{
    class A
    {
        public static int InstanceCount
        {
            get;
            private set;
        }

        static A()
        {
            InstanceCount = 0;
        }

        public A()
        {
            InstanceCount++;
        }

        ~A()
        {
            InstanceCount--;
        }
    }
}
