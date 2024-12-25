using RS.DouYinWidgets.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace RS.DouYinWidgets.Controls
{

    [TemplatePart(Name = nameof(PART_Popup), Type = typeof(Popup))]
    [TemplatePart(Name = nameof(PART_PopBoder), Type = typeof(Border))]
    public class RSPopBtn : ToggleButton,IDrag
    {
        private Popup PART_Popup;
        private Border PART_PopBoder;
        static RSPopBtn()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RSPopBtn), new FrameworkPropertyMetadata(typeof(RSPopBtn)));
        }

        public RSPopBtn()
        {

        }


        public ControlTemplate PopContentTemplate
        {
            get { return (ControlTemplate)GetValue(PopContentTemplateProperty); }
            set { SetValue(PopContentTemplateProperty, value); }
        }

        public static readonly DependencyProperty PopContentTemplateProperty =
            DependencyProperty.Register("PopContentTemplate", typeof(ControlTemplate), typeof(RSPopBtn), new PropertyMetadata(null));



        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            this.PART_Popup = (Popup)this.GetTemplateChild(nameof(this.PART_Popup));
            this.PART_PopBoder = (Border)this.GetTemplateChild(nameof(this.PART_PopBoder));

            //this.MouseEnter -= RSPopBtn_MouseEnter;
            //this.MouseEnter += RSPopBtn_MouseEnter;

            if (this.PART_Popup != null)
            {
                this.PART_Popup.Opened += PART_Popup_Opened;
            }
        }
     

        private void PART_Popup_Opened(object? sender, EventArgs e)
        {
            //var ellipsisBtnActualWidth = this.PART_EllipsisBtn.ActualWidth;
            //var popupActualWidth = ((Border)this.PART_Popup.Child).ActualWidth;
            //this.PART_Popup.HorizontalOffset = -popupActualWidth + ellipsisBtnActualWidth;
            //this.PART_Popup.VerticalOffset = 8;
            this.PART_Popup.VerticalOffset = this.Padding.Bottom + 2;
        }

    }
}
