using System;

namespace RecursiveTypes
{
    class Program
    {
        static void Main( string[] args )
        {
            LinkedList<int> ll = new LinkedList<int>()
            {
                42, 87, 112, 176, 255   // <-- because LinkedList<T> : IEnumerable<T>
                                        // we can in fact use object initializer syntax
            };

            foreach (int i in ll)
            {
                Console.WriteLine(i);
            }
        }
    }
}
