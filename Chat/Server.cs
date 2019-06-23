using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    class Server
    {
        private Socket m_server = null;

        private IPEndPoint m_endPoint = null;

        //test msg
        public byte[] msg = new byte[1024];

        public Server()
        {
            m_endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 0720);
            m_server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Init();
        }
        public void Init()
        {
            m_server.Bind(m_endPoint);

            m_server.Listen(0);

            m_server.BeginAccept(AcceptCallBack, null);
        }

        private void AcceptCallBack(IAsyncResult ar)
        {
            Socket clientSocket = m_server.EndAccept(ar);                                     // get a new connected socket
            Client client = new Client(clientSocket);
            client.Send("HELLO CLIENT");                                                      // send it something        
            m_server.BeginAccept(AcceptCallBack, null);
        }

       
    }
}
