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
                MyUser.ActiveUser = User.Autorization(textBox1.Text, textBox2.Text);
                mainForm.Show();
                this.Hide();
            }
        }
    }
}
