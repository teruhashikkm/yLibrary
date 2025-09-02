using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yLibrary.common.router;

namespace yLibrary.windows.functionWindow.router
{
    class FunctionWindowRouter : Router
    {
        public FunctionWindowRouter()
        {
            Routes = new Dictionary<string, string>
            {
                { "Main", "windows/functionWindow/functionMainPage/FunctionMainPage.xaml" },
                { "Borrow", "windows/functionWindow/borrowPage/BorrowPage.xaml" },
                { "Giveback", "windows/functionWindow/givebackPage/GivebackPage.xaml" }, // 叫return容易搞混, 使用Give Back来替代归还一词
                { "Account", "windows/functionWindow/accountPage/AccountPage.xaml" },
                { "Admin", "windows/functionWindow/adminPage/AdminPage.xaml" },
            };
        }
    }
}
