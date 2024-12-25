using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.DouYinLearning.Models
{
    public enum MsgType
    {
        /// <summary>
        /// 这是普通消息
        /// </summary>
        NormalMsg,

        /// <summary>
        /// 这是欢迎高等级用户的消息
        /// </summary>
        Greeting,

        /// <summary>
        /// 这是用户点关注的消息
        /// </summary>
        Interest,
    }
}
