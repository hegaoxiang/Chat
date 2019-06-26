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
        private List<Button> m_friends = new List<Button>();
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

        private void BecomeTemplateInstance(Button button,int tabIndex)
        {
            button.BackColor = FriendTemplate.BackColor;
            button.Location = FriendTemplate.Location;
            button.Margin = FriendTemplate.Margin;
            button.Name = FriendTemplate.Name;
            button.Size = FriendTemplate.Size;
            button.TabIndex = tabIndex;
            button.UseCompatibleTextRendering = FriendTemplate.UseVisualStyleBackColor;
            button.Visible = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(m_windowManager.m_phase)
            {
                case Phase.LoadFriend:
                    {
                        flowLayoutPanel1.Controls.Clear();
                        
                        
                        int TabIndex = FriendTemplate.TabIndex;
                        foreach (var item in m_windowManager.friends)
                        {
                            Button friend = new Button();
                            friend.Text = item.user.name;
                            BecomeTemplateInstance(friend, TabIndex);
                            TabIndex++;

                            m_friends.Add(friend);
                            //通过模板构造一个
                            flowLayoutPanel1.Controls.Add(friend);
                        }
                        flowLayoutPanel1.Refresh();

                        m_windowManager.m_phase = Phase.LoginInput;
                        break;
                    }
                default:
                    break;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
