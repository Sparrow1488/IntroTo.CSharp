using System;
using System.IO;
using System.Diagnostics;
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string url = Path.Combine(textBox1.Text, textBox2.Text);
                Directory.CreateDirectory(url);

                label1.BackColor = Color.White;
                listBox1.Items.Clear();

                DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo errDir in dirs)
                {
                    listBox1.Items.Add(errDir);
                }

                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    listBox1.Items.Add(file);
                }
            }
            catch (Exception)
            {
                label1.BackColor = Color.Red;
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //получаем корень папки из указанного пути
                string url = Path.Combine(textBox1.Text);
                textBox1.Text = Directory.GetParent(url).ToString();

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

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            try
            {
                string url = Path.Combine(textBox1.Text);
                string sUrl = Path.Combine(textBox1.Text, listBox1.SelectedItem.ToString());

                Directory.Delete(sUrl);
                File.Delete(sUrl);
            }
            catch (Exception)
            {
                label1.BackColor = Color.Red;
            }

            try
            {
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string str = listBox1.SelectedItem.ToString();
        }

    }
}
