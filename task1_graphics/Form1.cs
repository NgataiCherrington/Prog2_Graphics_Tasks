﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1_graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Top += 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Left += 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox3.Top += 10;
            pictureBox3.Left -= 10;
        }
    }
}
