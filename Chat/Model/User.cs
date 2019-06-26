using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Model
{
    class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User(int id,string user,string pass)
        {
            Id = id;
            Username = user;
            Password = pass;
        }
        //login check
        public static bool Checked(string username, string password,User user)
        {
            if(username == user.Username && password == user.Password)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return Id.ToString()+ "," + Username  + ","+ Password;
        }
    }
}
