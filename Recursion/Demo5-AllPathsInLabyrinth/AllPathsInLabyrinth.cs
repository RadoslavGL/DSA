
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class AllPathsInLabyrinth
{
    static char[,] maze =
        {
            {' ', ' ', ' ', '*', ' ', ' ', ' '},
            {'*', '*', ' ', '*', ' ', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', '*', '*', '*', '*', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', 'e'},
        };

    static List<char> path = new List<char>();

    public static bool InRange(int row, int col)
    {
        bool rowInRange = row >= 0 && row < maze.GetLength(0);
        bool colInRange = col >= 0 && col < maze.GetLength(1);

        return rowInRange && colInRange;
    }

    public static void FindPathToExit(int row, int col, char direction)
    {

        PrintLabyrinth(row, col);


        if (!InRange(row, col))
        {
            //no path
            return;
        }

        //append the current direction to path
        path.Add(direction);

        //chech if exit is found
        if (maze[row, col] == 'e')
        {
            PrintPath(path);
        }

        //movement if the cell is not occupied
        if (maze[row, col] == ' ')
        {
            //marking the cell as visited
            maze[row, col] = 's';

            //recursive exploration in all direction
            FindPathToExit(row, col - 1, 'L');
            FindPathToExit(row, col + 1, 'R');
            FindPathToExit(row - 1, col, 'U');
            FindPathToExit(row + 1, col, 'D');

            //marking the current cell back free; unmarking
            maze[row, col] = ' ';
        }

       

        //remove the last directions from the path
        path.RemoveAt(path.Count - 1);

    }

    private static void PrintLabyrinth(int currentRow, int currentCol)
    {
        for (int row = -1 ; row < maze.GetLength(0); row++)
        {
            Console.WriteLine();
            for (int col = -1; col < maze.GetLength(1); col++)
            {
                if ((row == currentRow) && (col == currentCol))
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("x");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else if (!InRange(row, col))
                {
                    Console.Write(" ");
                }
                else if (maze[row, col] == ' ')
                {
                    Console.Write("-");
                }
                else
                {
                    Console.Write(maze[row, col]);
                }
                    
            }
        }
        Console.Write(" ");
        Console.ReadKey();
    }

    public static void PrintPath(List<char> path)
    {
        Console.Write("Found path to the exit: ");
        foreach (var direction in path)
        {
            Console.Write(direction);
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        FindPathToExit(0, 0, 's');
    }
}

