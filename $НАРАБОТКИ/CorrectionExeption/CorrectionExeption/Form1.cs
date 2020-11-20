using CorrectionExeption.myButtonsControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorrectionExeption
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<MyButtons> MyButtonsList { get; protected set; } = new List<MyButtons>() 
        {
            
        };

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char btn = e.KeyChar;
            UpButton btnUp = new UpButton(); MyButtonsList.Add(btnUp);
            DownButton btnDown = new DownButton(); MyButtonsList.Add(btnDown);
            LeftButton btnLeft = new LeftButton(); MyButtonsList.Add(btnLeft);
            label1.Text = $"{pictureBox1.Location.X}, {pictureBox1.Location.Y}"; 
            foreach (var obj in MyButtonsList)
            {
                obj.PressButton(pictureBox1, btn);
            }
            

            //int x = pictureBox1.Location.X;
            //int y = pictureBox1.Location.Y;
            //if (e.KeyChar == 'w')
            //{
            //    y -= 10;
            //    pictureBox1.Location = new Point(x, y);
            //}
            //if (e.KeyChar == 'a')
            //{
            //    x-=10;
            //    pictureBox1.Location = new Point(x, y);
            //}
            //if (e.KeyChar == 's')
            //{
            //    y += 10;
            //    pictureBox1.Location = new Point(x, y);
            //}
            //if (e.KeyChar == 'd')
            //{
            //    x += 10;
            //    pictureBox1.Location = new Point(x, y);
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
