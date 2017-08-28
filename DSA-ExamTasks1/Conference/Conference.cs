using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference
{
    public class Conference
    {
        public static void Main(string[] args)
        {
            int[] props = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numberOfAttendees = props[0];
            int numberOfPairs = props[1];

            Dictionary<int, HashSet<int>> graph = new Dictionary<int, HashSet<int>>();

            for (int i = 0; i < numberOfPairs; i++)
            {
                int[] pairMembers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int first = pairMembers[0];
                int second = pairMembers[1];

                if (!graph.ContainsKey(first))
                {
                    graph[first] = new HashSet<int>();
                }

                if (!graph.ContainsKey(second))
                {
                    graph[second] = new HashSet<int>();
                }

                graph[first].Add(second);
                graph[second].Add(first);
            }

            bool[] visited = new bool[numberOfAttendees];
            List<int> companiesCount = new List<int>();

            foreach (var key in graph.Keys)
            {
                if (!visited[key])
                {
                    //companiesCount.Add(DFS(key, graph, visited));
                    companiesCount.Add(BFS(visited, graph, key));

                }
            }

            //Console.WriteLine(string.Join(",",companiesCount));

            long result = 0;
            long singles = numberOfAttendees - graph.Keys.Count;

            for (int i = 0; i < companiesCount.Count - 1; i++)
            {
                for (int k = i + 1; k < companiesCount.Count; k++)
                {
                    result += companiesCount[i] * companiesCount[k];
                }
            }

            for (int i = 0; i < companiesCount.Count; i++)
            {
                result += singles * companiesCount[i];
            }

            if (singles > 0)
            {
                result += singles * (singles - 1) / 2;
            }

            Console.WriteLine(result);
        }

        public static int DFS(int start, Dictionary<int, HashSet<int>> graph, bool[] visited)
        {
            int result = 0;
            if (!visited[start])
            {
                result++;
                visited[start] = true;
                var successors = graph[start];
                foreach (int successor in successors)
                {
                    result += DFS(successor, graph, visited);
                }
            }

            return result;
        }

        public static int BFS(bool[] visited, Dictionary<int, HashSet<int>> graph, int start)
        {
            int resultBFS = 0;
            var nodes = new Queue<int>();
            nodes.Enqueue(start);
            visited[start] = true;
            resultBFS++;

            while (nodes.Count != 0)
            {
                int currentNode = nodes.Dequeue();
                var successors = graph[currentNode];

                foreach (var successor in successors)
                {
                    if (!visited[successor])
                    {
                        nodes.Enqueue(successor);
                        visited[successor] = true;
                        resultBFS++;

                    }
                }
            }

            return resultBFS;
        }

    }
}
