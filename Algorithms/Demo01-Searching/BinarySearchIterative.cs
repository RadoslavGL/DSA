using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01_Searching
{
    public static class BinarySearchIterative
    {
        public static int BinarySearchGenericIterative<T>(this T[] array, T value)
            where T : IComparable<T>
        {
            int left = 0;
            int right = array.Length;

            while (left < right)
            {
                int middle = (left + right) / 2;
                int cmp = array[middle].CompareTo(value);

                if (cmp < 0)
                {
                    left = middle + 1;
                }
                else if (cmp > 0)
                {
                    right = middle - 1;
                }
                else
                {
                    return middle;
                }

            }

            return -1;
        }

    }
}
