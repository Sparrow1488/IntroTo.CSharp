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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = $"{images.Count}";
            foreach (PictureBox pb in Controls.OfType<PictureBox>())
            {
                if (pb.Name == pictureBox1.Name) // главный picBox
                {
                    continue;
                }
                pictureBoxes.Add(pb);
                label3.Text = $"{pictureBoxes.Count}";
            }
        }
        int pbCounter = 0;
        public List<Image> images = new List<Image>();

        public List<PictureBox> pictureBoxes = new List<PictureBox>();
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "ПРЕДПРОСМОТР";
            if (pbCounter < pictureBoxes.Count)
            {
                if (pictureBox1.Image != null && pbCounter <= images.Count)
                {
                    images.Add(pictureBox1.Image);
                    pictureBoxes[pbCounter].Image = pictureBox1.Image;
                    pbCounter++;
                    pictureBox1.Image = null;
                }
                else
                {
                    label3.Text = "ПУСТО";
                }
            }
            else
            { 
                label3.Text = "чел я заполнен";
                button1.Enabled = true; ; 
            }
        }
    }
}
