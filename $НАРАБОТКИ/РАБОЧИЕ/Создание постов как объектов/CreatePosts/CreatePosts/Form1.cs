using System;
using CreatePosts.Posts;
using System.Windows.Forms;
using System.Drawing;

namespace CreatePosts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var body = new Panel();
            var title = new TextBox();
            var text = new TextBox();
            new Post(body, title, text)
            {
                postBody = body,
                postTitle = title,
                titleText = textBox1.Text,
                postText = text,
                text = textBox2.Text
            };
            Post.ShowAllPosts(mainPanel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int right = 50;

            // Create Image + Text
            PictureBox pbox = new PictureBox();
            pbox.Size = new Size(140, 80);
            pbox.Location = new Point(right, 0);
            pbox.BackColor = Color.Black;

            // Create label
            Label lblPlateNOBAR = new Label();
            lblPlateNOBAR.Text = textBox1.Text;
            lblPlateNOBAR.Location = new Point(right + 20, 80);

            mainPanel.Controls.Add(pbox);
            mainPanel.Controls.Add(lblPlateNOBAR);
        }
    }
}
