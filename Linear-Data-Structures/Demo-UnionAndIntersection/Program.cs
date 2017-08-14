using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_UnionAndIntersection
{
    class Program
    {
        public static void Main()
        {
            int[] firstArray = { 1, 2, 3, 4, 5 };
            Console.Write("First Array = ");
            PrintArray(firstArray);

            int[] secondArray = { 2, 4, 6 };
            Console.Write("Second Array = ");
            PrintArray(secondArray);

            int[] unionArray = Union(firstArray, secondArray);
            Console.Write("Union = ");
            PrintArray(unionArray);

            int[] intersectArray = Intersect(firstArray, secondArray);
            Console.Write("Intersect = ");
            PrintArray(intersectArray);
        }

        private static int[] Union(int[] firstArray, int[] secondArray)
        {
            List<int> unitedList = new List<int>();

            unitedList.AddRange(firstArray);

            foreach (var element in secondArray)
            {
                if (!unitedList.Contains(element))
                {
                    unitedList.Add(element);
                }
            }

            return unitedList.ToArray();
        }

        private static int[] Intersect(int[] firstArray, int[] secondArray)
        {
            List<int> intersect = new List<int>();

            for (int i = 0; i < firstArray.Length; i++)
            {
                for (int j = 0; j < secondArray.Length; j++)
                {
                    if (firstArray[i] == secondArray[j] && !intersect.Contains(firstArray[i]))
                    {
                        intersect.Add(firstArray[i]);
                    }
                }
            }

            return intersect.ToArray();
        }

        private static void PrintArray(int[] array)
        {
            Console.Write("{");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("}");
        }

    }
}
