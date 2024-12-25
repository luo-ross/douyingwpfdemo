using RS.DouYinWidgets.Controls;
using RS.DouYinWidgets.Events;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Linq;

namespace RS.DouYinLearning
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RSDouYinWindow
    {
        public MainWindowViewModel ViewModel { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            this.ViewModel = this.DataContext as MainWindowViewModel;
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Task.Factory.StartNew(async () =>
            {
                while (true)
                {
                    //await Task.Delay(500);
                    //this.Dispatcher.Invoke(() =>
                    //{
                    //    BtnMonitor1.Foreground = new SolidColorBrush(Colors.Red);
                    //});
                    //await Task.Delay(500);
                    //this.Dispatcher.Invoke(() =>
                    //{
                    //    BtnMonitor1.Foreground = new SolidColorBrush(Colors.Green);
                    //});
                    this.ViewModel.VolumeLevel = new Random(Guid.NewGuid().GetHashCode()).NextDouble();
                    await Task.Delay(80);
                }
            });
        }

        private void BtnMonitor1_OnCkEyeShowHide(DouYinUsercontrol.WinMonitorBtn arg1, bool arg2)
        {
        }

        private void BtnMonitor1_LockMaterialsClick(object sender, RoutedEventArgs e)
        {
        }

        private void PART_Canvas_MouseMove(object sender, MouseEventArgs e)
        {

        }


        private void GetVisualChildrenRecursive(DependencyObject parent, List<DependencyObject> children)
        {
            int count = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < count; i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(parent, i);
                children.Add(child);
                // 继续递归子控件的子控件
                GetVisualChildrenRecursive(child, children);
            }
        }




        private void RSDouYinWindow_MouseMove(object sender, MouseEventArgs e)
        {
            var position = e.GetPosition(this.CanvasHost);
            Canvas.SetLeft(this.DragContent, position.X - this.DragContent.ActualWidth / 2);
            Canvas.SetTop(this.DragContent, position.Y - this.DragContent.ActualHeight / 2);
            e.Handled = true;
        }


        public FrameworkElement DragTarget { get; set; }
        public Panel DragTargetHost { get; set; }

        private void RSDouYinWindow_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var mouseDownPostion = e.GetPosition(this.BorderHost);
            var element = this.GetIDragUnderMouse(this.BorderHost, mouseDownPostion);
            if (element == null)
            {
                return;
            }
            DragTargetHost = (Panel)VisualTreeHelper.GetParent((FrameworkElement)element);
            DragTarget = (FrameworkElement)element;
            if (DragTarget != null)
            {
                var actualWidth = DragTarget.ActualWidth;
                var actualHeight = DragTarget.ActualHeight;


                //var adornerLayer = AdornerLayer.GetAdornerLayer(DragTarget);
                //adornerLayer.Add(new DragAdorner(DragTarget, actualWidth, actualHeight));

                var bitmap = ConvertToBitmapSource(DragTarget);
                this.DragContent.Visibility = Visibility.Visible;
                this.DragContent.Width = actualWidth;
                this.DragContent.Height = actualHeight;
                this.DragContent.Background = new VisualBrush(DragTarget);
                //this.DragContent.Background = new ImageBrush(bitmap);
                var canvasHostPoint = e.GetPosition(this.CanvasHost);
                Canvas.SetLeft(this.DragContent, canvasHostPoint.X - actualWidth / 2);
                Canvas.SetTop(this.DragContent, canvasHostPoint.Y - actualHeight / 2);
                //DragTarget.Visibility = Visibility.Collapsed;
                //this.CaptureMouse();
                e.Handled = true;
            }
        }

        private IDrag GetIDragUnderMouse(UIElement uIElement, Point mousePosition)
        {
            var hitTestResult = VisualTreeHelper.HitTest(uIElement, mousePosition);
            var visualHit = hitTestResult?.VisualHit;

            while (visualHit != null)
            {
                var child = visualHit as IDrag;
                if (child != null)
                {
                    return child;
                }
                visualHit = VisualTreeHelper.GetParent(visualHit);
            }
            return null;
        }

        private T GetElementUnderMouse<T>(UIElement uIElement, Point mousePosition) where T : UIElement
        {
            var hitTestResult = VisualTreeHelper.HitTest(uIElement, mousePosition);
            var visualHit = hitTestResult?.VisualHit;

            while (visualHit != null)
            {
                var child = visualHit as T;
                if (child != null)
                {
                    return child;
                }
                visualHit = VisualTreeHelper.GetParent(visualHit);
            }
            return null;
        }

        public static BitmapSource ConvertToBitmapSource(UIElement element)
        {
            // 创建一个用于渲染的可视化对象容器
            var visual = new DrawingVisual();
            using (var context = visual.RenderOpen())
            {
                // 将传入的UI元素（这里是Button等控件）添加到渲染上下文中
                var brush = new VisualBrush(element);
                context.DrawRectangle(brush, null, new Rect(new Point(0, 0), new Point(element.RenderSize.Width, element.RenderSize.Height)));
            }
            // 创建一个渲染目标位图
            var bitmap = new RenderTargetBitmap((int)element.RenderSize.Width, (int)element.RenderSize.Height, 96, 96, PixelFormats.Pbgra32);
            // 将可视化对象渲染到位图上
            bitmap.Render(visual);
            return bitmap;
        }


        private void RSDouYinWindow_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (this.DragTarget == null)
            {
                return;
            }
            var mouseDownPostion = e.GetPosition(this.BorderHost);
            var gridHost = this.GetElementUnderMouse<FrameworkElement>(this.BorderHost, mouseDownPostion);
            if (gridHost != null)
            {
                if (gridHost is Panel panel)
                {
                    if (!panel.Children.Contains(DragTarget))
                    {
                        DragTargetHost.Children.Remove(DragTarget);
                        panel.Children.Add(DragTarget);
                        DragTarget.Visibility = Visibility.Visible;
                        this.DragContent.Visibility = Visibility.Collapsed;
                        return;
                    }
                 
                }
            }
            DragTarget.Visibility = Visibility.Visible;
            this.DragContent.Visibility = Visibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //this.PopularityChartTest.Storyboard.Stop();
            //this.HourChartTest.Storyboard.Stop();
            //this.ViewModel.BeginThickness = new Thickness(10, 0, 5, -50);
            //this.ViewModel.EndThickness = new Thickness(10, 0, 5, 50);
            //this.PopularityChartTest.Storyboard.Begin();
            //this.HourChartTest.Storyboard.Begin();
        }

        private void MediaVideo_MediaEnded(object sender, RoutedEventArgs e)
        {
            this.MediaVideo.Position = new TimeSpan(0);
            this.MediaVideo.Play();
        }

        private void MediaVideo_Loaded(object sender, RoutedEventArgs e)
        {
            this.MediaVideo.Position = new TimeSpan(0);
            this.MediaVideo.Play();
        }

        private void BtnSendMsg_Click(object sender, RoutedEventArgs e)
        {
            this.SendMsg();
        }

        private void SendMsg()
        {
            this.ViewModel.SendMsg(this.TxtSendMessage);
            this.MsgScrollViewer.ScrollToBottom();
        }

        private void BtnSendMsg_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            this.SendMsg();
        }
    }
}