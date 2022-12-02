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

namespace Casello_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void connetti_Click(object sender, EventArgs e)
        {
            StartClient();
        }

        public void StartClient()
        {
            byte[] bytes = new byte[1024];
            try
            {
                IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 5000);
                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    sender.Connect(remoteEP);


                    list_eventi.Items.Add("Socket connected to {0}" + sender.RemoteEndPoint.ToString());
                    int numero = Convert.ToInt32(txt_num.Text);
                    list_eventi.Items.Add("Numero inserito: " + numero.ToString());
                    byte[] msg = Encoding.ASCII.GetBytes(numero.ToString());

                    int bytesSent = sender.Send(msg);

                    int bytesRec = sender.Receive(bytes);

                    list_eventi.Items.Add("Echoed test = {0}" + Encoding.ASCII.GetString(bytes, 0, bytesRec));
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();

                }
                catch (ArgumentNullException ane)
                {
                    list_eventi.Items.Add("ArgumentNullException : {0}" + ane.ToString());
                }
                catch (SocketException se)
                {
                    list_eventi.Items.Add("SocketException : {0}" + se.ToString());
                }
                catch (Exception e)
                {
                    list_eventi.Items.Add("Unexpected exception : {0}" + e.ToString());
                }

            }
            catch (Exception e)
            {
                list_eventi.Items.Add(e.ToString());
            }
        }

        private void invio_contanti_Click(object sender, EventArgs e)
        {
            enter();
        }

        public void enter()
        {
            // Data buffer for incoming data.  
            byte[] bytes = new byte[1024];
            int count = 0;

            // Connect to a remote device.  
            try
            {
                string data = "";
                // Establish the remote endpoint for the socket.  
                // This example uses port 11000 on the local computer.  
                IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 5000);

                // Create a TCP/IP  socket.  
                Socket sender = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);
                Random stringa_casuale = new Random();
                string stringa_da_inviare = "";

                // Connect the socket to the remote endpoint. Catch any errors.  
                try
                {
                    sender.Connect(remoteEP);

                    Console.WriteLine("Socket connected to {0}",
                        sender.RemoteEndPoint.ToString());
                        stringa_da_inviare = txt_num.Text + "$";
                        byte[] msg = Encoding.ASCII.GetBytes(stringa_da_inviare);              //("This is a test<EOF>");

                        // Send the data through the socket.  
                        int bytesSent = sender.Send(msg);
                        data = "";
                        // Receive the response from the remote device.  
                        while (data.IndexOf("$") == -1)
                        {
                            int bytesRec = sender.Receive(bytes);
                            data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        }


                    // Release the socket.
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();

                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}

