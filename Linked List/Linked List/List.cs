using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    class List
    {
        static void Main(string[] args)
        {

            LinkedList a = new LinkedList();
            a.insert("Boo");
            a.insert(5);
            a.insert(60);
            a.insert(2);
            a.insert("Plaster");
            a.insert("Yourself");
            a.insert("Canada");
            a.insert(5);
            a.insert(60);
            a.insert(2);
            a.insert(10);
            a.insert(4);
            a.insert("Yourself");
            a.insert("Canada");
            a.insert(20);
            a.insert(1);
            a.insert(17);

            a.toString();

            a.delete(3);

            Console.WriteLine("\r\nDeleting Node index 3");
            a.toString();

            Console.WriteLine("\r\nDeleting Node index 3 and 6");
            a.delete(3);
            a.delete(6);
            a.toString();
            Console.Read();
        }
    }
}
