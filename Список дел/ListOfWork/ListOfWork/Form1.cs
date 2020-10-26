using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListOfWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] arr1 = new string[2];

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
            arr1[listBox1.SelectedIndex] = textBox1.Text;
        }
        

        private void listBox1_SelectedItemChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            arr1[listBox1.SelectedIndex + 1] = textBox1.Text;
        }
    }
}
