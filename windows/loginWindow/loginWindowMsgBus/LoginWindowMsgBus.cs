using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yLibrary.windows.loginWindow.loginWindowMsgBus
{
    public static class LoginWindowMsgBus
    {
        public static event Action LoginSuccessful;

        public static void PublishLoginSuccess()
        {
            LoginSuccessful?.Invoke();
        }
    }
}
