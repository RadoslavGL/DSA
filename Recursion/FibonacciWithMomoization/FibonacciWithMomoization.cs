using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciWithMomoization
{
    public class FibonacciWithMomoization
    {
        const int MAX_FIBONACCI_SEQUENCE_MEMBER = 1000;
        static decimal[] fib = new decimal[MAX_FIBONACCI_SEQUENCE_MEMBER];
        static decimal recursiveCallsCounter = 0;

        public static decimal Fibonacci(int n)
        {
            recursiveCallsCounter++;
            if (fib[n] == 0)
            {
                if ((n == 1) || (n == 2))
                {
                    fib[n] = 1;
                }
                else
                {
                    fib[n] = Fibonacci(n - 1) + Fibonacci(n - 2);
                }
            }
            return fib[n];
        }

        public static void Main(string[] args)
        {
            int num = 10;
            decimal fib = Fibonacci(num);
            Console.WriteLine("Fib({0}) = {1}", num, fib);
            Console.WriteLine("Recursive calls = {0}",
                recursiveCallsCounter);
        }
    }
}
