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
using System.Windows.Shapes;
using yLibrary.windows.functionWindow.router;
using yLibrary.windows.loginWindow.router;

namespace yLibrary.windows.functionWindow
{
    /// <summary>
    /// FunctionWindow.xaml 的交互逻辑
    /// </summary>
    public partial class FunctionWindow : Window
    {
        FunctionWindowRouter router;
        public FunctionWindow()
        {
            InitializeComponent();
            router = new FunctionWindowRouter();
            router.NavigateTo(FunctionMainFrame, "Main");
        }
    }
}
