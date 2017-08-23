using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02_Generating0_1Vectors
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Number of vector components: ");
            int number = int.Parse(Console.ReadLine());
            int[] array = new int[number];

            Gen01(number - 1, array);

        }

        public static void Gen01(int index, int[] array)
        {
            if (index == -1)
            {
                Print(array);
            }
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    array[index] = i;
                    Gen01(index - 1, array);
                }
            }

        }

        public static void Print(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write("{0}", item);
            }
            Console.WriteLine();
        }
    }
}
