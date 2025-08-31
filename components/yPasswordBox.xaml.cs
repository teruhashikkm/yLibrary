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

namespace yLibrary.components
{
    /// <summary>
    /// yPasswordBox.xaml 的交互逻辑
    /// </summary>
    public partial class yPasswordBox : UserControl
    {
        private Boolean pwdChanging = false;

        // 添加一个依赖属性来对外绑定, 输入propdp, 然后按两下tab
        public String BindablePassword
        {
            get { return (String)GetValue(BindablePasswordProperty); }
            set { SetValue(BindablePasswordProperty, value); }
        }

        // 最后一个属性是默认值, 倒数第二个绑定他所属的类, 也就是yPasswordBox即可
        public static readonly DependencyProperty BindablePasswordProperty =
            DependencyProperty.Register("BindablePassword", typeof(String), typeof(yPasswordBox), new FrameworkPropertyMetadata(String.Empty, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,setPasswordToViewCallBack, null, false, UpdateSourceTrigger.PropertyChanged));

        // DependencyObject就是我们的密码框, 这个是一个静态回调
        public static void setPasswordToViewCallBack(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if(d is yPasswordBox passwordBox)
            {
                passwordBox.setPasswordToView();
            }
        }

        public void setPasswordToView()
        {
            if (!pwdChanging) {
                _originPasswordBox.Password = BindablePassword;
            }
        }

        public yPasswordBox()
        {
            InitializeComponent();
        }

        // 默认生成的方法名, 我不喜欢
        private void OnPasswordChangedEvent(object sender, RoutedEventArgs e)
        {
            pwdChanging = true;
            BindablePassword = _originPasswordBox.Password;
            pwdChanging = false;
        }
    }
}
