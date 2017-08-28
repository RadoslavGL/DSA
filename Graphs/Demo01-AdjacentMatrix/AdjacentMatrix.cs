using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01_AdjacentMatrix
{
    public class AdjacentMatrix
    {
        public static void Main(string[] args)
        {
            int nodes = 5;

            var graph = new int[nodes, nodes];

            for (int i = 0; i < nodes; i++)
            {
                string[] connections = Console.ReadLine().Split(' ');
                foreach (var connection in connections)
                {
                    graph[i, int.Parse(connection)] = 1;
                }
            }

            //print
            for (int i = 0; i < nodes; i++)
            {
                for (int k = 0; k < nodes; k++)
                {
                    Console.Write(graph[i, k] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
