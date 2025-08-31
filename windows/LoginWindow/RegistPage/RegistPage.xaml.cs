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

namespace yLibrary.windows.LoginWindow.RegistPage
{
    /// <summary>
    /// RegistPage.xaml 的交互逻辑
    /// </summary>
    public partial class RegistPage : Page
    {
        public RegistPage()
        {
            InitializeComponent();
            this.DataContext = new RegistPageVM();
        }
        private void ChangeToRegistPage()
        {
            NavigationService.Navigate(new Uri("windows/LoginWindow/RegistPage/RegistPage.xaml", UriKind.Relative));
        }
    }
}
