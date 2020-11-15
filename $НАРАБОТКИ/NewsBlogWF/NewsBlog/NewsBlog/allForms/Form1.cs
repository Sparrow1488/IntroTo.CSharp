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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            bool log_in = Autorization.CheckUsers(textBox1, textBox2);
            if (log_in)
            {
                MainBlogForm mainBlog = new MainBlogForm();
                bool loginCreator = Autorization.CheckCreators(textBox1, textBox2);
                if (loginCreator)
                {
                    //label3.Text = "Админ";
                    mainBlog.Show();
                    this.Height = 0;
                }
                else
                {
                    //label3.Text = "Простой пользователь";
                    mainBlog.Show();
                    this.Height = 0;
                }
            }
            else
            {
                label2.Visible = true; //пердит ошибкой
            }
        }
    }
}
