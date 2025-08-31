using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Windows.Threading;
using yLibrary.common.commands;

namespace yLibrary.pages.LoginPage
{
    public class LoginMainPageVM: INotifyPropertyChanged
    {
        LoginMainPageModel loginPageModel;
        public LoginMainPageVM()
        {
            loginPageModel = new LoginMainPageModel();
            loginAccountCmd = new RelayCommand(ExeLogin, CanLogin);
            registAccountCmd = new RelayCommand(ExeRegist);
            DenpendencyPropertyInit();
        }

        private void DenpendencyPropertyInit()
        {
            _username = "";
            _password = "";
            _informationMsg = "";
            _informationColor = "#FF0000";
        }

        // -------------------------必须实现的方法-------------------------
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // -------------------------传输给View-------------------------
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
        private String _informationMsg;
        public String InformationMsg
        {
            get => _informationMsg;
            set
            {
                _informationMsg = value;
                OnPropertyChanged(nameof(InformationMsg));
            }
        }
        private String _informationColor;
        public String InformationColor
        {
            get => _informationColor;
            set
            {
                _informationColor = value;
                OnPropertyChanged(nameof(InformationColor));
            }
        }

        private DispatcherTimer _hideInfoTimer;
        private void DelayClearInfo()
        {
            // 如果已有计时器，先停止
            if (_hideInfoTimer != null)
            {
                _hideInfoTimer.Stop();
                _hideInfoTimer = null;
            }
            // 创建新的计时器
            _hideInfoTimer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(2) // 2秒后隐藏
            };
            _hideInfoTimer.Tick += (sender, e) =>
            {
                InformationMsg = "";
                _hideInfoTimer.Stop();
                _hideInfoTimer = null; // 清理计时器
            };
            _hideInfoTimer.Start();
        }


        // -------------------------传输给Model-------------------------
        public ICommand registAccountCmd { get; }
        public ICommand loginAccountCmd { get; }

        public event Action registAccountEvent;

        private void ExeLogin(object parameter)
        {
            loginPageModel.Username = Username;
            loginPageModel.Password = Password;
            bool result = loginPageModel.Login();
            if (!result)
            {
                InformationMsg = "登录失败!! 用户名或密码错误";
                InformationColor = "#FF0000";
            }
            else
            {
                InformationMsg = "登录成功!! ";
                InformationColor = "#008000";
            }
            DelayClearInfo();
        }
        private bool CanLogin(object parameter)
        {
            return !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password);
        }
        private void ExeRegist(object parameter)
        {
            registAccountEvent?.Invoke();
            // MessageBox.Show("尚未实现!!");
        }
    }
}
