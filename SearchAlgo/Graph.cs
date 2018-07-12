using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgo
{
    public class Graph
    {
        public List<Node> nodes = new List<Node>();
        public void addNode(int nodeId, int x, int y, double cost = 0)
        {
            nodes.Add(new Node(nodeId, x, y));
        }
        public bool setNeigbor(int nodeId,int neighborNodeId)
        {
            //check if nodeId Exist
            foreach (var node in nodes)
            {
                if (node.getNodeId() == nodeId)
                {
                    foreach(var Inode in nodes)
                    {
                        if (Inode.getNodeId() == neighborNodeId)
                        {
                            node.setNeighbors(Inode);
                            Inode.setNeighbors(node);
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public List<Node> getNeigbor(int nodeId)
        {
            foreach(var node in nodes)
            {
                if(node.getNodeId() == nodeId)
                {
                    return node.getAllNeigbors();
                }
            }
            return null;
            
        }

    }
    public class Node
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
