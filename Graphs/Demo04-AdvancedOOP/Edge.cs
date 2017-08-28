using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_AdvancedOOP
{
    public class Edge
    {
        public Edge(Node target, double distance)
        {
            this.Target = target;
            this.Distance = distance;
        }

        public Node Target { get; private set; }

        public double Distance { get; private set; }
    }
}
