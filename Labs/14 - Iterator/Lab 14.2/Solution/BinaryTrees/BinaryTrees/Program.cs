using System;

namespace BinaryTrees
{
    class Program
    {
        static void Main( string[] args )
        {
            Node node = new Node(
               42,
               new Node(87, new Node(112), new Node(176)),
               new Node(256)
            );

            foreach (int i in node)
            {
                Console.WriteLine(i);
            }
        }
    }
}
