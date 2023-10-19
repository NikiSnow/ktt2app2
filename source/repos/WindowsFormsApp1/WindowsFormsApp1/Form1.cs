﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void форма1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void форма2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int randomNumber = r.Next(1, 4);
            int rp = 0;
            do
            {
                randomNumber = r.Next(1, 4);
            } while (randomNumber == rp);
            rp = randomNumber;

            if (randomNumber == 1)
            {
                pictureBox1.Image = Properties.Resources.img1;
            }
            else if (randomNumber == 2)
            {
                pictureBox1.Image = Properties.Resources.img2;
            }
            else if (randomNumber==3)
            {
                pictureBox1.Image = Properties.Resources.img3;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            int randomNumber = r.Next(1, 4);
            if (randomNumber == 1)
            {
                pictureBox1.Image = Properties.Resources.img1;
            }
            else if (randomNumber == 2)
            {
                pictureBox1.Image = Properties.Resources.img2;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.img3;
            }
        }
    }
}