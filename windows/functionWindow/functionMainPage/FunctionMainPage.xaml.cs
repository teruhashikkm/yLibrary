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
using yLibrary.common.router;
using yLibrary.windows.functionWindow.router;
using yLibrary.windows.loginWindow.loginMainPage;

namespace yLibrary.windows.functionWindow.functionMainPage
{
    /// <summary>
    /// FunctionMainPage.xaml 的交互逻辑
    /// </summary>
    public partial class FunctionMainPage : Page
    {
        FunctionWindowRouter router;
        FunctionMainPageVM _functionMainPageVM;
        public FunctionMainPage()
        {
            InitializeComponent();
            router = new FunctionWindowRouter();
            _functionMainPageVM = new FunctionMainPageVM();
            _functionMainPageVM.NavigateToBorrowedPageEvent += ChangeToBorrowedPage;
            this.DataContext = _functionMainPageVM;
        }
        private void ChangeToBorrowedPage()
        {
            router.NavigateTo(NavigationService, "Borrow");
            Console.WriteLine("进来了");
        }

    }
}
