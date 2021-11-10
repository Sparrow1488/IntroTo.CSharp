using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamWF1
{
    public partial class FontProperties : Form
    {
        int newHeight = 10;
        string newFontStyle = "Microsoft Tai Le";
        public FontProperties()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            newHeight = int.Parse(listBox1.SelectedItem.ToString());
            textBox1.Font = new Font(newFontStyle, newHeight); 
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            newFontStyle = listBox2.SelectedItem.ToString();
            textBox1.Font = new Font(newFontStyle, newHeight);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextProperties.fontHeight = newHeight;
            TextProperties.fontStyle = newFontStyle;
            TextProperties.textBoxMAIN.Font = new Font(TextProperties.fontStyle, TextProperties.fontHeight);
            Close();
        }

        private void FontProperties_Load(object sender, EventArgs e)
        {
            textBox1.Font = new Font(TextProperties.fontStyle, TextProperties.fontHeight);
        }
    }
}
