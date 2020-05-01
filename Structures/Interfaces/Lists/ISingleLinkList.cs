using System;
using System.Collections.Generic;
using System.Text;

namespace Structures.Interfaces.Lists
{
    public interface ISingleLinkList<T>
    {
        public void AddFirst(T value);
        public void AddLast(T value);
    }
}
