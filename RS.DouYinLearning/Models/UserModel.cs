using RS.DouYinWidgets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.DouYinLearning.Models
{
    public class UserModel : NotifyBase
    {
        /// <summary>
        /// 用户唯一标识
        /// </summary>
        public string Id { get; set; }

        private string nickName;

        /// <summary>
        /// 观众昵称
        /// </summary>

        public string NickName
        {
            get { return nickName; }
            set
            {
                nickName = value;
                this.OnPropertyChanged();
            }
        }

        private int degree;

        /// <summary>
        /// 抖音等级
        /// </summary>

        public int Degree
        {
            get { return degree; }
            set
            {
                degree = value;
                this.OnPropertyChanged();
            }
        }


        private bool isFansTeam;

        /// <summary>
        /// 是否加入粉丝团
        /// </summary>
        public bool IsFansTeam
        {
            get { return isFansTeam; }
            set
            {
                isFansTeam = value;
                this.OnPropertyChanged();
            }
        }
    }
}
