using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            new Posts.Post(body, title, text)
            {
                postBody = body,
                postTitle = textBox2,
                postText = textBox3
            };
            Posts.Post.ShowPosts(panel1);
        }
    }
}
