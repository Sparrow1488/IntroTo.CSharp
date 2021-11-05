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
    public partial class MainBlog : Form
    {
        public MainBlog()
        {
            InitializeComponent();
            AddNewsDialog addNewsDialog = new AddNewsDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //News.AddNews();
        }

        private void postToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewsDialog addNewsDialog = new AddNewsDialog();
            addNewsDialog.ShowDialog();
        }
    }
}
