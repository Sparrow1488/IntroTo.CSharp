using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auturization
{
    public partial class AddNewsDialog : Form
    {
         
        public AddNewsDialog()
        {
            InitializeComponent();
            MainBlog mainBlog = new MainBlog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainBlog mainBlog = new MainBlog();
            //News.AddNews(, , textBox1.Text, textBox2.Text);
        }
    }
}
