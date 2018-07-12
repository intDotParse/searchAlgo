using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SearchAlgo;

namespace SearchAlgo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Node node1 = new Node(1, 20, 20);
            Node node2 = new Node(2, 160, 20);
            Node node3 = new Node(3, 220, 120);
            Node node4= new Node(4, 520, 220);

            node1.setNeighbors(node2);
            node2.setNeighbors(node3);
            node2.setNeighbors(node4);

            List<Node> neighborsNode2 = node2.getAllNeigbors();

            foreach (var neigbor in neighborsNode2)
            {
                MessageBox.Show(neigbor.getNodeId().ToString());
            }


        }
    }
}
