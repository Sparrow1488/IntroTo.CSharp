using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWork2
{
    public partial class Form1 : Form
    {
        string text = "";
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        void button1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer2.Interval = 1000;
        }

        public async Task<string> WriteString()
        {
            await Task.Run(() => {
                text = "123";
            });

            return text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = count.ToString() + " ";
            count++;
        }
    }
}
