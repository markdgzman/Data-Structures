namespace Linked_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    /// 

    public class Node
    {
        public object data;
        public Node next = null;

        public Node(object d)
        {
            data = d;
        }

    }

    public class LinkedList
    {
        Node list;

        public void insert(object d)
        {
            if (list == null)
            {
                list = new Node(d);
                return;
            }

            Node newNode = new Node(d);
            Node current = list;

            while (current.next != null)
            {
                current = current.next;
            }

            current.next = newNode;
        }

        public void delete(int index)
        {
            Node bIndex = list;
            Node aIndex = list;

            for (int i = 1; i < index - 1; i++)
                bIndex = bIndex.next;

            for (int i = 1; i < index + 1; i++)
                aIndex = aIndex.next;

            bIndex.next = aIndex;
        }

        public void toString()
        {
            Node current = list;
            int indexCounter = 1;
            while (current.next != null)
            {
                Console.WriteLine("Node " + indexCounter + ": " + current.data);
                current = current.next;
                indexCounter++;
            }
            Console.WriteLine("Node " + indexCounter + ": " + current.data);
        }
    }
}
