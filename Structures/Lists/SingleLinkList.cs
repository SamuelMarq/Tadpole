using Structures.Interfaces.Lists;
using Structures.Interfaces.Simple;
using Structures.Nodes;

namespace Structures.Lists
{
    public class SingleLinkList<T> : ISingleLinkList<T>
    {
        #region Properties
        ISingleLinkNode<T> FirstNode { get; set; }

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
        #endregion

        #region Add
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
            if (FirstNode == null)
            {
                FirstNode = node;
                return;
            }
            node.Next = next;
            if (next == FirstNode) FirstNode = node;
            else if (next == null) LastNode.Next = node;
            

        }
        #endregion

        #region Remove

        public T RemoveFirst()
        {
            var val = FirstNode.Content;
            FirstNode=FirstNode.Next;
            return val;
        }

        public T RemoveLast()
        {
            var val = LastNode.Content;
            var current = FirstNode;
            while (current.Next!=LastNode)
            {
                current = current.Next;
            }
            current.Next = null;
            return val;
        }


        //T Remove(ISingleLinkNode<T> node)
        //{
            
        //}
        #endregion
    }
}
