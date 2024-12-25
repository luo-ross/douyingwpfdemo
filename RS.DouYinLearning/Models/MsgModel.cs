using RS.DouYinWidgets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.DouYinLearning.Models
{
    public class MsgModel : UserModel
    {
        private string msgInfo;

        /// <summary>
        /// 消息
        /// </summary>

        public string MsgInfo
        {
            get { return msgInfo; }
            set
            {
                msgInfo = value;
                this.OnPropertyChanged();
            }
        }


        private MsgType msgType;
        /// <summary>
        /// 消息类型
        /// </summary>

        public MsgType MsgType
        {
            get { return msgType; }
            set
            {
                msgType = value;
                this.OnPropertyChanged();
            }
        }
    }
}
