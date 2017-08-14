using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_LInkList
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedList<string>();
            linkedList.AddFirst("First");
            linkedList.AddLast("Last");
            linkedList.AddBefore(linkedList.First, "BeforeFirst");
            linkedList.AddAfter(linkedList.Last, "AfterLast");

            Console.WriteLine(string.Join("\n", linkedList));

        }
    }
}
