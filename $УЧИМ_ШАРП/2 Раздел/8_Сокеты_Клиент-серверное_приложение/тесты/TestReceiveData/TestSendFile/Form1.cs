using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace TestSendFile
{
    public partial class Form1 : Form
    {
        private string filePath = "testFile.txt";
        private IPEndPoint endPoint;
        private Socket socket;
        public Form1()
        {
            InitializeComponent();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {

        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
