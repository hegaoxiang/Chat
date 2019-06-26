using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient
{
    class Friend
    {
        public User user = null;
        public class User
        {
            public int id;
            public string name;
            public string pass;

            public User(string data)
            {
                string[] info = data.Split(',');
                id = Int32.Parse(info[0]);
                name = info[1];
                pass = info[2];             
            }
        }
        
        public Friend(string data)
        {
            user = new User(data);
        }
    }
}
