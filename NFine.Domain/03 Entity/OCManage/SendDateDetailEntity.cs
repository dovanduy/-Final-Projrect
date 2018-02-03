﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Domain.Entity.OCManage
{
    public class SendDateDetailEntity 
    {
        /// <summary>
        /// Desc:编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string F_Id { get; set; }

        /// <summary>
        /// Desc:编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public Int64 Id { get; set; }

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SMC_F_Id { get; set; }


        /// <summary>
        /// Desc:用户编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int F_UserId { get; set; }

        /// <summary>
        /// Desc:祖宗编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int F_RootId { get; set; }

        /// <summary>
        /// Desc:发送号码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string F_PhoneCode { get; set; }

        /// <summary>
        /// Desc:发送内容 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string F_SmsContent { get; set; }

        /// <summary>
        /// Desc:发送时间 （提交时间）
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public DateTime? F_SendTime { get; set; }

        /// <summary>
        /// Desc:省份 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string F_Province { get; set; }

        /// <summary>
        /// Desc:通道 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int? F_ChannelId { get; set; }

        /// <summary>
        /// Desc:发送类型 （1=移动；2=联通；3=电信；默认是1）
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? F_Operator { get; set; }

        /// <summary>
        /// Desc:同步 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int? F_Synchro { get; set; }
        /// <summary>
        /// Desc:扣量 (1=未；2=有)
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int? F_Buckle { get; set; }

        /// <summary>
        /// Desc:黑白 (1=无；2=黑名单；3=白名单)
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int? F_BlackWhite { get; set; }
        /// <summary>
        /// Desc:补发 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int? F_Reissue { get; set; }
        /// <summary>
        /// Desc:级别 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int? F_Level { get; set; }

        //短信是否为验证码
        public bool? F_IsVerificationCode { get; set; }

        //短信条数
        public int? F_LongsmsCount { get; set; }

        //是否返款
        public bool F_IsCashBack { get; set; }

        //短信单价
        public decimal F_Price { get; set; }

        //处理状态
        public int F_DealState { get; set; }//指的是是否再次拆分之类的，不是短信发送状态

        //用户签名
        public string F_UserSignature { get; set; }

        //签名位置
        public int F_SignLocation { get; set; }

        //通道签名
        public string F_ChannelSignature { get; set; }

        //通道编号：回执表中的SP_Number。不是平台中的通道编号
        public string F_AccessNumber { get; set; }

        //创建时间
        public DateTime F_CreatorTime { get; set; }
        /// <summary>
        /// Desc:创建人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string F_CreatorUserId { get; set; }

        //最后修改时间
        public DateTime? F_LastModifyTime { get; set; }

        //最后修改人
        public string F_LastModifyUserId { get; set; }

        //删除时间
        public DateTime? F_DeleteTime { get; set; }

        //删除人
        public string F_DeleteUserId { get; set; }
    }
}
