using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Space
{
    public class OfficeSpace
    {
        //for memoization - we still store here the already calculated times = own time + dependency time
        static int[] asnwers = new int[50]; 

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var minutesPerTask = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int>[] dependencies = new List<int>[n];

            for (int i = 0; i < n; i++)
            {
                dependencies[i] = Console.ReadLine().Split().Select(x => int.Parse(x) - 1).ToList();
            }

            for (int i = 0; i < n; i++)
            {
                asnwers[i] = CalculateMinTime(i, minutesPerTask, dependencies);
            }
            Console.WriteLine(asnwers.Max());
            //Console.WriteLine(string.Join(", ",asnwers));
        }

        //calculated each task's time based on the time the tasks on which it depends

        static int CalculateMinTime(int taskId, int[] minutesPerTask, List<int>[] dependencies)
        {

            //from the memoization
            if (asnwers[taskId] != 0)
            {
                return asnwers[taskId];
            }

            //var currentTaskDependencies = dependencies[taskId];
            if (dependencies[taskId].Count == 1 && dependencies[taskId][0] == -1)
            {
                return minutesPerTask[taskId];
            }

            //we take max dependencyTime, because it gives us the time it will take for all dependant tasks to finish

            var maxDependencyTime = 0;

            foreach (int dependencyID in dependencies[taskId])
            {

                var dependencyTime = CalculateMinTime(dependencyID, minutesPerTask, dependencies);

                maxDependencyTime = Math.Max(dependencyTime, maxDependencyTime);
            }

            asnwers[taskId] = minutesPerTask[taskId] + maxDependencyTime;

            return asnwers[taskId];

        }
    }
}
