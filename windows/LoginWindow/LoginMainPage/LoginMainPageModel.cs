using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace yLibrary.windows.loginWindow.loginMainPage
{
    public class LoginMainPageModel
    {
        public String Username
        {
            get; set;
        }
        public String Password
        {
            get; set;
        }
        public LoginMainPageModel()
        {
            Username = "";
            Password = "";
        }
        public bool Login()
        {
            if (Username == "admin" && Password == "123456")
            {
                MessageBox.Show("登录成功!!");
                return true;
            }
            else
            {
                MessageBox.Show("登录失败!!");
                return false;
            }
        }
    }
}
