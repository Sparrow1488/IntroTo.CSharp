using System;
using System.Drawing;
using System.Windows.Forms;
using NewsBlog_review.UserControls;

namespace NewsBlog_review.AllForms
{
    public partial class EditMyProfile : Form
    {
        public EditMyProfile()
        {
            InitializeComponent();
            button2.Enabled = false;
            button5.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyUser<Label>.ActiveUser.Description = enterDescriptionTextBox.Text;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyUser<Label>.ActiveUser.Avatar = editMyAvatarPanel.BackgroundImage;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                editMyAvatarPanel.BackgroundImage = new Bitmap(openFileDialog1.FileName);
                button2.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                editMyProfileHatImage.BackgroundImage = new Bitmap(openFileDialog1.FileName);
                button5.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MyUser<Label>.ActiveUser.HatImage = editMyProfileHatImage.BackgroundImage;
            button5.Enabled = false;
        }

        private void EditMyProfile_Load(object sender, EventArgs e)
        {
            enterDescriptionTextBox.Text = MyUser<Label>.ActiveUser.Description;
            editMyAvatarPanel.BackgroundImage = MyUser<Label>.ActiveUser.Avatar;
            editMyProfileHatImage.BackgroundImage = MyUser<Label>.ActiveUser.HatImage;
        }
    }
}
