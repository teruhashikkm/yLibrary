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

namespace yLibrary.windows.loginWindow.registPage
{
    /// <summary>
    /// RegistPage.xaml 的交互逻辑
    /// </summary>
    public partial class RegistPage : Page
    {
        RegistPageVM registPageVM;
        public RegistPage()
        {
            InitializeComponent();
            registPageVM = new RegistPageVM();
            registPageVM.BackToLoginEvent += ChangeToLoginMainPage;
            this.DataContext = registPageVM;
        }
        private void ChangeToLoginMainPage()
        {
            Router.NavigateTo(NavigationService, "Login");
        }
    }
}
