using System;
using System.Windows.Forms;
using NewsBlog.newsDir;

namespace NewsBlog
{
    public partial class AddNewsForm : Form
    {
        public AddNewsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                var news = new AddNews(textBox1.Text, textBox2.Text);
                this.Close();
            }
            else
            {
                exeptionLabel1.Visible = true;
                exeptionLabel1.Enabled = true;
            }
        }

        private void AddNewsForm_MouseDown(object sender, MouseEventArgs e)
        {
            exeptionLabel1.Visible = false;
            exeptionLabel1.Enabled = false;
        }
    }
}
