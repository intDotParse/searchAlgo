using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgo
{
    public class Node
    {
        private int nodeId;
        public int x;
        public int y;
        public double f;
        public double g;
        public double h;
        private double nodeCost;
        private List<Node> neighbors = new List<Node>();
        public Node(int nodeId, int x, int y)
        {
            this.nodeId = nodeId;
            this.x = x;
            this.y = y;
        }
        public int getNodeId()
        {
            return this.nodeId;
        }
        public void setNeighbors(Node neighbor)
        {
            neighbors.Add(neighbor);
        }
        public List<Node> getAllNeigbors()
        {
            return neighbors;
        }
        public void setNodeCost(double cost)
        {
            this.nodeCost = cost;
        }

    }
}
