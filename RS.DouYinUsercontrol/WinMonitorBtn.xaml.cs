using RS.DouYinWidgets.Events;
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

namespace RS.DouYinUsercontrol
{
    /// <summary>
    /// WinMonitorBtn.xaml 的交互逻辑
    /// </summary>
    public partial class WinMonitorBtn : RadioButton, IDrag
    {
        public WinMonitorBtn()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 这就是路由事件
        /// </summary>
        public static readonly RoutedEvent LockMaterialsClickEvent = EventManager.RegisterRoutedEvent(
            "LockMaterialsClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(WinMonitorBtn));

        public event RoutedEventHandler LockMaterialsClick
        {
            add { AddHandler(LockMaterialsClickEvent, value); }
            remove { RemoveHandler(LockMaterialsClickEvent, value); }
        }

        /// <summary>
        /// 这个是普通事件 这种事件它不会触发什么冒泡或者隧道之类
        /// </summary>
        public event Action<WinMonitorBtn, bool> OnEyeShowHideClick;


        private void PART_CkEyeShowHide_Click(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;
            OnEyeShowHideClick?.Invoke(this, checkBox.IsChecked == true);
        }

        private void PART_CkLockUnLock_Click(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;
            // 触发自定义的路由事件
            RoutedEventArgs args = new RoutedEventArgs(LockMaterialsClickEvent, checkBox.IsChecked == true);
            RaiseEvent(args);
        }

        private void BtnPositionReset_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnReName_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
