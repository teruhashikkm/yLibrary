using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using yLibrary.common.commands;

namespace yLibrary.windows.functionWindow.functionMainPage
{
    public class FunctionMainPageVM : INotifyPropertyChanged
    {
        public FunctionMainPageVM()
        {
            ButtonNavigateToBorrowedPageCmd = new RelayCommand(ExecuteButtonNavigateToBorrowedPageCmd);
        }
        // -------------------------必须实现的方法-------------------------
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ICommand ButtonNavigateToBorrowedPageCmd { get; }

        private void ExecuteButtonNavigateToBorrowedPageCmd(object parameter)
        {
            NavigateToBorrowedPageEvent?.Invoke();
        }

        public event Action NavigateToBorrowedPageEvent;
    }
}
