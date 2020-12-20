using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AsyncThreadWork
{
    public partial class Form1 : Form
    {
        static object locker = new object();
        public static string path = "testFile111.txt";
        public Form1()
        {
            InitializeComponent();
        }

        string writeText = "";

        private void button1_Click(object sender, EventArgs e)
        {
            WriteFile(path);
        }
        public async Task WriteFile(string path)
        {
            button4.Enabled = false;
            await Task.Run(()=> {
                Random rnd = new Random();
                lock (locker)
                {
                    for (int i = 0; i < 20; i++)
                    {
                        writeText += $"{rnd.Next(0,10)} ";
                        Thread.Sleep(100);
                    }
                    using (var sw = new StreamWriter(path, false, Encoding.UTF8))
                    {
                        sw.WriteLine(writeText);
                    }
                }
            });
            button4.Enabled = true;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button4.Enabled = false;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ReadFile(path);
        }
        private void ReadFile(string path)
        {
            using (var sr = new StreamReader(path))
            {
                textBox1.Text = sr.ReadToEnd();
            }
        }
    }
}
