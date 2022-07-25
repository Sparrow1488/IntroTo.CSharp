using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace TestClientSendFile
{
    public partial class Form1 : Form
    {
        private Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private IPEndPoint serverEndPoint;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
