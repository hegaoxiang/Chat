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
    public partial class Form1 : Form
    {
        private NetManager m_netManager = null;
        private WindowManager m_windowManager = null;
        private Form2 form2 = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_netManager = NetManager.GetNetManager();
            m_windowManager = WindowManager.GetWindowManager();

            m_netManager.Init();
            m_windowManager.Init();
        }

        private void m_btnLogin_Click(object sender, EventArgs e)
        {
            string username = m_userInput.Text;
            string password = m_passInput.Text;

            m_netManager.Send(Request.Login, username + "," + password);

           // m_windowManager.m_phase = Phase.LoginCheck;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(m_windowManager.m_phase)
            {
                case Phase.LoginCheck:
                    {
                        break;
                    }
                case Phase.LoginInput:
                    {
                        break;
                    }
                case Phase.LoginCheckOver:
                    {
                        if(m_windowManager.M_bLoginSuccess)
                        {
                            form2 =  new Form2();

                            form2.Visible = true;
                            this.Visible = false;

                            m_windowManager.m_phase = Phase.LoginInput;
                        }
                        else
                        {
                            m_panelLoginInfo.Visible = true;
                           
                        }
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
