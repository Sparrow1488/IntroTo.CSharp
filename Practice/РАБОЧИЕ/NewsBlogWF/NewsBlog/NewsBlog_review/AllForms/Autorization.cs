using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewsBlog_review.UserControls;
using NewsBlog_review.AllForms;

namespace NewsBlog_review
{
    public partial class Autorization : Form
    {
        private static int X = 0;
        private static int Y = 0;
        MainForm mainForm = new MainForm();
        public static void AddUsers()
        {
            new DefaultUser("User", "1234");
        }
        public static void AddCreators()
        {
            new CreatorUser("Sparrow", "1234");
        }
        public Autorization()
        {
            InitializeComponent();
            AddUsers();
            AddCreators();
        }
        private void logInButton_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            if (User.Autorization(textBox1.Text, textBox2.Text) == null) label1.Visible = true;
            else
            {
                MyUser<Label>.ActiveUser = User.Autorization(textBox1.Text, textBox2.Text);
                mainForm.Show();
                Hide();
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            X = e.X; Y = e.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.X - X), this.Location.Y + (e.Y - Y));
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registrationForm = new Registration();
            registrationForm.Show();
            Hide();
        }

        private void Autorization_Load(object sender, EventArgs e)
        {
            
        }
    }
}
