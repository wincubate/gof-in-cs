using System;

namespace Wincubate.DisposeExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileWriter fileWriter = new FileWriter())
            {
                fileWriter.Log();
                fileWriter.Log();
                fileWriter.Log();
            } // <-- Invokes Dispose()

            // FileWriter is no longer needed

            Console.WriteLine("Waiting to terminate...");
            Console.ReadLine();
        }
    }
}
