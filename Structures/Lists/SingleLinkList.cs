using Structures.Interfaces.Lists;
using Structures.Interfaces.Simple;
using Structures.Nodes;

namespace Structures.Lists
{
    class SingleLinkList<T> : ISingleLinkList<T>
    {
        public ISingleLinkNode<T> FirstNode { get; set; }

        ISingleLinkNode<T> LastNode
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

        public void AddFirst(T value)
        {
            var node = new SingleLinkNode<T>(value);
            Add(node, FirstNode);
        }

        public void AddLast(T value)
        {
            var node = new SingleLinkNode<T>(value);
            Add(node, null);
        }

        void Add(ISingleLinkNode<T> node, ISingleLinkNode<T> next)
        {
            if (FirstNode == null) FirstNode = node;
            node.Next = next;
            if (next == FirstNode) FirstNode = node;
            else if (next == null) LastNode.Next = node;
            

        }
    }
}
