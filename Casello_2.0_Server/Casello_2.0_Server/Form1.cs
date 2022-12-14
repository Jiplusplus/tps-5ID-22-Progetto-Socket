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
                    //MessageBox.Show("Waiting for a connection...");
                    Socket handler = listener.Accept();
                    ClientManager clientThread = new ClientManager(handler, ref richieste, ref costo, ref sem_verde);
                    Thread t = new Thread(new ThreadStart(clientThread.doClient));
                    t.Start();
                    //MessageBox.Show(clientThread.Messaggio);
                    citta.Text = "Bergamo";
                    costo.Text = "50";
                }
            }
            catch (Exception e)
            {
                richieste.Items.Add(e.ToString());
                
            }
        }
    }

    public class ClientManager
    {

        Socket clientSocket;
        byte[] bytes = new Byte[1024];
        String data = "";
        String data_card = "";
        ListBox richieste;
        TextBox costo;
        Panel verde;

        public ClientManager(Socket clientSocket, ref ListBox richieste, ref TextBox costo, ref Panel verde)
        {
            this.clientSocket = clientSocket;
            this.richieste = richieste;
            this.costo = costo;
            this.verde = verde;
        }

        public void doClient()
        {

            while (true)
            { 
                data = "";
                while (data.IndexOf("$") == -1)
                {
                    int bytesRec = clientSocket.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                }
                richieste.Items.Add("Hai pagato: " + data.Substring(0, data.Length - 1) + " Euro");
                int CostoTot = int.Parse(costo.Text);
                int DataTot = int.Parse(data.Substring(0, data.Length - 1));
                int differenza = CostoTot - DataTot;
                if(differenza == 0)
                {
                    Random Random = new Random();
                    richieste.Items.Add("Pagamento effetuato, buon viaggio");
                    costo.Text = Random.Next(10, 50).ToString();
                    DataTot = differenza;
                    verde.BackColor = Color.Green;
                    byte[] msg = Encoding.ASCII.GetBytes(DataTot.ToString() + "$");
                    clientSocket.Send(msg);
                }
                else
                {
                    richieste.Items.Add("Hai ancora da pagare: " + differenza + " Euro");
                    costo.Text = differenza.ToString();
                    DataTot = differenza;
                    verde.BackColor = Color.Red;
                    byte[] msg = Encoding.ASCII.GetBytes(DataTot.ToString() + "$");
                    clientSocket.Send(msg);
                }

            }

            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();
            data = "";
            data_card = "";

        }
    }
}

