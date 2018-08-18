namespace RecursiveTypes
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node( T data = default(T) )
        {
            Data = data;
        }
    }
}
