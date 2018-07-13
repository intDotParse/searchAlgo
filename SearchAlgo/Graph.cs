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
        public bool containsNeigbor(Node node)
        {
            return nodes.Contains(node);
        }
       

    }
    
}
