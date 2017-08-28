using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guards
{
    class Program
    {
        public const int Infinity = int.MaxValue;
        public const int NormalStep = 1;
        public const int GuardStep = 3;

        static void Main(string[] args)
        {
            int[] mazeDimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = mazeDimensions[0];
            int cols = mazeDimensions[1];
            long[,] maze = new long[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    maze[i, j] = 1;
                }
            }
            int numberOfGuard = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfGuard; i++)
            {
                string[] guardPosition = Console.ReadLine().Split().ToArray();
                int guardRow = int.Parse(guardPosition[0]);
                int guardCol = int.Parse(guardPosition[1]);
                maze[guardRow, guardCol] = Infinity;
                switch (guardPosition[2])
                {
                    case "R":
                        if ((guardCol + 1 < cols) && maze[guardRow, guardCol + 1] != Infinity)
                        {
                            maze[guardRow, guardCol + 1] = 3;
                        }
                        break;
                    case "L":
                        if ((guardCol - 1 > -1) && maze[guardRow, guardCol - 1] != Infinity)
                        {
                            maze[guardRow, guardCol - 1] = 3;
                        }
                        break;
                    case "U":
                        if ((guardRow - 1 > -1) && (maze[guardRow - 1, guardCol] != Infinity))
                        {
                            maze[guardRow - 1, guardCol] = 3;
                        }
                        break;
                    case "D":
                        if ((guardRow + 1 < rows) && (maze[guardRow + 1, guardCol] != Infinity))
                        {
                            maze[guardRow + 1, guardCol] = 3;
                        }
                        break;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == 0 && j == 0 && maze[i, j] != Infinity)
                    {
                        maze[i, j] = 1;
                    }
                    if (i == 0 & j != 0)
                    {
                        maze[i, j] += maze[i, j - 1];
                    }
                    if (i != 0 && j == 0)
                    {
                        maze[i, j] += maze[i - 1, j];
                    }
                    if (i != 0 && j != 0)
                    {
                        maze[i, j] += Math.Min(maze[i - 1, j], maze[i, j - 1]);
                    }
                }
            }

            long result = maze[rows - 1, cols - 1];
            if (result > Infinity)
            {
                Console.WriteLine("Meow");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
