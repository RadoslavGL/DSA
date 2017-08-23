using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_HarmfulFibonacci
{
    class HarmfulFibonacci
    {
        static int recursiveCalls = 0;

        public static decimal Fibonacci(int n)
        {
            recursiveCalls++;
            if ((n == 1) || (n==2))
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Fib(10) = ");
            Console.WriteLine(Fibonacci(10));
            Console.WriteLine(recursiveCalls);

            //Console.Write("Fib(50) = ");
            //Console.WriteLine(Fibonacci(50));

        }
    }
}
