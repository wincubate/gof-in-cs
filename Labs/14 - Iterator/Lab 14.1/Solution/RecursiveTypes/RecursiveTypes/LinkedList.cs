using System.Collections.Generic;

namespace RecursiveTypes
{
    public class LinkedList<T> : IEnumerable<T>
    {
        public Node<T> Head { get; private set; }
        public Node<T> Last { get; private set; }


        public LinkedList()
        {
            Head = null;
        }

        public void Add( T data )
        {
            Node<T> node = new Node<T> { Data = data };
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

        #region IEnumerable<T> Members

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();

        #endregion
    }
}
