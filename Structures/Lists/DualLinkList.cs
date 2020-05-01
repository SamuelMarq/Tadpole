using Structures.Interfaces.Lists;
using Structures.Interfaces.Simple;
using Structures.Nodes;

namespace Structures.Lists
{
    public class DualLinkList<T> : IDualLinkList<T>
    {
        #region Properties
        IDualLinkNode<T> FirstNode { get; set; }

        IDualLinkNode<T> LastNode
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

        IDualLinkNode<T> _current;
        public T Current
        {
            get
            {
                if (_current == null) return default;
                return _current.Content;
            }
        }
        #endregion

        #region Add
        public void AddFirst(T value)
        {
            var node = new DualLinkNode<T>(value);
            Add(node, FirstNode);
        }

        public void AddLast(T value)
        {
            var node = new DualLinkNode<T>(value);
            Add(node, null);
        }

        void Add(IDualLinkNode<T> node, IDualLinkNode<T> next)
        {
            if (FirstNode == null) 
            {
                FirstNode = node;
                _current = FirstNode;
                return; 
            }
            node.Next = next;
            if (next == FirstNode)
            {
                FirstNode.Previous = node;
                FirstNode = node;
            }
            else if (next == null)
            {
                node.Previous = LastNode;
                LastNode.Next = node;
            }


        }
        #endregion

        #region Remove

        public T RemoveFirst()
        {
            if (_current == LastNode) _current = _current.Next;
            var val = FirstNode.Content;
            FirstNode = FirstNode.Next;
            FirstNode.Previous = null;
            return val;
        }

        public T RemoveLast()
        {
            if (_current == LastNode) _current = _current.Previous;
            var current = FirstNode;
            while (current.Next != LastNode)
            {
                current = current.Next;
            }
            var val = current.Next.Content;
            current.Next = null;
            return val;
        }




        //T Remove(IDualLinkList<T> node)
        //{

        //}
        #endregion

        public void Next()
        {
            if (_current != null)
            {
                if (_current.Next != null)
                    _current = _current.Next;
            }
        }

        public void Previous()
        {
            if (_current != null)
            {
                if (_current.Previous != null)
                    _current = _current.Previous;
            }
        }

        public void Reset()
        {
            _current = FirstNode;
        }
    }
}
