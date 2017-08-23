using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2___CombinationWithDuplicates
{
    public class CombinationWithDuplicates
    {
        private static StringBuilder sb;

        private static void CombinationsWithDup(int firstNum, int lastNum, int index, int[] values)
        {
            if (index >= values.Length)
            {
                sb.AppendLine(string.Format("({0})", string.Join(" ", values)));

                return;
            }
            for (int i = firstNum; i <= lastNum; i++)
            {
               

                values[index] = i;

                CombinationsWithDup(i, lastNum, index+1, values);
            }

        }

        public static void Main(string[] args)
        {
            Console.WriteLine("How many elements do you want the set to contain:");
            int topNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Define the size of the combinations:");
            int comboRange = int.Parse(Console.ReadLine());

            sb = new StringBuilder();

            

            CombinationsWithDup(1, topNumber, 0, new int[comboRange]);

            Console.WriteLine(sb.ToString().TrimEnd(new char[] {' ', ',' }));
        }
    }
}
