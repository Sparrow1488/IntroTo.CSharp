using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AsyncThreadWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string writeText = "";

        private void button1_Click(object sender, EventArgs e)
        {
            WriteFile("testOperation1.txt");
        }
        public async Task WriteFile(string path)
        {
            await Task.Run(() => {
                using (var sw = new StreamWriter(path, false, Encoding.UTF8))
                {
                    timer2.Enabled = true;
                    timer2.Interval = 100;
                    sw.WriteLine(writeText);
                }
            });
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        int count = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            MethodProgressBar();
            count++;
            label2.Text = $"{count}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReadFile("testOperation1.txt");
        }
        private async Task ReadFile(string path)
        {
            await Task.Run(() => {
                using (var sr = new StreamReader(path))
                {
                    textBox1.Text = sr.ReadToEnd();
                }
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WriteFile("testOperation2.txt");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReadFile("testOperation2.txt");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            var rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                writeText += $"{rnd.Next()} ";
            }
        }

        public async void MethodProgressBar()
        {
            await Task.Run(() => {
                while (progressBar1.Value != 100)
                    progressBar1.Value++;
                label2.Text = "complete";
            });
        }
    }
}
