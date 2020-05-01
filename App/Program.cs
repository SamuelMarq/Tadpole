using System;
using Structures.Nodes;
using Structures.Lists;
using Structures.Interfaces.Simple;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            //var node = new SingleLinkNode<int>(3);
            var list = new DualLinkList<int>();
            list.AddFirst(5);
            list.AddFirst(4);
            list.AddFirst(3);
            list.AddFirst(2);
            list.AddFirst(1);
            list.RemoveFirst();
            list.RemoveLast();
        }
    }
}
