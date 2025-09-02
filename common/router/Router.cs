using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace yLibrary.common.router
{
    public class Router
    {
        protected static Dictionary<string, string> Routes;

        public string GetPath(string routeName)
        {
            return Routes.TryGetValue(routeName, out var path) ? path : null;
        }

        public void NavigateTo(NavigationService navService, string routeName)
        {
            var path = GetPath(routeName);
            if (path != null)
            {
                navService.Navigate(new Uri(path, UriKind.Relative));
            }
        }
        public void NavigateTo(Frame frame, string routeName)
        {
            var path = GetPath(routeName);
            if (path != null)
            {
                frame.Navigate(new Uri(path, UriKind.Relative));
            }
        }
    }
}
