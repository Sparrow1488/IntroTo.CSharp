using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientWF
{
    public partial class ClientForm : Form
    {
        delegate void Del();

        private Client client;
        public ClientForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            client.CreateSocket();
            client.SendMessage(textBox1.Text);
            
        }

        private async void ClientForm_Load(object sender, EventArgs e)
        {
            client = new Client("127.0.0.3", 8090);
            listBox1.Invoke(new Action(StreamText));
        }
        private async void StreamText()
        {
            await Task.Run(() =>
            {
                int timer = 0;
                while (true)
                {
                    timer++;
                    Thread.Sleep(1000);
                    listBox1.Items.Add(timer.ToString());
                }

            });
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
