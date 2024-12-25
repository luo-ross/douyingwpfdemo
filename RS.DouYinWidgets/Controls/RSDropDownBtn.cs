using RS.DouYinWidgets.Events;
using RS.DouYinWidgets.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace RS.DouYinWidgets.Controls
{
    public class RSDropDownBtn : ToggleButton, IDrag
    {
        static RSDropDownBtn()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RSDropDownBtn), new FrameworkPropertyMetadata(typeof(RSDropDownBtn)));
        }




        public ObservableCollection<ButtonModel> ButtonModelList
        {
            get { return (ObservableCollection<ButtonModel>)GetValue(ButtonModelListProperty); }
            set { SetValue(ButtonModelListProperty, value); }
        }

        public static readonly DependencyProperty ButtonModelListProperty =
            DependencyProperty.Register("ButtonModelList", typeof(ObservableCollection<ButtonModel>), typeof(RSDropDownBtn), new PropertyMetadata(null, ButtonModelListPropertyChanged));

        private static void ButtonModelListPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var rsDropDownBtn = d as RSDropDownBtn;
            rsDropDownBtn.InitDefaultConfig();
        }


        private void InitDefaultConfig()
        {
            if (this.PopRows == 0)
            {
                var rows = ButtonModelList.Count;
                if (this.PopCols > 0)
                {
                    rows = (int)Math.Ceiling((double)rows / this.PopCols);
                }
                this.PopRows = rows;
            }
        }


        public int PopCols
        {
            get { return (int)GetValue(PopColsProperty); }
            set { SetValue(PopColsProperty, value); }
        }

        public static readonly DependencyProperty PopColsProperty =
            DependencyProperty.Register("PopCols", typeof(int), typeof(RSDropDownBtn), new PropertyMetadata(1));


        public int PopRows
        {
            get { return (int)GetValue(PopRowsProperty); }
            set { SetValue(PopRowsProperty, value); }
        }
        public static readonly DependencyProperty PopRowsProperty =
            DependencyProperty.Register("PopRows", typeof(int), typeof(RSDropDownBtn), new PropertyMetadata(0));




        public double PopWidth
        {
            get { return (double)GetValue(PopWidthProperty); }
            set { SetValue(PopWidthProperty, value); }
        }

        public static readonly DependencyProperty PopWidthProperty =
            DependencyProperty.Register("PopWidth", typeof(double), typeof(RSDropDownBtn), new PropertyMetadata(200D));





        public double PopHeight
        {
            get { return (double)GetValue(PopHeightProperty); }
            set { SetValue(PopHeightProperty, value); }
        }

        public static readonly DependencyProperty PopHeightProperty =
            DependencyProperty.Register("PopHeight", typeof(double), typeof(RSDropDownBtn), new PropertyMetadata(200D));





        public int BtnGroupIndex
        {
            get { return (int)GetValue(BtnGroupIndexProperty); }
            set { SetValue(BtnGroupIndexProperty, value); }
        }

        public static readonly DependencyProperty BtnGroupIndexProperty =
            DependencyProperty.Register("BtnGroupIndex", typeof(int), typeof(RSDropDownBtn), new PropertyMetadata(0));



        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }
    }
}
