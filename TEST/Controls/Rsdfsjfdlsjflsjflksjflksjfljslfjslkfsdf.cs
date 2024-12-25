using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TEST.Controls
{
    public static class Rsdfsjfdlsjflsjflksjflksjfljslfjslkfsdf
    {
        public static readonly DependencyProperty IsBlinkingProperty =
       DependencyProperty.RegisterAttached("IsBlinking", typeof(bool), typeof(Rsdfsjfdlsjflsjflksjflksjfljslfjslkfsdf), new PropertyMetadata(false));

        public static bool GetIsBlinking(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsBlinkingProperty);
        }

        public static void SetIsBlinking(DependencyObject obj, bool value)
        {
            obj.SetValue(IsBlinkingProperty, value);
        }
    }
}
