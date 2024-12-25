using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RS.DouYinWidgets.Controls
{
    public class RSDouYinWindow : Window
    {
        static RSDouYinWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RSDouYinWindow), new FrameworkPropertyMetadata(typeof(RSDouYinWindow)));
        }

        public RSDouYinWindow()
        {
            this.CommandBindings.Add(new CommandBinding(SystemCommands.CloseWindowCommand, CloseWindow));
            this.CommandBindings.Add(new CommandBinding(SystemCommands.MaximizeWindowCommand, MaximizeWindow, CanResizeWindow));
            this.CommandBindings.Add(new CommandBinding(SystemCommands.MinimizeWindowCommand, MinimizeWindow, CanMinimizeWindow));
            this.CommandBindings.Add(new CommandBinding(SystemCommands.RestoreWindowCommand, RestoreWindow, CanResizeWindow));
            this.CommandBindings.Add(new CommandBinding(SystemCommands.ShowSystemMenuCommand, ShowSystemMenu));

            // 添加命令绑定
            this.CommandBindings.Add(new CommandBinding(ControlsCommand.CleanTextCommand, CleanTextText));
        }

        private void CleanTextText(object sender, ExecutedRoutedEventArgs e)
        {
            ControlsCommand.CleanText(e.Source);
        }

        private void ShowSystemMenu(object sender, ExecutedRoutedEventArgs e)
        {
            var element = e.OriginalSource as FrameworkElement;
            if (element == null)
            {
                return;
            }
            var point = WindowState.Maximized == this.WindowState ? new Point(0, element.ActualHeight) : new Point(Left + BorderThickness.Left, element.ActualHeight + Top + BorderThickness.Top);
            point = element.TransformToAncestor(this).Transform(point);
            SystemCommands.ShowSystemMenu(this, point);
        }

        private void CanMinimizeWindow(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = this.ResizeMode != ResizeMode.NoResize;
        }

        private void RestoreWindow(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.RestoreWindow(this);
        }

        private void MinimizeWindow(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }

        private void CanResizeWindow(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = this.ResizeMode == ResizeMode.CanResize || ResizeMode == ResizeMode.CanResizeWithGrip;
        }


        private void MaximizeWindow(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.MaximizeWindow(this);
        }

        private void CloseWindow(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.CloseWindow(this);
        }


        /// <summary>
        /// 窗体顶部自定义内容
        /// </summary>
        public object WinCommandContent
        {
            get { return (object)GetValue(WinCommandContentProperty); }
            set { SetValue(WinCommandContentProperty, value); }
        }

        public static readonly DependencyProperty WinCommandContentProperty =
            DependencyProperty.Register("WinCommandContent", typeof(object), typeof(RSDouYinWindow), new PropertyMetadata(null));


     
    }
}
