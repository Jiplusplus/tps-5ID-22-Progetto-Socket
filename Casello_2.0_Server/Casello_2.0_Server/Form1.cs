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
                    ClientManager clientThread = new ClientManager(handler, ref richieste, ref costo);
                    Thread t = new Thread(new ThreadStart(clientThread.doClient));
                    t.Start();
                    richieste.Items.Add(clientThread.Messaggio);
                    citta.Text = "Bergamo";
                    costo.Text = "5,5";
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
        ListBox richieste;
        TextBox costo;

        public ClientManager(Socket clientSocket, ref ListBox richieste, ref TextBox costo)
        {
            this.clientSocket = clientSocket;
            this.richieste = richieste;
            this.costo = costo;
        }

        public string Messaggio { get { return data; } }
        public void doClient()
        {

            while (true)
            {
                // An incoming connection needs to be processed.  
                data = "";
                while (data.IndexOf("$") == -1)
                {
                    int bytesRec = clientSocket.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                }

                //data = data.Substring(0, data.Length - 1);

                // Show the data on the console.  
                //MessageBox.Show("Messaggio ricevuto :" + data);
                
                // Echo the data back to the client.  
                byte[] msg = Encoding.ASCII.GetBytes(data);
                clientSocket.Send(msg);
                richieste.Items.Add("Hai pagato" + data.Substring(0, data.Length - 1));
                int differenza;
                //System.Diagnostics.Debug.WriteLine(Int32.Parse(costo.Text) - Int32.Parse(data.Substring(0, data.Length - 1)));
                //differenza = Int32.Parse(costo.Text) - Int32.Parse(data);
                //richieste.Items.Add("Hai ancora da pagare" + differenza.ToString());
            }

            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();
            data = "";

        }
    }
}

