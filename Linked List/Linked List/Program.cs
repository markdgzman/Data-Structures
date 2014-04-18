using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List prog = new List();
            Console.WriteLine(prog.isEmpty());

            prog.Append();
            prog.Append();
            prog.Append();
            Console.ReadKey();
        }
    }
}
