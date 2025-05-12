using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog2_graphics_tasks
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        int count = 0;
        public Form1()
        {
            InitializeComponent();

            graphics = CreateGraphics();

            label1.Text = "0";

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;

            label1.Text = count.ToString();
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            graphics.DrawLine(Pens.Red, new Point(10, 10), new Point(20, 20));

            graphics.DrawRectangle(Pens.Red, new Rectangle(10, 20, 100, 50));

            graphics.FillRectangle(Brushes.Red, new Rectangle(10, 20, 100, 50));

            Font font = new Font("Consolas", 55, FontStyle.Italic);

            graphics.DrawString("Hello, World!", font, Brushes.SkyBlue, new Point(20, 45));
        }
    }
}
