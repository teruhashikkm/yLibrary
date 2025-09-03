using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using yLibrary.windows.loginWindow.router;

namespace yLibrary.windows.loginWindow.loginMainPage
{
    /// <summary>
    /// LoginMainPage.xaml 的交互逻辑
    /// </summary>
    public partial class LoginMainPage : Page
    {
        LoginWindowRouter router;
        LoginMainPageVM _loginMainPageVM;
        public LoginMainPage()
        {
            InitializeComponent();
            _loginMainPageVM = new LoginMainPageVM();
            _loginMainPageVM.registAccountEvent += ChangeToRegistPage;
            this.DataContext = _loginMainPageVM;
            router = new LoginWindowRouter();
        }
        private void ChangeToRegistPage()
        {
            router.NavigateTo(NavigationService, "Regist");
        }
    }
}
