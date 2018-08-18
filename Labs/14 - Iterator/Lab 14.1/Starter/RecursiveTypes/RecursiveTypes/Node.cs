namespace RecursiveTypes
{
    public class Node
    {
        public object Data { get; set; }
        public Node Next { get; set; }

        public Node( object data = null )
        {
            Data = data;
        }
    }
}
