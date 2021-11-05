using System;
using System.Windows.Forms;
using NewsBlog_review.UserControls;
using System.Drawing;

namespace NewsBlog_review.AllForms
{
    public partial class MyProfile : Form
    {
        private static int X = 0;
        private static int Y = 0;
        public MyProfile()
        {
            InitializeComponent();
            addNewsButton.Visible = false;
        }

        private void MyProfile_Load(object sender, EventArgs e)
        {
            if (MyUser<Label>.ActiveUser.Access == "Creator")
            {
                addNewsButton.Visible = true;
                panel6.BackColor = Color.Gold;
            }

            MyUser<Label>.PrintMyInformation(loginLabel, passwordLabel, accessLabel, myDescriptionTextBox, avatarPanel, profileHatPanel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void profileHatPanel_MouseDown(object sender, MouseEventArgs e)
        {
            X = e.X; Y = e.Y;
        }

        private void profileHatPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.X - X), this.Location.Y + (e.Y - Y));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditMyProfile editMyProfile = new EditMyProfile();
            editMyProfile.ShowDialog();
        }

        private void accessLabel_Click(object sender, EventArgs e)
        {
            //TODO: СДЕЛАЙ СПРАВКУ
            if (MyUser<Label>.ActiveUser.Access == "Creator") MessageBox.Show("Возможности:\n* добавляет новости\n* редактирует новости");
            if (MyUser<Label>.ActiveUser.Access == "Default") MessageBox.Show("Возможности:\n* вы можете читать новости");
        }

        private void addNewsButton_Click(object sender, EventArgs e)
        {
            AddNewsForm addNewsForm = new AddNewsForm();
            addNewsForm.Show();
        }
    }
}
