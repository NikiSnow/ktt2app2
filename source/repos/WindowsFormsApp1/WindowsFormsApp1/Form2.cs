using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            int randomNumber = r.Next(1, 4);
            if (randomNumber == 1)
            {
                pictureBox1.Image = Properties.Resources.img4;
            }
            else if (randomNumber == 2)
            {
                pictureBox1.Image = Properties.Resources.img5;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.img6;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int randomNumber = r.Next(1, 4);
            if (randomNumber == 1)
            {
                pictureBox1.Image = Properties.Resources.img4;
            }
            else if (randomNumber == 2)
            {
                pictureBox1.Image = Properties.Resources.img5;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.img6;
            }
        }
    }
}
