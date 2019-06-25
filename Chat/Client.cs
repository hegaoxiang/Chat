using Chat.Model;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    class Client
    {
        public User m_user = null;
        public Server m_server = null;
        public Socket m_client = null;
        //test msg
        public byte[] msg = new byte[1024];

        public Client(Socket clientSocket,Server server)
        {
            m_client = clientSocket;
            m_server = server;
            
            Init();
        }
        ~Client()
        {
            m_client.Close();
        }
        //send msg to client
        public void  Send(Response responseCode, string data)
        {
            byte[] responseCodeBytes = BitConverter.GetBytes((int)responseCode);
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            byte[] lengthBytes = BitConverter.GetBytes(responseCodeBytes.Length + dataBytes.Length);


            byte[] msgBytes = lengthBytes.Concat(responseCodeBytes)
            .Concat(dataBytes).ToArray<byte>();

            m_client.Send(msgBytes);                                    
        }

        public void Init()
        {
            m_client.BeginReceive(msg, 0, 1024, SocketFlags.None, ReceiveCallBack, null);       // get msg from it
        }

        private void ReceiveCallBack(IAsyncResult ar)
        {
            try
            {
                int count = m_client.EndReceive(ar);
                int sum = BitConverter.ToInt32(msg, 0);
                Request req = (Request)BitConverter.ToInt32(msg, 4);
                string data = Encoding.UTF8.GetString(msg, 8, sum - 4);

                if (req == Request.Login)
                {
                    string[] userInfo = data.Split(',');                    // splitting the byte stream to get the userful infomation
                    m_user = m_server.LoginCheck(userInfo[0], userInfo[1]);
                    if (m_user != null) // login success
                    {
                        Send(Response.Login, "1");
                    }
                    else                // login failed
                    {
                        Send(Response.Login, "0");
                    }
                }
                
                m_client.BeginReceive(msg, 0, 1024, SocketFlags.None, ReceiveCallBack, null);
            }catch(Exception e)
            {
                Console.WriteLine(e + "关闭该连接");
                m_client.Close();
            }
            
        }
    }
}
