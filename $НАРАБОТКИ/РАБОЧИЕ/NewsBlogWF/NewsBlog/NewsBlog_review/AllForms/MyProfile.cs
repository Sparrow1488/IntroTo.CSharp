using System;
using System.Windows.Forms;
using NewsBlog_review.UserControls;

namespace NewsBlog_review.AllForms
{
    public partial class MyProfile : Form
    {
        public MyProfile()
        {
            InitializeComponent();
        }

        private void MyProfile_Load(object sender, EventArgs e)
        {
            loginLabel.Text = MyUser.ActiveUser.Login;
            passwordLabel.Text = MyUser.ActiveUser.Password;
            label1.Text += MyUser.ActiveUser.Access;
        }
    }
}
