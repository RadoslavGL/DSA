using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03_CombinationsGenerator
{
    public class CombinationsGenerator
    {
        public static void GenerateCombinations(int[] arr, int index, int startNum, int endNum)
        {
            if (index >= arr.Length)
            {
                //print combinations
                Console.WriteLine("(" + string.Join(", ", arr) + ")");
            }
            else
            {
                for (int i = startNum; i <= endNum; i++)
                {
                    arr[index] = i;
                    GenerateCombinations(arr, index + 1, i + 1, endNum);
                }
            }
        }

        public static void Main(string[] args)
        {
            int n = 5;
            int startNum = 4;
            int endNum = 9;
            int[] arr = new int[n];

            GenerateCombinations(arr, 0, startNum, endNum);
        }
    }
}
