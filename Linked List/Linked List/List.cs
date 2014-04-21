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
            //Add another note data type to point towards next


            public void insert(String data)
            {
                Node add = new Node();
                add.name = data;

                //check if head node is empty
                //else add to next
                
            }
        }

        static void Main(string[] args)
        {
            Node a = new Node();

            //insert to linked list
        }
    }
}
