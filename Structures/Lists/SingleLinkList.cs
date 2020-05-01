using Structures.Interfaces.Lists;
using Structures.Interfaces.Simple;

namespace Structures.Lists
{
    class SingleLinkList<T> : ISingleLinkList<T>
    {
        public ISingleLinkNode<T> FirstNode { get; set; }

        ISingleLinkNode<T> Last
        {
            get
            {
                if (FirstNode == null) return null;
                var current = FirstNode;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                return current;
            }
        }

        void AddFirst(ISingleLinkNode<T> node)
        {

        }

        void AddLast(ISingleLinkNode<T> node)
        {

        }

        void Add(ISingleLinkNode<T> node, ISingleLinkNode<T> next)
        {
            if (FirstNode == null) FirstNode = node;
            node.Next = next;

        }
    }
}
