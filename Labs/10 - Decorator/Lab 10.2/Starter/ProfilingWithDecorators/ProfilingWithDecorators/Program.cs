using Library;

namespace ProfilingWithDecorators
{
    class Program
    {
        static void Main(string[] args)
        {
            IComputeOperation operation = new ComputeOperation();
            operation.Compute(100);
        }
    }
}
