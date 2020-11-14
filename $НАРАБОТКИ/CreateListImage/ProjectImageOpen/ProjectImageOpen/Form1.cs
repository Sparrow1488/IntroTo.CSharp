using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectImageOpen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Image> images = new List<Image>();
        int indexCounter = 1;
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = $"{images.Count}";
            images.Add(pictureBox1.Image);
            pictureBox2.Image = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = $"{images.Count}";
            if (indexCounter <= images.Count && indexCounter != 1)
            {
                indexCounter--;
                pictureBox1.Image = images[indexCounter - 1];
                label2.Text = $"{indexCounter}";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = $"{images.Count}";
            if (indexCounter < images.Count && indexCounter != 0)
            {
                indexCounter++;
                label2.Text = $"{indexCounter}";
                pictureBox1.Image = images[indexCounter - 1];
            }
        }
    }
}
