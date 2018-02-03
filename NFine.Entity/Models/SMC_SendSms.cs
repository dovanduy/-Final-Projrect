﻿using System;
using System.Linq;
using System.Text;

namespace NFine.Entity
{
    public class SMC_SendSms
    {
        
        /// <summary>
        /// Desc:编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string F_Id {get;set;}

        /// <summary>
        /// Desc:收件人号码字符串，分隔符‘，’ 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string F_MobileList {get;set;}

        /// <summary>
        /// Desc:短信号码数量 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? F_MobileCount {get;set;}

        /// <summary>
        /// Desc:短信内容 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string F_SmsContent {get;set;}

        /// <summary>
        /// Desc:是否定时（默认是false,false=及时发送；true=定时发送） 
        /// Default:((0)) 
        /// Nullable:False 
        /// </summary>
        public Boolean F_IsTimer { get;set;}

        /// <summary>
        /// Desc:发送时间，用于定时发送 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? F_SendTime {get;set;}

        /// <summary>
        /// Desc:短信标记中文 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string F_SendSign {get;set;}

        /// <summary>
        /// Desc:发送状态(0=待发送；9=发送成功；-1=发送失败；-2=不发送；) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? F_SendState {get;set;}

        /// <summary>
        /// Desc:审核状态(0=未审核；9=已审核；-1=待审核；-2=未通过) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? F_DealState {get;set; }
        /// <summary>
        /// Desc:处理状态(0=待处理；9=已处理；1=处理中) 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? F_OperateState { get; set; }
        /// <summary>
        /// Desc:价格 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public decimal? F_Price {get;set;}

        /// <summary>
        /// Desc:删除标记 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Boolean? F_DeleteMark {get;set;}

        /// <summary>
        /// Desc:可用标记 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Boolean? F_EnabledMark {get;set;}

        /// <summary>
        /// Desc:创建时间 
        /// Default:(getdate()) 
        /// Nullable:True 
        /// </summary>
        public DateTime? F_CreatorTime {get;set;}

        /// <summary>
        /// Desc:创建人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string F_CreatorUserId {get;set;}

        /// <summary>
        /// Desc:最后编辑时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? F_LastModifyTime {get;set;}

        /// <summary>
        /// Desc:最后编辑人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string F_LastModifyUserId {get;set;}

        /// <summary>
        /// Desc:删除时间 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? F_DeleteTime {get;set;}

        /// <summary>
        /// Desc:删除人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string F_DeleteUserId {get;set;}

        /// <summary>
        /// Desc:短信标记英文 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string F_SmbSign {get;set;}

        public string F_GroupChannelId { get; set; }

        public int? F_RootId { get; set; }

        //优先级
         public int? F_Priority { get; set; }

        //短信是否为验证码
        public bool? F_IsVerificationCode { get; set; }

        //用户签名字段
        public string F_Signature { get; set; }

    }
}
