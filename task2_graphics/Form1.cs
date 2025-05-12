using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2_graphics
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Pen blackPen = new Pen(Color.Black, 5);
        public Form1()
        {
            InitializeComponent();

            graphics = CreateGraphics();

            timer1.Enabled = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graphics.DrawLine(Pens.Red, new Point(10, 10), new Point(100, 100));
            graphics.DrawLine(Pens.Red, new Point(100, 10), new Point(10, 100));
        }

        private void button2_Click(object sender, EventArgs e)
        {

            graphics.DrawRectangle(blackPen, new Rectangle(120, 20, 150, 100));
            graphics.FillRectangle(Brushes.Red, new Rectangle(120, 20, 150, 100));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            graphics.DrawEllipse(Pens.Yellow, new Rectangle(120, 200, 200, 100));
            graphics.FillEllipse(Brushes.Blue, new Rectangle(130, 210, 200, 100));
            graphics.FillEllipse(Brushes.Yellow, new Rectangle(120, 200, 200, 100));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Font font = new Font("Consolas", 20, FontStyle.Bold);
            graphics.DrawString("Hi There!!", font, Brushes.Red, new Point(150, 215));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
