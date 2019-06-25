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
        public Socket m_client = null;
        //test msg
        public byte[] msg = new byte[1024];

        public Client(Socket clientSocket)
        {
            m_client = clientSocket;
            Init();
        }
        ~Client()
        {
            m_client.Close();
        }
        //send msg to client
        public void  Send(string msg)
        {
            m_client.Send(Encoding.UTF8.GetBytes(msg));                                    
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
                    string[] userInfo = data.Split(',');
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
