﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03_SimpleOOP
{
    public class Program
    {
        public class Graph
        {
            public Graph(List<int>[] nodes)
            {
                this.ChildNodes = nodes;
            }

            public List<int>[] ChildNodes { get; set; }
        }

        public static void Main(string[] args)
        {
            var graph = new Graph(
                new[]
                {
                    new List<int> { 3, 6 }, // successors of vertice 0
                    new List<int> { 2, 3, 4, 5, 6 }, // successors of vertice 1
                    new List<int> { 1, 4, 5 }, // successors of vertice 2
                    new List<int> { 0, 1, 5 }, // successors of vertice 3
                    new List<int> { 1, 2, 6 }, // successors of vertice 4
                    new List<int> { 1, 2, 3 }, // successors of vertice 5
                    new List<int> { 0, 1, 4 } // successors of vertice 6

                });

            for (int i = 0; i < graph.ChildNodes.Length; i++)
            {
                Console.Write(i + " ==> ");
                for (int j = 0; j < graph.ChildNodes[i].Count; j++)
                {
                    Console.Write(graph.ChildNodes[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
