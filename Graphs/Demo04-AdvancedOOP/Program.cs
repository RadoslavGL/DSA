﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_AdvancedOOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var graph = new Graph();

            //nodes
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("C");
            graph.AddNode("D");
            graph.AddNode("E");
            graph.AddNode("F");
            graph.AddNode("G");
            graph.AddNode("H");
            graph.AddNode("I");
            graph.AddNode("J");
            graph.AddNode("Z");

            //Connections
            graph.AddConnection("A", "B", 14, true);
            graph.AddConnection("A", "C", 10, true);
            graph.AddConnection("A", "D", 14, true);
            graph.AddConnection("A", "E", 21, true);
            graph.AddConnection("B", "C", 9, true);
            graph.AddConnection("B", "E", 10, true);
            graph.AddConnection("B", "F", 14, true);
            graph.AddConnection("C", "D", 9, false);
            graph.AddConnection("D", "G", 10, false);
            graph.AddConnection("E", "H", 11, true);
            graph.AddConnection("F", "C", 10, false);
            graph.AddConnection("F", "H", 10, true);
            graph.AddConnection("F", "I", 9, true);
            graph.AddConnection("G", "F", 8, false);
            graph.AddConnection("G", "I", 9, true);
            graph.AddConnection("H", "J", 9, true);
            graph.AddConnection("I", "J", 10, true);


            Console.WriteLine(graph.ToString());
        }
    }
}
