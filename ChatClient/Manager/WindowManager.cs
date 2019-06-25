using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient.Manager
{
    public enum Phase
    {
        LoginInput,
        LoginCheck,
        LoginCheckOver,
    }
    class WindowManager : Manager
    {
        public Phase m_phase = Phase.LoginInput;
        public bool M_bLoginSuccess { get; set; }
        public bool M_bLoginFail  { get; set; }

        private WindowManager()
        {
            
        }

        public static WindowManager GetWindowManager()
        {
            return windowManager;
        }
        public override void Init()
        {
            M_bLoginSuccess = false;
            M_bLoginFail = false;
        }

        private static WindowManager windowManager = new WindowManager();
      
    }
}
