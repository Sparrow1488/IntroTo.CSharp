using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CorrectionExeption.myButtonsControl;

namespace CorrectionExeption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char enterButton = e.KeyChar;
            for (int i = 0; i < MyButtons.myButtons.Count; i++)
            {
                MyButtons.myButtons[i].PressButton(pictureBox1, enterButton);
            }
        }
    }
}
