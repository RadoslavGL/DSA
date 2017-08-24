using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Variations
{
    class Variations
    {
        private static StringBuilder sb;

        private static void Variate(int index, string[] arr, string[] set)
        {
            if (index >= arr.Length)
            {
                sb.Append(string.Format("({0}), ", string.Join(" ", arr)));
                return;
            }

            for (int i = 0; i < set.Length; i++)
            {
                arr[index] = set[i];
                Variate(index + 1, arr, set);
                arr[index] = string.Empty;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input subses length: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Result subset length: ");
            int k = int.Parse(Console.ReadLine());

            string[] set = new string[n];
            string[] arr = new string[k];

            Console.WriteLine("Input {0} strings: ", n);
            for (int i = 0; i < n; i++)
            {
                set[i] = Console.ReadLine();
            }

            sb = new StringBuilder();

            Variate(0, arr, set);

            Console.WriteLine(sb.ToString().TrimEnd(new char[] { ' ', ',' }));
        }
    }
}
