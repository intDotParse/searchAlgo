using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgo
{
    public class Astar
    {
        private int start;
        private int end;
        private Graph map = new Graph();
        private List<Graph> closedSet =new List<Graph>();
        private List<Graph> openSet = new List<Graph>();
        private List<Graph> cameFrom = new List<Graph>();
        public Astar(Graph map, int start, int end)
        {
            this.start = start;
            this.end = end;
            this.map = map;
            trace();
        }
        public string trace()
        {
            //compute cost of each node from start to finish
           List<Node> list= map.setCostEveryNodeHeuristic(end);
            string cost = "";
            foreach (var item in list)
            {
                cost += "Node: " + item.getNodeId() + "---->" + item.h + "\n";
            }
            return cost;
        }

    }
}
