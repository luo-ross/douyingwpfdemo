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
  
    [TemplatePart(Name = nameof(PART_ContentHost), Type = typeof(Grid))]
    [TemplatePart(Name = nameof(PART_Border), Type = typeof(Border))]

    public class RSSceneBtn : RadioButton, IDrag
    {
        private Grid PART_ContentHost;
        private Border PART_Border;
        static RSSceneBtn()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RSSceneBtn), new FrameworkPropertyMetadata(typeof(RSSceneBtn)));
        }

        public RSSceneBtn()
        {
            
        }



        

        public ControlTemplate PopContentTemplate
        {
            get { return (ControlTemplate)GetValue(PopContentTemplateProperty); }
            set { SetValue(PopContentTemplateProperty, value); }
        }

        public static readonly DependencyProperty PopContentTemplateProperty =
            DependencyProperty.Register("PopContentTemplate", typeof(ControlTemplate), typeof(RSSceneBtn), new PropertyMetadata(null));


        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            this.PART_ContentHost = (Grid)this.GetTemplateChild(nameof(this.PART_ContentHost));
            this.PART_Border = (Border)this.GetTemplateChild(nameof(this.PART_Border));
        }


        
    }
}
