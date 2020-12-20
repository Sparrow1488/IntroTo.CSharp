using System;
using System.Drawing;
using System.Windows.Forms;

namespace CreatePosts
{
    public partial class Testfrm : Form
    {
        public Testfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var title = CreateTitlePost($"Это пост номер {panel1.Controls.Count}");
            var bottomStyle = CreateBottomDesign();
            
            var post = CreateBodyPost(bottomStyle, title);
            panel1.Controls.Add(post);
        }
        private static Panel CreateBodyPost(Panel bottomBorder, Label titleText)
        {
            var panel = new Panel();
            panel.Height = bottomBorder.Height + titleText.Height;
            panel.BackColor = Color.Aqua;
            panel.Dock = DockStyle.Top;
            panel.Controls.Add(bottomBorder);
            panel.Controls.Add(titleText);
            return panel;
        }
        private static Label CreateTitlePost(string titleText)
        {
            var title = new Label();
            title.Text = titleText;
            title.Dock = DockStyle.Top;
            title.Height = 20;
            return title;
        }
        private static Panel CreateBottomDesign()
        {
            var bottomBorder = new Panel();
            bottomBorder.Height = 1;
            bottomBorder.BackColor = Color.Black;
            bottomBorder.Dock = DockStyle.Bottom;
            return bottomBorder;
        }

        private void Testfrm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
