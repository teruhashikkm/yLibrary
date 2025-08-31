using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using yLibrary.common.commands;

namespace yLibrary.windows.loginWindow.registPage
{
    public class RegistPageVM
    {
        public RegistPageVM()
        {
            BackToLoginCmd = new RelayCommand(ExeBackToLogin);
        }
        public ICommand BackToLoginCmd { get; }
        private void ExeBackToLogin(object parameter)
        {
            BackToLoginEvent?.Invoke();
        }

        public event Action BackToLoginEvent;

    }
}
