using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace yLibrary.windows.loginWindow.router
{
    public class Router
    {
        public static Dictionary<string, string> Routes = new Dictionary<string, string>
        {
            { "Login", "windows/loginWindow/loginMainPage/LoginMainPage.xaml" },
            { "Regist", "windows/loginWindow/registPage/RegistPage.xaml" },
        };

        public static string GetPath(string routeName)
        {
            return Routes.TryGetValue(routeName, out var path) ? path : null;
        }

        public static void NavigateTo(NavigationService navService, string routeName)
        {
            var path = GetPath(routeName);
            if (path != null)
            {
                navService.Navigate(new Uri(path, UriKind.Relative));
            }
        }
        public static void NavigateTo(Frame frame, string routeName)
        {
            var path = GetPath(routeName);
            if (path != null)
            {
                frame.Navigate(new Uri(path, UriKind.Relative));
            }
        }

        public static void Fucku()
        {
            Console.WriteLine("Fuck");
        }
    }
}
