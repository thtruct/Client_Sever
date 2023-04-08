using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace server
{
    public partial class Sever : Form
    {

        public Sever()
        {
            InitializeComponent();
        }
        private TcpListener server;
        private readonly List<Clients> clients = new List<Clients>();
        private Thread thread;

        private void btnStart_Click(object sender, EventArgs e)
        {
            server = new TcpListener(IPAddress.Any, 9050);
            server.Start();

            thread = new Thread(() =>
            {
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    Clients clientHandler = new Clients(client, txtChat);
                    clients.Add(clientHandler);
                }
            });

            thread.Start();

            txtChat.AppendText("Server started!\n");

        }

        private void btnGui_Click(object sender, EventArgs e)
        {

            string message = txtMessage.Text;

            byte[] messageBytes = Encoding.UTF8.GetBytes(message);

            foreach (Clients clientHandler in clients)
            {
                clientHandler.SendMessage(messageBytes);
            }

            txtChat.AppendText("Server: " + message + "\n" + Environment.NewLine);
            txtMessage.Clear();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

            this.Hide();

        }
        class Clients
        {
            private readonly TcpClient tcpClient;
            private readonly NetworkStream stream;
            private readonly Thread client_thread;
            private readonly TextBox chat_box;

            public Clients(TcpClient client, TextBox chatTextBox)
            {
                tcpClient = client;
                stream = client.GetStream();
                chat_box = chatTextBox;

                client_thread = new Thread(() =>
                {
                    byte[] buffer = new byte[1024];
                    while (true)
                    {
                        int bytesRead = stream.Read(buffer, 0, buffer.Length);
                        if (bytesRead > 0)
                        {

                            string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                            chat_box.Invoke(new Action(() =>
                            {
                                chat_box.AppendText("Client: " + message + "\n" + Environment.NewLine);
                            }));
                        }
                    }
                });

                client_thread.Start();
            }
            public void SendMessage(byte[] messageBytes)
            {
                stream.Write(messageBytes, 0, messageBytes.Length);
            }
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
