using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgo
{
    public class Astar
    {
        public Node start;
        private Graph map = new Graph();
        private Graph closedSet = new Graph();
        private Graph openSet = new Graph();

        public string reconstruct()
        {
            return "reconstructing!";
        }
        public Astar(Graph map, Node start, Node end)
        {
            //compute cost of each node from start to finish
            map.setEveryH(end);
            //add start node to openset
            start.g = 0;
            openSet.addNode(start);
            while(openSet.count() >0)
            {
                Node current = openSet.getLowestFScore();
                if(current == end)
                {
                    reconstruct();
                }
                openSet.removeNode(current);
                closedSet.addNode(current);

                foreach (var neigbor in current.getAllNeigbors())
                {
                    if (closedSet.containsNeigbor(neigbor))
                    {
                        continue;
                    }
                    double tentativeGScore = current.g + map.heuristic(current, neigbor);

                    if (!openSet.containsNeigbor(neigbor))
                    {
                        openSet.addNode(neigbor);
                    }
                    else if(tentativeGScore >= neigbor.g)
                    {
                        continue;
                    }
                    neigbor.cameFrom = current;
                    neigbor.g = tentativeGScore;
                    neigbor.f = neigbor.g + neigbor.h;


                }
            }

            









            //var a = new HashSet<Node>();
            //var closedset = new HashSet<Node>();
            //var openset = new PriorityQueue<Node>();
            //openset.Enqueue(start, 0);

            //cameFrom[start] = start;
            //costSoFar[start] = 0;

            //while(openset.Count > 0)
            //{
            //    var current = openset.Dequeue();
            //    if (!closedset.Contains(current))
            //    {
            //        a.Add(current);
            //    }
            //    if (current.Equals(end))
            //    {
            //        break;
            //    }
            //    foreach (var next in map.getNeigbor(current.getNodeId()))
            //    {
            //        //int newCost=costSoFar[current]+map.wit
            //    }
            //}


        }
        public void  trace()
        {
            

           
           
        }
    }
      public class PriorityQueue<T>
        {
            private List<Tuple<T, double>> elements = new List<Tuple<T, double>>();

            public int Count
            {
                get { return elements.Count; }
            }

            public void Enqueue(T item, double priority)
            {
                elements.Add(Tuple.Create(item, priority));
            }

            public T Dequeue()
            {
                int bestIndex = 0;

                for (int i = 0; i < elements.Count; i++)
                {
                    if (elements[i].Item2 < elements[bestIndex].Item2)
                    {
                        bestIndex = i;
                    }
                }

                T bestItem = elements[bestIndex].Item1;
                elements.RemoveAt(bestIndex);
                return bestItem;
            }
        }
}
