using System;
using System.Windows.Forms;
using NewsBlog_review.AllForms;
using NewsBlog_review.UserControls;

namespace NewsBlog_review.AllForms
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            if (textBox1.Text.Length < 4) label1.Visible = true;
            else if (!textBox2.Text.Equals(textBox3.Text)) label1.Visible = true;
            else
            {
                MyUser<Label>.ActiveUser = User.Registration(textBox1.Text, textBox2.Text);
                MainForm mainForm = new MainForm();
                mainForm.Show();
                Hide();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Autorization autorizationForm = new Autorization();
            autorizationForm.Show();
            Close();
        }
    }
}
