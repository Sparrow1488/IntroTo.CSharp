using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.White;
            try
            {
                listBox1.Items.Clear();

                //создаем объект от класса DirectoryInfo, который находится в textBox1.Text
                DirectoryInfo dir = new DirectoryInfo(textBox1.Text);

                //создаем массив объектов (получаем все директории из пути в textBox1.Text)
                DirectoryInfo[] dirs = dir.GetDirectories();

                //перебираем массив объектов и добавляем в элементы в listBox1
                foreach (DirectoryInfo errDir in dirs)
                {
                    listBox1.Items.Add(errDir);
                }

                FileInfo[] files = dir.GetFiles();

                foreach (FileInfo crrfile in files)
                {
                    listBox1.Items.Add(crrfile);
                }
            }
            catch (Exception)
            {
                label1.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url = Path.Combine(textBox1.Text,textBox2.Text);
            Directory.CreateDirectory(url);

            label1.BackColor = Color.White;
            try
            {
                listBox1.Items.Clear();

                DirectoryInfo dir = new DirectoryInfo(textBox1.Text);

                DirectoryInfo[] dirs = dir.GetDirectories();

                foreach (DirectoryInfo errDir in dirs)
                {
                    listBox1.Items.Add(errDir);
                }
            }
            catch (Exception)
            {
                label1.BackColor = Color.Red;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label1.BackColor = Color.White;
            try
            {
                textBox1.Text = Path.Combine(textBox1.Text, listBox1.SelectedItem.ToString());

                listBox1.Items.Clear();

                DirectoryInfo dir = new DirectoryInfo(textBox1.Text);

                DirectoryInfo[] dirs = dir.GetDirectories();

                foreach (DirectoryInfo errDir in dirs)
                {
                    listBox1.Items.Add(errDir);
                }

                FileInfo[] files = dir.GetFiles();

                foreach (FileInfo crrfile in files)
                {
                    listBox1.Items.Add(crrfile);
                }
            }
            catch (Exception)
            {
                label1.BackColor = Color.Red;
            }
        }
    }
    
}
