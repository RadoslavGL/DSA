using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01_RecursiveFactorial
{
    public class RecursiveFactorial
    {
        public static decimal Factorial(decimal number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            decimal number = decimal.Parse(Console.ReadLine());
            Console.WriteLine("{0}! = {1}",number, Factorial(number));
        }
    }
}
