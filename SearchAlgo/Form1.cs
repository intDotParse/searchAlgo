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
        public Graph mygraph;
        public int counter;
        public void drawVertex(int posx, int posy, string label)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = pictureBox1.CreateGraphics();
            Brush blue;
            
             blue = Brushes.Green;
           

            Font myFont = new Font("Arial", 8, FontStyle.Bold);
            g.FillEllipse(blue, posx - 10, posy - 10, 20, 20);
            g.DrawString(label, myFont, Brushes.White, new Point(posx - 7, posy - 6));
        }
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            mygraph = new Graph();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
            drawVertex(e.X,e.Y,counter.ToString());

            mygraph.addNode(counter, e.X, e.Y);
            comboBox1.Items.Add(counter.ToString());
            comboBox2.Items.Add(counter.ToString());
            comboBox3.Items.Add(counter.ToString());
            counter++;

        }

        private void btnAddNeigbor_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox1.SelectedItem.ToString());
            int nodeId = int.Parse(comboBox1.SelectedItem.ToString());
            //MessageBox.Show(nodeId.ToString());
            int NeigborNodeId = int.Parse(comboBox2.SelectedItem.ToString());
            mygraph.setNeigbor(nodeId, NeigborNodeId);
        }

        private void btnShowNeigbors_Click(object sender, EventArgs e)
        {
            int nodeId = int.Parse(comboBox3.SelectedItem.ToString());
            List<Node> neigbors = mygraph.getNeigbor(nodeId);
            foreach (var item in neigbors) 
            {
                MessageBox.Show(item.getNodeId().ToString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Astar a = new Astar(mygraph,new Node(2,250,250),new Node(1,50,50));
        }
    }
}
