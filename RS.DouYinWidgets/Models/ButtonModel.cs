using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RS.DouYinWidgets.Models
{
    public class ButtonModel : NotifyBase
    {
        private string btnDes;

        /// <summary>
        /// 这是按钮的描述 就是通常的Button的Content 是字符串而已
        /// </summary>

        public string BtnDes
        {
            get { return btnDes; }
            set
            {
                btnDes = value;
                this.OnPropertyChanged();
            }
        }


        private ICommand btnCommand;
        /// <summary>
        /// 这里绑定按钮的Command
        /// </summary>

        public ICommand BtnCommand
        {
            get { return btnCommand; }
            set
            {
                btnCommand = value;
                this.OnPropertyChanged();
            }
        }


    }
}
