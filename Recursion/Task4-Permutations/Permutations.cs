using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_Permutations
{
    
    public class Permutations
    {
        private static StringBuilder sb;

        private static void Permutate(int min, int max, int index, int[] arr)
        {
            if (index >= arr.Length)
            {
                sb.AppendLine(string.Format("{{ {0} }}", string.Join(" ", arr)));
            }

            for (int i = min; i <= max; i++)
            {
                if (!arr.Contains(i))
                {
                    arr[index] = i;
                    Permutate(min, max, index + 1, arr);
                    arr[index] = 0;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Length of the permutataion:");
            var n = int.Parse(Console.ReadLine());
            var arr = new int[n];
            sb = new StringBuilder();
            Permutate(1, n, 0, arr);
            Console.WriteLine(sb.ToString());
        }
    }
}
