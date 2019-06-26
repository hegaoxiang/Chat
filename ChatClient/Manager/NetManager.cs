using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using Common;

namespace ChatClient.Manager
{
    class NetManager : Manager
    { 
        private WindowManager m_windowManager = null;
        private Socket m_client = null;
        private IPEndPoint m_iPEndPoint = null;

        //test accept msg
        byte[] msg = new byte[1024];

        bool m_bConnectd = false;
        private NetManager()
        {
            m_client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); 
            m_iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 0720);

            m_windowManager = WindowManager.GetWindowManager();
        }
        private static NetManager netManager = new NetManager();
        public static NetManager GetNetManager()
        {
            return netManager;
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
               
                m_bConnectd = false;
            }  

        }

        private void Start()
        {
            m_client.BeginReceive(msg, 0, 1024, SocketFlags.None, ReceiveHandle, null);

            //Send(Request.Chat,"hello server");
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

            int sum = BitConverter.ToInt32(msg, 0);
            Response res = (Response)BitConverter.ToInt32(msg, 4);
            string data = Encoding.UTF8.GetString(msg, 8, sum - 4);
            string datas = Encoding.UTF8.GetString(msg, 8, count - 4);

            switch (res)
            {
                case Response.Login:
                    {
                        m_windowManager.m_phase = Phase.LoginCheckOver;
                        if (data == "1")     // login success
                        {
                            m_windowManager.M_bLoginSuccess = true;
                        }
                        else                // login fail
                        {
                            m_windowManager.M_bLoginFail = true;
                        }
                        break;
                    }
                case Response.LoadFriend:
                    {
                        m_windowManager.friends.Add(new Friend(data));
                        m_windowManager.m_phase = Phase.LoadFriend;
                        break;
                    }
                default:
                    break;
            }
            m_client.BeginReceive(msg, 0, 1024, SocketFlags.None, ReceiveHandle, null);
            
        }
    }
}
