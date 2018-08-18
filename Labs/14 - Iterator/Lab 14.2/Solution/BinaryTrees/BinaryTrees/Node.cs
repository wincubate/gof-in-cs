using System.Collections;
using System.Collections.Generic;

namespace BinaryTrees
{
    class Node : IEnumerable<int>
    {
        public int Value { get; }
        public Node Left { get; }
        public Node Right { get; }

        public Node( int value, Node left = null, Node right = null )
        {
            Value = value;
            Left = left;
            Right = right;
        }

        #region IEnumerable<int> Members

        public IEnumerator<int> GetEnumerator()
        {
            yield return Value;

            if (Left != null)
            {
                foreach (int i in Left)
                {
                    yield return i;
                }
            }

            if (Right != null)
            {
                foreach (int i in Right)
                {
                    yield return i;
                }
            }
        }

        #endregion

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        #endregion
    }
}
