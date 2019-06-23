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
        private NetManager netManager = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            netManager = new NetManager();

            netManager.Init();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            netManager.Send("the time is" + DateTime.Now);
        }
    }
}
