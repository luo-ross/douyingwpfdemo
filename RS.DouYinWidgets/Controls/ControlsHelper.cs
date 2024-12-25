﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace RS.DouYinWidgets.Controls
{
    public static class ControlsHelper
    {

        /// <summary>
        /// 这是自定义Pata 路径
        /// </summary>
        public static readonly DependencyProperty IconDataProperty =
            DependencyProperty.RegisterAttached(
                "IconData",
                typeof(Geometry),
                typeof(ControlsHelper),
                new PropertyMetadata(null));

        public static Geometry GetIconData(DependencyObject obj)
        {
            return (Geometry)obj.GetValue(IconDataProperty);
        }

        public static void SetIconData(DependencyObject obj, Geometry value)
        {
            obj.SetValue(IconDataProperty, value);
        }


        /// <summary>
        /// 这是Icon宽度
        /// </summary>
        
        public static readonly DependencyProperty IconWidthProperty =
          DependencyProperty.RegisterAttached(
              "IconWidth",
              typeof(double),
              typeof(ControlsHelper),
              new PropertyMetadata(15D));

        public static double GetIconWidth(DependencyObject obj)
        {
            return (double)obj.GetValue(IconWidthProperty);
        }

        public static void SetIconWidth(DependencyObject obj, double value)
        {
            obj.SetValue(IconWidthProperty, value);
        }


        /// <summary>
        /// 这是Icon高度
        /// </summary>
        public static readonly DependencyProperty IconHeightProperty =
          DependencyProperty.RegisterAttached(
              "IconHeight",
              typeof(double),
              typeof(ControlsHelper),
              new PropertyMetadata(15D));

        public static double GetIconHeight(DependencyObject obj)
        {
            return (double)obj.GetValue(IconHeightProperty);
        }

        public static void SetIconHeight(DependencyObject obj, double value)
        {
            obj.SetValue(IconHeightProperty, value);
        }



        /// <summary>
        /// 设置空间圆角
        /// </summary>
        public static readonly DependencyProperty CornerRadiusProperty =
          DependencyProperty.RegisterAttached(
              "CornerRadius",
              typeof(CornerRadius),
              typeof(ControlsHelper),
              new PropertyMetadata(default));

        public static CornerRadius GetCornerRadius(DependencyObject obj)
        {
            return (CornerRadius)obj.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(DependencyObject obj, CornerRadius value)
        {
            obj.SetValue(CornerRadiusProperty, value);
        }



       
    }
}
