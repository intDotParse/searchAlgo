﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgo
{
    class Graph
    {
        public Node node;
        public Graph()
        {

        }
    }
    class Node
    {
        private int nodeId;
        private int x;
        private int y;
        public Node(int nodeId, int x, int y)
        {
            this.name = nodeId;
            this.x = x;
            this.y = y;
        }
        
    }
}