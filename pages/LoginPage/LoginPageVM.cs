using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using yLibrary.common.commands;

namespace yLibrary.pages.LoginPage
{
    public class LoginPageVM
    {
        LoginPageModel loginPageModel;
        public LoginPageVM()
        {
            loginPageModel = new LoginPageModel();
            loginAccountCmd = new RelayCommand(ExeLogin, CanLogin);
            registAccountCmd = new RelayCommand(ExeRegist);
            _username = "";
            _password = "";
        }
        private String _username;
        public String Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged();
                CommandManager.InvalidateRequerySuggested();
            }

        }
        private String _password;
        public String Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
                CommandManager.InvalidateRequerySuggested();
            }
        }

        public ICommand registAccountCmd { get; }
        public ICommand loginAccountCmd { get; }

        private void ExeLogin(object parameter)
        {
            loginPageModel.Username = Username;
            loginPageModel.Password = Password;
            loginPageModel.Login();
        }
        private bool CanLogin(object parameter)
        {
            return !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password);
        }
        private void ExeRegist(object parameter)
        {
            MessageBox.Show("尚未实现!!");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
