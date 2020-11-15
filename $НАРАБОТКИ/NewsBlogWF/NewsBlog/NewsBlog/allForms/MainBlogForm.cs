using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewsBlog.autorizationDir;

namespace NewsBlog
{
    public partial class MainBlogForm : Form
    {
        public MainBlogForm()
        {
            InitializeComponent();
            News.setStandartNews();
            News.PrintNews(label1, textBox1);
            label3.Text = $"{News.NewsDB.GetLength(0)}, {News.NewsDB.GetLength(1)}";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            News.ScrollNewsRight(label1, textBox1);
            label3.Text = $"{News.indexCounter}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            News.ScrollNewsLeft(label1, textBox1);
            label3.Text = $"{News.indexCounter}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = $"{News.indexCounter}";
            News.indexCounter = News.NewsDB.GetLength(0) - 1;
            News.PrintNews(label1, textBox1);
        }

        private void MainBlogForm_Load(object sender, EventArgs e)
        {
            if (Autorization.loginCreator)
            {
                addNewsButton1.Enabled = true;
                addNewsButton1.Visible = true;
            }
            //News.setStandartNews();
        }

        private void addNewsButton1_Click(object sender, EventArgs e)
        {
            AddNewsForm addNewsForm = new AddNewsForm();
            addNewsForm.ShowDialog();
        }
    }
}
