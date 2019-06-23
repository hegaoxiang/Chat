using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace ChatClient
{
    class NetManager : Manager
    {
        private Socket m_client = null;
        private IPEndPoint m_iPEndPoint = null;

        //test accept msg
        byte[] msg = new byte[1024];

        bool m_bConnectd = false;
        public NetManager()
        {
            m_client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); 
            m_iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 0720);
        }
        public override void Init()
        {
            try
            {
                m_client.Connect(m_iPEndPoint);
                m_bConnectd = true;
                Start();

            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                m_bConnectd = false;
            }  

        }

        private void Start()
        {
            m_client.BeginReceive(msg, 0, 1024, SocketFlags.None, ReceiveHandle, null);

            Send("hello server");
        }
        public void Send(string msg)
        {
            while (m_bConnectd == false)
                Init();
            m_client.Send(Encoding.UTF8.GetBytes(msg));
        }
        private void ReceiveHandle(IAsyncResult ar)
        {
            int count = m_client.EndReceive(ar);
            string receiveMsg = Encoding.UTF8.GetString(msg, 0, count);
            m_client.BeginReceive(msg, 0, 1024, SocketFlags.None, ReceiveHandle, null);
            
        }
    }
}
