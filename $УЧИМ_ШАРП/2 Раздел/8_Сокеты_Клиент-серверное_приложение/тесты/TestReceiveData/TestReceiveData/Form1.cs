using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace TestReceiveData
{
    public partial class Form1 : Form
    {
        private static UdpClient myClient = new UdpClient(8080);//SEND DATA ON THIS PORT
        private string getData = null;

        public Form1()
        {
            InitializeComponent();
        }
        private void recv(IAsyncResult res)
        {
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Any, 9000);
            byte[] received = myClient.EndReceive(res, ref remoteIP);
            getData = Encoding.ASCII.GetString(received);

            //MethodInvoket - делегат, в котором мы можем просто указать любой метода / действие
            Invoke(new MethodInvoker(delegate
            {
                richTextBox1.Text += $"\nReceived data: {getData}";
            }));
            myClient.BeginReceive(new AsyncCallback(recv), null); //AsyncCallback - делегат, ссылается на метод, который должен вызываться при завершении соответствующей асинхронной операции.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                myClient.BeginReceive(new AsyncCallback(recv), null);
                //BeginReceive - асинхронный прием данных
                //Receive - прием данных
            }
            catch (Exception ex)
            {
                richTextBox1.Text += $"\n{ex.Message}";
            }
        }
    }
}
