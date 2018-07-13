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
        public void addNode(Node node)
        {
            nodes.Add(new Node(node.getNodeId(),node.x,node.y));
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
        public Node getNodeById(int nodeId)
        {
            foreach (var item in nodes)
            {
                if (item.getNodeId() == nodeId)
                {
                    return item;
                }
            }
            return null;
        }
        public bool containsNeigbor(Node node)
        {
            return nodes.Contains(node);
        }
        public List<Node> setEveryH(Node end)
        {
            foreach (var node in nodes)
            {
                node.h = heuristic(node,end);
            }
            return nodes;
        }
       
        public double heuristic(Node a, Node b)
        {
            double dx = a.x - b.x;
            double dy = a.y - b.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        //public List<Node> getLowestFScoreValue(Node a)
        //{
        //    List<Node> neigbors = getNeigbor(a.getNodeId());
            
        //}
        public int count()
        {
            return nodes.Count;
        }
        public Node getLowestFScore()
        {
            Node[] arrayNode = new Node[this.count()];
            int counter = 0;
            foreach (var item in nodes)
            {
                arrayNode[counter] = item;
            }
            for (int i = 0; i < arrayNode.Length; i++)
            {
                Node temp;
                if(!(arrayNode.Count() == 1))
                {
                    if(arrayNode[i].f > arrayNode[i + 1].f)
                    {
                        temp = arrayNode[i];
                        arrayNode[i] = arrayNode[i + 1];
                        arrayNode[i + 1] = temp;
                    }
                }
                
            }
            return arrayNode[0];
        }
        public void removeNode(Node n)
        {
            foreach (var item in nodes)
            {
                if(n.getNodeId() == item.getNodeId())
                {
                    nodes.RemoveAt(item.getNodeId());
                }
            }
        }
    }
    
}
