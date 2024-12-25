using RS.DouYinWidgets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RS.DouYinLearning.Models
{
    public class AudienceModel: UserModel
    {
        private int number;

        /// <summary>
        /// 观众序号
        /// </summary>

        public int Number
        {
            get { return number; }
            set
            {
                number = value;
                this.OnPropertyChanged();
            }
        }


        private int contribution;

        /// <summary>
        /// 贡献度
        /// </summary>

        public int Contribution
        {
            get { return contribution; }
            set
            {
                contribution = value;
                this.OnPropertyChanged();
            }
        }

    


        private RelationShip relationShip;

        /// <summary>
        /// 关系 
        /// </summary>

        public RelationShip RelationShip
        {
            get { return relationShip; }
            set
            {
                relationShip = value;
                this.OnPropertyChanged();
            }
        }



        private string imgLink;

        /// <summary>
        /// 头像地址
        /// </summary>

        public string ImgLink
        {
            get { return imgLink; }
            set
            {
                imgLink = value;
                this.OnPropertyChanged();
            }
        }


        private string location;

        /// <summary>
        /// 地址
        /// </summary>

        public string Location
        {
            get { return location; }
            set
            {
                location = value;
                this.OnPropertyChanged();
            }
        }
       

        private int interestCount;

        /// <summary>
        /// 关注数量
        /// </summary>

        public int InterestCount
        {
            get { return interestCount; }
            set
            {
                interestCount = value;
                this.OnPropertyChanged();
            }
        }


        private int fansCount;

        /// <summary>
        /// 粉丝数量
        /// </summary>
        public int FansCount
        {
            get { return fansCount; }
            set
            {
                fansCount = value;
                this.OnPropertyChanged();
            }
        }


        private long viewTime;

        /// <summary>
        /// 观看时长
        /// </summary>
        public long ViewTime
        {
            get { return viewTime; }
            set
            {
                viewTime = value;
                this.OnPropertyChanged();
            }
        }


        private long viewDay;

        /// <summary>
        /// 过去7天观看天数
        /// </summary>
        public long ViewDay
        {
            get { return viewDay; }
            set
            {
                viewDay = value;
                this.OnPropertyChanged();
            }
        }

        private int giftCount;

        /// <summary>
        /// 过去7天礼物数量
        /// </summary>
        public int GiftCount
        {
            get { return giftCount; }
            set
            {
                giftCount = value;
                this.OnPropertyChanged();
            }
        }


        private int commentCount;

        /// <summary>
        /// 过去7天评论数量
        /// </summary>
        public int CommentCount
        {
            get { return commentCount; }
            set
            {
                commentCount = value;
                this.OnPropertyChanged();
            }
        }



       


        private bool isGiftCollection;

        /// <summary>
        /// 是否有礼物图鉴
        /// </summary>
        public bool IsGiftCollection
        {
            get { return isGiftCollection; }
            set
            {
                isGiftCollection = value;
                this.OnPropertyChanged();
            }
        }

        private int giftCollectionCount;

        /// <summary>
        /// 礼物图鉴个数
        /// </summary>
        public int GiftCollectionCount
        {
            get { return giftCollectionCount; }
            set
            {
                giftCollectionCount = value;
                this.OnPropertyChanged();
            }
        }


        private DateTime interactionBegin;

        /// <summary>
        /// 互动开始时间
        /// </summary>
        public DateTime InteractionBegin
        {
            get { return interactionBegin; }
            set
            {
                interactionBegin = value;
                this.OnPropertyChanged();
            }
        }


        private DateTime interactionEnd;

        /// <summary>
        /// 互动开始时间结束
        /// </summary>
        public DateTime InteractionEnd
        {
            get { return interactionEnd; }
            set
            {
                interactionEnd = value;
                this.OnPropertyChanged();
            }
        }


        private int last7DaysView;

        /// <summary>
        /// 过去7天观看直播
        /// </summary>
        public int Last7DaysView
        {
            get { return last7DaysView; }
            set
            {
                last7DaysView = value;
                this.OnPropertyChanged();
            }
        }


        private int last7DaysGift;

        /// <summary>
        /// 过去7天观看直播
        /// </summary>
        public int Last7DaysGift
        {
            get { return last7DaysGift; }
            set
            {
                last7DaysGift = value;
                this.OnPropertyChanged();
            }
        }


        private int last7DaysComments;

        /// <summary>
        /// 过去7天观看直播
        /// </summary>
        public int Last7DaysComments
        {
            get { return last7DaysComments; }
            set
            {
                last7DaysComments = value;
                this.OnPropertyChanged();
            }
        }

    }
}
