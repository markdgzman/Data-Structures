using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    class List
    {
        public class Node
        {
            public String name;
            public Node next;
        }

        public class LinkedList
        {
            private Node head;

            public void insert(String data)
            {
                Node add = new Node();
                add.name = data;
            }
        }

        static void Main(string[] args)
        {
            Node a = new Node();
        }
    }
}
