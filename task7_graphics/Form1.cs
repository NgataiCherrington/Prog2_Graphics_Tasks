using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task7_graphics
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Controller controller;

        private Bitmap offScreenBitmap;
        private Graphics offScreenGraphics;

        public Form1()
        {
            InitializeComponent();

            offScreenBitmap = new Bitmap(Width, Height);
            offScreenGraphics = Graphics.FromImage(offScreenBitmap);
            graphics = CreateGraphics();
            controller = new Controller(offScreenGraphics, ClientSize);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            offScreenGraphics.FillRectangle(Brushes.Black, 0, 0, Width, Height);
            controller.Run();
            graphics.DrawImage(offScreenBitmap, 0, 0);
        }
    }
}
