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
                
                string receiveMsg = Encoding.UTF8.GetString(msg, 0, count);
                m_client.BeginReceive(msg, 0, 1024, SocketFlags.None, ReceiveCallBack, null);
            }catch(Exception e)
            {
                Console.WriteLine(e + "关闭该连接");
                m_client.Close();
            }
            
        }
    }
}
