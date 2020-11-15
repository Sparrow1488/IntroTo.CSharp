using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            bool checkNews = News.AddNews(textBox1, textBox2, label1);
            if (checkNews)
            {
                this.Close();
            }
        }
    }
}
