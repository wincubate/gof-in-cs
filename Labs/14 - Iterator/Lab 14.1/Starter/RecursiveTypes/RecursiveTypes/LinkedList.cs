namespace RecursiveTypes
{
    public class LinkedList
    {
        public Node Head { get; private set; }
        public Node Last { get; private set; }

        public LinkedList()
        {
            Head = null;
        }

        public void Add( object data )
        {
            Node node = new Node { Data = data };
            if (Head == null)
            {
                Head = node;
                Last = node;
            }
            else
            {
                Last.Next = node;
                Last = Last.Next;
            }
        }
    }
}
