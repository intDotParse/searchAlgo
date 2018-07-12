using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgo
{
    class Graph
    {
        public List<Node> nodes = new List<Node>();
        public Graph(List<Node> nodes)
        {
            this.nodes = nodes;
        }


    }
    class Node
    {
        private int nodeId;
        private int x;
        private int y;
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
        
    }
}
