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

        public static List<MyButtons> MyButtonsList { get; set; } = new List<MyButtons>()
        {
            new UpButton(),
            new DownButton(),
            new LeftButton(),
            new RightButton()
        };

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char btn = e.KeyChar;
            ActivatedButton(pictureBox1,btn);
        }

        public static void ActivatedButton(PictureBox pb, char btn)
        {
            for (int i = 0; i < MyButtonsList.Count; i++)
            {
                MyButtonsList[i].PressButton(pb, btn);
            }
        }

    }
}
