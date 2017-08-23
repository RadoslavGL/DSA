using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_PathsInLabirinth
{
    public class PathsInLabirinth
    {
        public class PathFindingInLabirinth
        {
            static char[,] maze =
                {
                    {' ', ' ', ' '/*, '*', ' ', ' ', ' '*/},
                    {' ', '*', ' '/*, '*', ' ', '*', ' '*/},
                    {' ', ' ', 'e'/*, ' ', ' ', ' ', ' '*/},
                  /*  {' ', '*', ' ', '*', '*', '*', ' '},*/
                  /*  {' ', ' ', 'e', ' ', ' ', ' ', 'e'},*/
                };

            public static List<Tuple<int, int>> path = new List<Tuple<int, int>>();

            public static bool IsInRange(int row, int col)
            {
                bool isRowInRange = row >= 0 && row < maze.GetLength(0);
                bool isColInRange = col >= 0 && col < maze.GetLength(1);

                return isColInRange && isRowInRange;
            }

            public static void FindPathToExit(int row, int col)
            {
                if (!IsInRange(row, col))
                {
                    //we out of the maze and have not found an exit
                    return;
                }

                //have we found an exit? YES!
                if (maze[row, col] == 'e')
                {
                    PrintPath(row, col);
                }

                if (maze[row, col] != ' ')
                {
                    //blocked cell
                    return;
                }

                //Temporally mark the current cell as Visited to avoid cycles
                maze[row, col] = 's';
                path.Add(new Tuple<int, int>(row, col));

                //invoke recursions to explore all possible directions
                FindPathToExit(row, col - 1); //left
                FindPathToExit(row, col + 1); //right
                FindPathToExit(row - 1, col); // up
                FindPathToExit(row + 1, col); // down

                //Mark back the current cell as free
                //if we comment the line below each cell can be visited only once

                maze[row, col] = ' ';
                path.RemoveAt(path.Count - 1);
            }


            private static void PrintPath(int finalRow, int finalCol)
            {
                Console.WriteLine("Exit found: ");
                foreach (var cell in path)
                {
                    Console.Write("({0},{1}) -> ", cell.Item1, cell.Item2);
                }
                Console.WriteLine("({0},{1})", finalRow, finalCol);
                Console.WriteLine();
            }

            public static void Main(string[] args)
            {
                FindPathToExit(0, 0);

            }
        }




    }
}
