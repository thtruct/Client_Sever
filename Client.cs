using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            Connect();
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

        IPEndPoint IP;
        Socket client;

        void Connect() // kết nối tới sever
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối sever!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            

            Thread listen = new Thread(Recive);
            listen.IsBackground = true;
            listen.Start();
        }

        void Close() // đóng kết nối lại 
        {
            client.Close();
        }
        void Send() // gửi tin
        {
            if(txtMessage.Text != string.Empty)
            {
                client.Send(Serialize(txtMessage.Text));
            }
            
        }

        void Recive() //nhận tin
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = data.ToString(); // (string) Deserialize(data);

                    AddMessage(message);
                }
            }
            
            catch
            {
                Close();
            }
        }

        void AddMessage (string s)
        {
            lsvMessage.Items.Add(new ListViewItem() { Text = s });
            txtMessage.Clear();
        }

        byte[] Serialize(Object obj) // phân mảnh
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();   

            formatter.Serialize(stream, obj);

            stream.ToArray(); 

            return stream.ToArray();
        }

        byte[] Deserialize(byte[] data) // gom mảnh
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return (byte[])formatter.Deserialize(stream);

        }

        private void Client_FormClosed(object sender, EventArgs e) // đóng kết nối khi đóng form
        {
            Close();    
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Send();
            AddMessage(txtMessage.Text);
        }
    }
}
