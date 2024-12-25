﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows;
using RS.DouYinWidgets.Events;
using System.Windows.Controls;

namespace RS.DouYinWidgets.Controls
{
    public static class ControlsCommand
    {
    
        public static RoutedCommand CleanTextCommand { get; private set; }

        static ControlsCommand()
        {
            CleanTextCommand = new RoutedCommand("CleanText", typeof(ControlsCommand));
        }

        public static void CleanText(object source)
        {
            if (source is TextBox textBox)
            {
                textBox.Text = string.Empty;
            }
        }
    }
}
