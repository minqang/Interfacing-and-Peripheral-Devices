using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;

namespace KetNoiCoSoDuLieu
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private StreamWriter writer;
        private StreamReader reader;

        public Form1()
        {
            InitializeComponent();
            
        }


        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                string ipAddress = "192.168.199.46";
                int port = 1234;

                client = new TcpClient(ipAddress, port);
                stream = client.GetStream();
                writer = new StreamWriter(stream, Encoding.UTF8) { AutoFlush = true };
                reader = new StreamReader(stream, Encoding.UTF8);

                textBox1.AppendText("Connected to server" + "\n");
            }
            catch (Exception ex)
            {
                textBox1.AppendText("Connection error:" + ex.Message);
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (client != null && client.Connected)
            {
                try
                {
                    string message = textBoxInput.Text;
                    writer.WriteLine(message);

                    string response = reader.ReadLine();
                    textBox1.AppendText("Server response:" + response);
                }
                catch (Exception ex)
                {
                    textBox1.AppendText("Error" + ex.Message);
                }
            }
            else
            {
                textBox1.AppendText("Not connected to server\n");
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            writer.Close();
            reader.Close();
            stream.Close();
            client.Close();
            textBox1.AppendText("Disconnected to server\n");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

    }
}
