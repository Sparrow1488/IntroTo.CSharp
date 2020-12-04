using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace StreamWF1
{
    public partial class Form1 : Form
    {
        private string path = "";
        public Form1()
        {
            InitializeComponent();
            TextProperties.textBoxMAIN = this.textBox1;
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (var str = new StreamReader(openFileDialog1.FileName))
                {
                    path = openFileDialog1.FileName;
                    textBox1.Text = str.ReadToEnd();
                    //textBox1.Text = path;
                }
            }
        }

        private void размерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontProperties fontProperties = new FontProperties();
            fontProperties.ShowDialog();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var sw = new StreamWriter("testText1.txt", true))
            {
                sw.WriteLine(textBox1.Text);
            }
        }
    }
}
