using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace StreamWF1
{
    public partial class Form1 : Form
    {
        private string openFilePath = "";
        private string saveFilePath = "";
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
                    openFilePath = openFileDialog1.FileName;
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
            using (var sw = new StreamWriter(openFilePath))
            {
                sw.WriteLine(textBox1.Text);
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog saveFD = new OpenFileDialog();

            //if(saveFD.ShowDialog() == )
            //{
            //    saveFilePath = Path.GetDirectoryName(saveFD.FileName);
            //    textBox1.Text = saveFilePath;
            //}
            
        }
    }
}
