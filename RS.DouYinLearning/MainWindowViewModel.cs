using RS.DouYinWidgets.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;
using RS.DouYinLearning.Models;
using RS.DouYinWidgets.Events;
using System.Windows.Interop;

namespace RS.DouYinLearning
{
    public class MainWindowViewModel : NotifyBase
    {

        public MainWindowViewModel()
        {
            this.SendMsgCommand = new RelayCommand(SendMsg, CanSendMsg);
        }

        private bool CanSendMsg(object arg)
        {
            return true;
        }

        public void SendMsg(object obj)
        {
            var textBox = obj as TextBox;
            string msgSend = textBox.Text;
            if (string.IsNullOrEmpty(msgSend)||string.IsNullOrWhiteSpace(msgSend))
            {
                textBox.Text = "";
                textBox.Focus();
                return;
            }


            this.MsgModelPageList.Add(new MsgModel()
            {
                Degree = 70,
                IsFansTeam = true,
                MsgInfo = textBox.Text,
                MsgType = MsgType.NormalMsg,
                NickName = "行云游者"
            });
            textBox.Text = "";
            textBox.Focus();
        }

         

        private ICommand sendMsgCommand;
        /// <summary>
        /// 发送消息
        /// </summary>

        public ICommand SendMsgCommand
        {
            get
            {
                return sendMsgCommand;
            }
            set
            {
                sendMsgCommand = value;
                this.OnPropertyChanged();
            }
        }




        private ObservableCollection<ButtonModel> buttonModelList;
        /// <summary>
        /// 模式命令列表
        /// </summary>

        public ObservableCollection<ButtonModel> ButtonModelList
        {
            get
            {
                if (buttonModelList == null)
                {
                    buttonModelList = new ObservableCollection<ButtonModel>();
                    buttonModelList.Add(new ButtonModel() { BtnDes = "常规模式", BtnCommand = null });
                    buttonModelList.Add(new ButtonModel() { BtnDes = "语音模式", BtnCommand = null });
                    buttonModelList.Add(new ButtonModel() { BtnDes = "嘉宾模式", BtnCommand = null });
                    buttonModelList.Add(new ButtonModel() { BtnDes = "助播模式", BtnCommand = null });
                }
                return buttonModelList;
            }
            set
            {
                buttonModelList = value;
                this.OnPropertyChanged();
            }
        }

        private Thickness beginThickness = new Thickness(10, 0, 5, -50);
        /// <summary>
        /// 默认Thickness
        /// </summary>

        public Thickness BeginThickness
        {
            get
            {
                return beginThickness;
            }
            set
            {
                beginThickness = value;
                this.OnPropertyChanged();
            }
        }


        private Thickness endThickness = new Thickness(10, 0, 5, 0);
        /// <summary>
        /// 默认Thickness
        /// </summary>

        public Thickness EndThickness
        {
            get
            {
                return endThickness;
            }
            set
            {
                endThickness = value;
                this.OnPropertyChanged();
            }
        }

        private double volumeLevel;
        /// <summary>
        /// 声音大小
        /// </summary>

        public double VolumeLevel
        {
            get
            {
                return volumeLevel;
            }
            set
            {
                volumeLevel = value;
                this.OnPropertyChanged();
            }
        }


        private ObservableCollection<AudienceModel> audienceModelList;
        /// <summary>
        /// 观众列表
        /// </summary>

