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
        private int X = 0; 
        private int Y = 0; 
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
                    this.Height = 20;
                }
            }
            else
            {
                label2.Visible = true; //пердит ошибкой
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            X = e.X; Y = e.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + (e.X - X), this.Location.Y + (e.Y - Y));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
