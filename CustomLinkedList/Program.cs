using System;
using System.Collections.Generic;
using System.Numerics;

namespace CustomLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CstLinkedList<int> cs = new CstLinkedList<int>();
            cs.Add(1);
            cs.Add(2);
            cs.ShowInfo();
         
        }
    }
}
