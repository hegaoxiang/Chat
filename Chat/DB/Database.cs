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
            User user = null;
            try
            {
                
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM test.user where username=@username;", m_conn);
                cmd.Parameters.AddWithValue("username", username);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    user = new User(mySqlDataReader.GetInt32("id"), mySqlDataReader.GetString("username"), mySqlDataReader.GetString("password"));
                    if (User.Checked(username, password, user))
                        break;
                    
                }
                mySqlDataReader.Close();
                return user;
            }
            catch (Exception e)
            {
                
                string s = e + "";
                return null;
            } 
        }

        public List<User> QueryFriends(int id)
        {
            List<User> users = new List<User>();
            
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM test.friendship,test.user where userid = @userid and userid = test.user.id;", m_conn);
                cmd.Parameters.AddWithValue("userid", id);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                
                while (mySqlDataReader.Read())
                {
                    try
                    {
                        int a = mySqlDataReader.GetInt32("id");
                        string b = mySqlDataReader.GetString("username");
                        string c = mySqlDataReader.GetString("password");
                        
                        users.Add(new User(a, b, c));
                    }
                    catch(Exception e)
                    {
                        string s = e + "";
                        Console.Write("213");
                    }
                }
              
                return users;
                
            }
            catch (Exception e)
            {
               
                string s = e + "";
                return users;
            }
            
        }
    }
}
