using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_QueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();

            queue.Enqueue("Message1");
            queue.Enqueue("Message2");
            queue.Enqueue("Message3");
            queue.Enqueue("Message4");
            queue.Enqueue("Message5");
            queue.Enqueue("Message5");

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
