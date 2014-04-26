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

            public Node()
            {
                name = null;
                next = null;
            }
            
            public Node(String v, Node s)
            {
                name = v;
                next = s;
            }

            public Node(String v)
            {
                name = v;
            }
        }

        public class LinkedList
        {
            private Node head;
            /*
            private Node head;
            private Node next;*/
            //Add another note data type to point towards next

            public LinkedList()
            {
                head = new Node();
            }

            public void insert(String data)
            {
                Node newNode = new Node();
                if (head == null)
                    head.name = data;
                else
                {
                    newNode.name = data;
                    newNode.next = head;
                    head = newNode;
                }  
            }

            public void display()
            {
                
                while(head != null)
                {
                    Console.WriteLine(head.name);
                    head = head.next;
                }
            }
        }

        static void Main(string[] args)
        {

            LinkedList a = new LinkedList();
            a.insert("Boo");
            a.insert("Plaster");
            a.insert("Yourself");
            a.insert("Canada");
            a.display();

            Node b = new Node("Ottawa");
            Node c = new Node("Canada",b);
            Node d = new Node("Hello",c);
            Node e = new Node("Good",d);
/*
            b.name = "Ottawa";
            b.next = c;
            c.name = "Canada";
            c.next = d;
            d.name = "Hello";
            d.next = e;
            e.name = "Good";*/
            /*a.insert("Ottawa");
            a.insert("Canada");
            a.insert("Hey");
            a.insert("Hello");
            a.insert("Bye");
            a.insert("Good");
            */
            Console.Read();
            //insert to linked list
        }
    }
}
