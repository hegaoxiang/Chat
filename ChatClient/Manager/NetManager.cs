using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using Common;

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

            Send(Request.Chat,"hello server");
        }
        public void Send(Request requestCode, string data)
        {
            while (m_bConnectd == false)
                Init();
            byte[] requestCodeBytes = BitConverter.GetBytes((int)requestCode);
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            byte[] lengthBytes = BitConverter.GetBytes(requestCodeBytes.Length + dataBytes.Length);


            byte[] msgBytes =  lengthBytes.Concat(requestCodeBytes)
            .Concat(dataBytes).ToArray<byte>();      
            
            m_client.Send(msgBytes);
        }
        private void ReceiveHandle(IAsyncResult ar)
        {
            int count = m_client.EndReceive(ar);
            
            m_client.BeginReceive(msg, 0, 1024, SocketFlags.None, ReceiveHandle, null);
            
        }
    }
}
