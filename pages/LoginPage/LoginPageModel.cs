using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace yLibrary.pages.LoginPage
{
    public class LoginPageModel
    {
        public String Username
        {
            get; set;
        }
        public String Password
        {
            get; set;
        }
        public LoginPageModel()
        {
            Username = "";
            Password = "";
        }
        public void Login()
        {
            if (Username == "admin" && Password == "123456")
            {
                MessageBox.Show("登录成功!!");
            }
            else
            {
                MessageBox.Show("登录失败!!");
            }
        }
    }
}
