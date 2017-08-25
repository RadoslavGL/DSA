using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01_Searching
{
    public static class BinarySearchRecursive
    {
        public static int BinarySearchGenericRecursive<T>(this T[] array, T value)
            where T : IComparable<T>
        {
            return array.BinarySearchGenericRecursive(value, 0, array.Length);    
        }

        public static int BinarySearchGenericRecursive<T>(this T[] array, T value, int left, int right)
            where T : IComparable<T>
        {
            if (left >= right)
            {
                return -1;
            }

            int middle = (left + right) / 2;
            int cmp = array[middle].CompareTo(value);
            if (cmp <0)
            {
                return array.BinarySearchGenericRecursive(value, middle + 1, right);
            }
            if (cmp > 0)
            {
                return array.BinarySearchGenericRecursive(value, left, middle -1);

            }
            return middle;
        }
    }
}
