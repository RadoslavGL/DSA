using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Towns
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var nums = new List<int>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split();
                int num = int.Parse(line[0]);
                nums.Add(num);
            }

            var asnwer = Solve(nums);
            Console.WriteLine(asnwer);
        }

        private static int Solve(List<int> nums)
        {
            //1. max increasing subsequences l-r
            var leftToRight = new int[nums.Count];

            for (int i = 0; i < nums.Count; i++)
            {
                var maxLength = 0;
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        maxLength = Math.Max(maxLength, leftToRight[j]);
                    }

                }

                leftToRight[i] = maxLength + 1;

            }

            //2. max increasing subsequences r-1
            var rightToLeft = new int[nums.Count];

            for (int i = nums.Count - 1; i > -1; i--)
            {
                var maxLength = 0;
                for (int j = nums.Count - 1; j > i; j--)
                {
                    if (nums[j] < nums[i])
                    {
                        maxLength = Math.Max(maxLength, rightToLeft[j]);
                    }
                }
                rightToLeft[i] = maxLength + 1;
            }


            //3. max combined asnwer
            var maxPath = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                var path = leftToRight[i] + rightToLeft[i] - 1;
                maxPath = Math.Max(maxPath, path);
            }

            return maxPath;
        }
    }
}
