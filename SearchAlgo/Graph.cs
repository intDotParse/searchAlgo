using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgo
{
    class Graph
    {
        public Node[] nodes;
        public Graph()
        {

        }

    }
    class Node
    {
        private int nodeId;
        private int x;
        private int y;
        private Node[] neighbors;
        private int neighborCounter = 0;
        public Node(int nodeId, int x, int y)
        {
            this.name = nodeId;
            this.x = x;
            this.y = y;
        }

        public void setNeighbors(Node neighbor)
        {
            neighbors[neighborCounter] = neighbor;
            neighborCounter++;
        }
        public Node[] getAllNeigbors()
        {
            return neighbors;
        }
        
    }
}
