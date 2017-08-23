using System.Text;
using System;

namespace Task1_NestedLoops
{
    class NestedLoops
    {
        private static StringBuilder sb;

        private static void SimulateLoops(int loops, int depth, int[] values)
        {
            if (depth == 0)
            {
                sb.AppendLine(string.Join(" ", values));
                return;
            }

            for (int i = 1; i <= loops; i++)
            {
                values[depth - 1] = i;
                SimulateLoops(loops, depth - 1, values);
            }
        }

        static void Main(string[] args)
        {

            sb = new StringBuilder();

            int n = int.Parse(Console.ReadLine());
            SimulateLoops(n, n, new int[n]);

            Console.WriteLine(sb.ToString());
        }
    }
}
