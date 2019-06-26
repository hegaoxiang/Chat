using Chat.DB;
using Chat.Model;
using Common;
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
        public Database database = null;
        private Socket m_server = null;

        private IPEndPoint m_endPoint = null;

        //test msg
        public byte[] msg = new byte[1024];

        public Server()
        {
            database = new Database();
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
            Client client = new Client(clientSocket,this);
            //client.Send(Response.Chat,"HELLO CLIENT");                                                      // send it something        
            m_server.BeginAccept(AcceptCallBack, null);
        }

        /// <summary>
        /// client interaction
        /// </summary>      
        public User LoginCheck(string username,string password)
        {
            return database.QueryUser(username,password);
        }

        public List<User> LoadFriends(int id)
        {
            return database.QueryFriends(id);
        }
    }
}
