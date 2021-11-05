using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MainGame
{
    public partial class GamePanel : Form
    {
        public GamePanel()
        {
            InitializeComponent();
        }

        private void labelCockInfo_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = GetRandomColor();
            label2.BackColor = GetRandomColor();
            label3.BackColor = GetRandomColor();
        }
        private void label3_MouseLeave_1(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            button1.ForeColor = GetRandomColor();
        }

        List<Color> colors = new List<Color>() { Color.BlueViolet, Color.Aqua, Color.Brown, Color.AliceBlue, Color.Olive, Color.Red };
        Color lastColor = Color.Black;
        private Color GetRandomColor()
        {
            Random rndColor = new Random();
            Color colorActive = colors[rndColor.Next(0, colors.Count)];
            while (true)
            {
                if (colorActive.Equals(lastColor))
                {
                    colorActive = colors[rndColor.Next(0, colors.Count)];
                }
                if (!colorActive.Equals(lastColor))
                {
                    lastColor = colorActive;
                    break;
                }
            }
            return colorActive;
        }
    }
}
