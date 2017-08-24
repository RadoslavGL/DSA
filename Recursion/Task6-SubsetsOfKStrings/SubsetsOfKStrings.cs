using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_SubsetsOfKStrings
{
    public class SubsetsOfKStrings
    {
        private static StringBuilder sb;

        public static void GenerateSubsets(int min, int index, string[] set, string[] arr)
        {
            if (index >= arr.Length)
            {
                sb.Append(string.Format("({0}), ", string.Join(" ", arr)));
                return;
            }

            for (int i = min; i < set.Length; i++)
            {
                arr[index] = set[i];
                GenerateSubsets(i+1, index + 1, set, arr);

            }
        }

        public static void Main(string[] args)
        {
            string[] set = new string[3]{ "rock", "paper", "shotgun" };
            string[] arr = new string[2];
            sb = new StringBuilder();

            GenerateSubsets(0, 0, set, arr);

            Console.WriteLine(sb.ToString().TrimEnd(new char[] {' ', ',' }));

        }
    }
}
