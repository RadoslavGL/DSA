using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01_Searching
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static void Shuffle(List<int> numbers)
        {
            Random rnd = new Random();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                int newIndex = rnd.Next(i + 1, numbers.Count - 1);
                int temp = numbers[newIndex];
                numbers[newIndex] = numbers[i];
                numbers[i] = temp;
            }
        }
    }
}
