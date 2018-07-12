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
        public Node mynodes;
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
            counter++;
            mynodes = new Node(counter, e.X, e.Y);

        }
    }
}
