using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;
using System.Net.NetworkInformation;


namespace TCPprotocol
{
    public partial class Form1 : Form
    {
        string dataReceive = string.Empty;
        Socket serversock, clientsock;
        string ipclient;
        Int32 portclient;
        int portServer;
        Boolean startServer = false;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            string hostname = Dns.GetHostName();
            IPHostEntry iphostentry = Dns.GetHostByName(hostname);
            foreach (IPAddress ipadress in iphostentry.AddressList)
            {
                lanip.Text = ipadress.ToString();
            
            }
            startServer = true;
            Thread thClient = new Thread(acceptclient);

        }

        private void acceptclient()
        {
            try
            {
                portServer = int.Parse(t_port.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi port: " + ex.Message);            
            }
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, portServer);
            serversock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            if (checkPort(portServer))
            {
                MessageBox.Show("port da bi chiem quyen");
                return;
            }

            serversock.Bind(ipep);
            serversock.Listen(1);
            while (startServer)
            {
                try
                {
                    clientsock = serversock.Accept();
                    IPEndPoint ipclientEnd = (IPEndPoint)clientsock.RemoteEndPoint;
                    ipclient = Convert.ToString(ipclientEnd.Address);
                    portclient = Convert.ToInt32(ipclientEnd.Port);
                    ipc.Invoke((MethodInvoker)
                        delegate { ipc.Text = ipclient + ":" + portclient.ToString(); });
                    Thread thListener = new Thread(server);
                    thListener.Start();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("loi accept clinet: " + ex.Message);
                    serversock.Close();
                    clientsock.Close();
                    return;
                }
            }
        }

        private bool checkPort(int port)
        {
            IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] tcpEndpoints = ipGlobalProperties.GetActiveTcpListeners();
            foreach (IPEndPoint endPoint in tcpEndpoints)
            {
                if (endPoint.Port == port)
                {
                    return true;
                }
            }
            
            return true;
        }

        private void server()
        {
            while (startServer)
            { 
                while( clientsock.Available < 100)
                {
                    clientsock.ReceiveBufferSize = 10000;
                    byte[] data = new byte[10000];
                    
                    try
                    {
                        clientsock.Receive(data);
                        dataReceive = Encoding.ASCII.GetString(data);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Loi nhan du lieu" + ex.Message);
                        return;
                    }

                    
                    if (dataReceive != string.Empty)
                    {
                        setText(dataReceive);
                    }


                }
            }
        }

        private void setText(String str)
        {
            if (InvokeRequired) this.Invoke(new Action(() => getData.Text = str));
            else getData.AppendText( str + Environment.NewLine );
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            startServer = false;
            if (serversock != null) serversock.Close();
            if (clientsock != null) serversock.Close();
            ipc.Text = "";
            getData.Text = "";
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            string dataSend = "Hello client";
            byte[] command = Encoding.UTF8.GetBytes(dataSend);
            if (clientsock.Connected)
            {
                clientsock.Send(command, SocketFlags.None);
            }
            else MessageBox.Show("Client da ngat ket noi");
        }
    }
}
