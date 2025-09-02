using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yLibrary.common.router;

namespace yLibrary.windows.loginWindow.router
{
    class LoginWindowRouter:Router
    {
        public LoginWindowRouter()
        {
            Routes = new Dictionary<string, string>
            {
                { "Login", "windows/loginWindow/loginMainPage/LoginMainPage.xaml" },
                { "Regist", "windows/loginWindow/registPage/RegistPage.xaml" },
            };
        }
    }
}
