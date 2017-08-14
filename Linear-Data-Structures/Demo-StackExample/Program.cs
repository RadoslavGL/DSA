using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var myStack = new Stack<string>();

            myStack.Push("1. Viktor");
            myStack.Push("2. Marto");
            myStack.Push("3. Doncho");
            myStack.Push("4. Cuki");
            myStack.Push("5. Evlogi");
            myStack.Push("6. Konstantin");
            myStack.Push("7. Ivan");
            myStack.Push("8. Steven");

            Console.WriteLine(myStack.Peek());

            while (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Pop());
            }
        }
    }
}
