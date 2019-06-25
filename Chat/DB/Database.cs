using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chat.Model;
using MySql.Data.MySqlClient;

namespace Chat.DB
{
    class Database
    {
        public MySqlConnection m_conn = null;
        public Database()
        {
            m_conn = new MySqlConnection("server = localhost;userid = root;password=1234;database=test");
            Start();
        }
        public void Start()
        {
            m_conn.Open();
        }
        ~Database()
        {
            m_conn.Close();
        }

        public User QueryUser(string username, string password)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM test.user where username=@username;", m_conn);
            cmd.Parameters.AddWithValue("username", username);
            MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
            try
            {
                while(mySqlDataReader.Read())
                {
                    User user = new User(mySqlDataReader.GetInt32("id"), mySqlDataReader.GetString("username"), mySqlDataReader.GetString("password"));
                    if (User.Checked(username, password, user))
                        return user;
                    else
                        return null;
                }
                
            }catch(Exception e)
            {
                string s = e + "";
                return null;
            }
            return null;
            
        }
    }
}
