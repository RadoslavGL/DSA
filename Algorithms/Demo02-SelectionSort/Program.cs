using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02_SelectionSort
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
        
        
    }

    public static class Sort
    {
        public static void SelectionSort<T>(this T[] array)
            where T : IComparable<T>
        {
            for (int i = 0; i < array.Length - 2; i++)
            {
                for (int j = i + 1; j < array.Length - 1; j++)
                {
                    if (array[j].CompareTo(array[i]) < 0)
                    {
                        var swap = array[j];
                        array[j] = array[i];
                        array[i] = swap;
                    }
                }
            }
        }
    }
}
