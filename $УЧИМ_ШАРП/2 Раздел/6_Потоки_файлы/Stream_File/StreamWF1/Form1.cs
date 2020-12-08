using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Text;

namespace StreamWF1
{
    public partial class Form1 : Form
    {
        private string openFilePath;
        private string saveFilePath;
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
                    ActiveForm.Text = openFilePath;
                    textBox1.Text = str.ReadToEnd();
                }
            }
        }

        private void размерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontProperties fontProperties = new FontProperties();
            fontProperties.ShowDialog();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var sw = new StreamWriter(openFilePath, false, Encoding.UTF8))
                {
                    sw.WriteLine(textBox1.Text);
                }
            }
            catch (ArgumentNullException) 
            {
                MessageBox.Show("Вы не выбрали куда сохранять!", "Что то пошло не так...", MessageBoxButtons.OK);
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFD = new SaveFileDialog();
            saveFD.Filter = "txt files (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                saveFilePath = saveFD.FileName;
                using (var sf = new StreamWriter(saveFilePath))
                {
                    openFilePath = saveFilePath;
                    ActiveForm.Text = openFilePath;
                    sf.WriteLine(textBox1.Text);
                }
            }
        }
    }
}
