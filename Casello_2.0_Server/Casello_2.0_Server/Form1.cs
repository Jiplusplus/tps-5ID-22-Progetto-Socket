using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Casello_2._0_Server
{
    public partial class Form1 : Form
    {
        byte[] bytes = new Byte[1024];
        byte[] msg;
        IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
        public string data = null;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void start_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(startListening));
            t.Start();
        }

        public void startListening()
        {
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 5000);
            Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                while (true)
                {
                    MessageBox.Show("Waiting for a connection...");
                    Socket handler = listener.Accept();
                    //Random r = new Random();
                    //int n = r.Next(1, 10);
                    //richieste.Items.Add("Numero generato : " + n.ToString());
                    citta.Text = "Bergamo";
                    costo.Text = "5.5";
                }
            }
            catch (Exception e)
            {
                richieste.Items.Add(e.ToString());
            }
        }
    }
}

