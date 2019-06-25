using ChatClient.Manager;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class Form2 : Form
    {
        private NetManager m_netManager = null;
        private WindowManager m_windowManager = null;

        public Form2()
        {
            InitializeComponent();

            m_netManager = NetManager.GetNetManager();
            m_windowManager = WindowManager.GetWindowManager();
        }

        private void m_panelPortrait_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            //加载好友
            m_netManager.Send(Request.LoadFriend, "");

        }
    }
}
