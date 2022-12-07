using System;

namespace Exercise_4
{
    class Node
    {
        public int info;
        public Node next;
        public Node(int i, Node n)
        {
            info = i;
            next = n;
        }
    }
    class Stacks
    {
        Node top;
        public Stacks()
        {

        }
    }
}
