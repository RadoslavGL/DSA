using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02_DictionaryGraph
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var graph = new Dictionary<string, HashSet<string>>();

            string line = Console.ReadLine();
            while (line != string.Empty)
            {
                string[] connection = line.Split();

                string key = connection[0];
                string value = connection[1];

                if (!graph.ContainsKey(key))
                {
                    graph[key] = new HashSet<string>();
                }

                graph[key].Add(value);

                if (key != value)
                {
                    if (!graph.ContainsKey(value))
                    {
                        graph[value] = new HashSet<string>();
                    }

                    graph[value].Add(key);
                }

                line = Console.ReadLine();
            }

            foreach (var node in graph)
            {
                Console.Write(node.Key + " ==> ");

                foreach (var neighbors in node.Value)
                {
                    Console.Write(neighbors + " ");
                }

                Console.WriteLine();
            }

        }
    }
}
