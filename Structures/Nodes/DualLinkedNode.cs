﻿//using System;
//using System.Collections.Generic;
//using System.Text;
using Structures.Interfaces.Simple;

namespace Structures.Nodes
{
    public class DualLinkedNode<T> : IDualLinkNode<T>
    {
        public IDualLinkNode<T> Previous { get; set; }
        public IDualLinkNode<T> Next { get; set; }
        public T Content { get; set; }
    }
}
