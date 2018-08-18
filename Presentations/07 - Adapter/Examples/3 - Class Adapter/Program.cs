using System;
using Wincubate.AdapterExamples.Client;

namespace Wincubate.AdapterExamples
{
    class Program
    {
        static void Main( string[] args )
        {
            Rectangle rectangle = new Rectangle(1, 2, 3, 4);

            AreaClient client = new AreaClient(
                new ShapeProcessorClassAdapter()
            );

            Console.WriteLine($"Area of {rectangle} is {client.GetArea(rectangle)}");
        }
    }
}