        public ObservableCollection<AudienceModel> AudienceModelList
        {
            get
            {


                if (audienceModelList == null)
                {
                    audienceModelList = new ObservableCollection<AudienceModel>();
                    audienceModelList.Add(new AudienceModel()
                    {
                        Number = 1,
                        Contribution = 11,
                        Degree = 10,
                        ImgLink = "Assets/xiaohuzidashu.jpg",
                        NickName = "小胡子大叔608",
                        RelationShip = RelationShip.Fans,
                        Location = "浙江",
                        InterestCount = 10,
                        FansCount = 20,

                        CommentCount = 10,
                        GiftCollectionCount = 4,
                        GiftCount = 5,
                        InteractionBegin = DateTime.Now.AddDays(-7),
                        InteractionEnd = DateTime.Now,
                        IsFansTeam = true,
                        IsGiftCollection = true,
                        Last7DaysComments = 7,
                        Last7DaysGift = 2,
                        Last7DaysView = 7,
                        ViewDay = 5,
                        ViewTime = 40
                    });

                    audienceModelList.Add(new AudienceModel()
                    {
                        Number = 2,
                        Contribution = 11,
                        Degree = 10,
                        ImgLink = "Assets/MeetingInDreamShouldLeadToAcquaintance.jpg",
                        NickName = "梦里相遇应相识",
                        RelationShip = RelationShip.Friend,
                        Location = "北京",
                        InterestCount = 10,
                        FansCount = 20,


                        CommentCount = 10,
                        GiftCollectionCount = 4,
                        GiftCount = 5,
                        InteractionBegin = DateTime.Now.AddDays(-7),
                        InteractionEnd = DateTime.Now,
                        IsFansTeam = true,
                        IsGiftCollection = true,
                        Last7DaysComments = 7,
                        Last7DaysGift = 2,
                        Last7DaysView = 7,
                        ViewDay = 5,
                        ViewTime = 40
                    });
                    audienceModelList.Add(new AudienceModel()
                    {
                        Number = 3,
                        Contribution = 11,
                        Degree = 0,
                        ImgLink = "Assets/LzDic.jpg",
                        NickName = "LzDic",
                        RelationShip = RelationShip.Fans,
                        Location = "上海",
                        InterestCount = 100,
                        FansCount = 3000,

                        CommentCount = 11,
                        GiftCollectionCount = 5,
                        GiftCount = 6,
                        InteractionBegin = DateTime.Now.AddDays(-5),
                        InteractionEnd = DateTime.Now,
                        IsFansTeam = true,
                        IsGiftCollection = true,
                        Last7DaysComments = 4,
                        Last7DaysGift = 1,
                        Last7DaysView = 1,
                        ViewDay = 3,
                        ViewTime = 25
                    });

                    audienceModelList.Add(new AudienceModel()
                    {
                        Number = 4,
                        Contribution = 10,
                        Degree = 10,
                        ImgLink = "Assets/Galgg.jpg",
                        NickName = "Galgg",
                        RelationShip = RelationShip.Friend,
                        Location = "广州",
                        InterestCount = 250,
                        FansCount = 2000,


                        CommentCount = 20,
                        GiftCollectionCount = 3,
                        GiftCount = 3,
                        InteractionBegin = DateTime.Now.AddDays(-2),
                        InteractionEnd = DateTime.Now,
                        IsFansTeam = false,
                        IsGiftCollection = true,
                        Last7DaysComments = 7,
                        Last7DaysGift = 24,
                        Last7DaysView = 2,
                        ViewDay = 4,
                        ViewTime = 30
                    });

                    audienceModelList.Add(new AudienceModel()
                    {
                        Number = 5,
                        Contribution = 10,
                        Degree = 11,
                        ImgLink = "Assets/lynnf.jpg",
                        NickName = "Lynn*F",
                        RelationShip = RelationShip.Friend,
                        Location = "江苏",
                        InterestCount = 350,
                        FansCount = 2500,


                        CommentCount = 2,
                        GiftCollectionCount = 2,
                        GiftCount = 9,
                        InteractionBegin = DateTime.Now.AddDays(-4),
                        InteractionEnd = DateTime.Now,
                        IsFansTeam = false,
                        IsGiftCollection = true,
                        Last7DaysComments = 9,
                        Last7DaysGift = 7,
                        Last7DaysView = 6,
                        ViewDay = 7,
                        ViewTime = 18
                    });

                    audienceModelList.Add(new AudienceModel()
                    {
                        Number = 6,
                        Contribution = 1,
                        Degree = 3,
                        ImgLink = "Assets/xiaoxianyu.jpg",
                        NickName = "小咸鱼",
                        RelationShip = RelationShip.Fans,
                        Location = "浙江",
                        InterestCount = 450,
                        FansCount = 3500,

                        CommentCount = 32,
                        GiftCollectionCount = 1,
                        GiftCount = 2,
                        InteractionBegin = DateTime.Now.AddDays(-6),
                        InteractionEnd = DateTime.Now,
                        IsFansTeam = false,
                        IsGiftCollection = true,
                        Last7DaysComments = 7,
                        Last7DaysGift = 3,
                        Last7DaysView = 4,
                        ViewDay = 6,
                        ViewTime = 30
                    });

                    audienceModelList.Add(new AudienceModel()
                    {
                        Number = 7,
                        Contribution = 0,
                        Degree = 2,
                        ImgLink = "Assets/xiaoxianyu.jpg",
                        NickName = "路飞雪大马扁子~退钱",
                        RelationShip = RelationShip.Fans,
                        Location = "上海",
                        InterestCount = 550,
                        FansCount = 5500,


                        CommentCount = 19,
                        GiftCollectionCount = 0,
                        GiftCount = 12,
                        InteractionBegin = DateTime.Now.AddDays(-1),
                        InteractionEnd = DateTime.Now,
                        IsFansTeam = false,
                        IsGiftCollection = true,
                        Last7DaysComments = 7,
                        Last7DaysGift = 3,
                        Last7DaysView = 7,
                        ViewDay = 5,
                        ViewTime = 35
                    });
                }
                return audienceModelList;
            }
            set
            {
                audienceModelList = value;
                this.OnPropertyChanged();
            }
        }



        private ObservableCollection<MsgModel> msgModelPageList;
        /// <summary>
        /// 消息列表
        /// </summary>
        public ObservableCollection<MsgModel> MsgModelPageList
        {
            get
            {
                if (msgModelPageList == null)
                {
                    msgModelPageList = new ObservableCollection<MsgModel>();

                    msgModelPageList.Add(new MsgModel()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Degree = 10,
                        MsgInfo = "高手高手高高手，求带",
                        NickName = "慧眼早教",
                        MsgType = MsgType.NormalMsg
                    });

                    msgModelPageList.Add(new MsgModel()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Degree = 10,
                        MsgInfo = "你有一个margin 5，是不是这个",
                        NickName = "阿胜",
                        MsgType = MsgType.NormalMsg
                    });

                    msgModelPageList.Add(new MsgModel()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Degree = 10,
                        MsgInfo = "是Guid类型的",
                        NickName = "你好小峰峰",
                        MsgType = MsgType.NormalMsg
                    });

                    msgModelPageList.Add(new MsgModel()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Degree = 26,
                        MsgInfo = null,
                        NickName = "Wang",
                        IsFansTeam = false,
                        MsgType = MsgType.Greeting
                    });

                    msgModelPageList.Add(new MsgModel()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Degree = 26,
                        MsgInfo = null,
                        NickName = "Wang",
                        MsgType = MsgType.Interest
                    });

                    msgModelPageList.Add(new MsgModel()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Degree = 30,
                        MsgInfo = null,
                        NickName = "幸运王子",
                        MsgType = MsgType.Greeting,
                        IsFansTeam = false
                    });

                    msgModelPageList.Add(new MsgModel()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Degree = 30,
                        MsgInfo = null,
                        NickName = "璞",
                        MsgType = MsgType.Greeting,
                        IsFansTeam = true
                    });
                }
                return msgModelPageList;
            }
            set
            {
                msgModelPageList = value;
                this.OnPropertyChanged();
            }
        }


    }
}
