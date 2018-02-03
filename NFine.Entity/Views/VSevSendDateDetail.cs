﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Entity.Views
{
    public class VSevSendDateDetail
    {
        /// <summary>
        /// Desc:编号 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        //public Int64 F_Id { get; set; }
        public string F_Id { get; set; }

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string SMC_F_Id { get; set; }

        /// <summary>
        /// Desc:发送表编号 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string F_SendId { get; set; }

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
        public string F_RootId { get; set; }

        /// <summary>
        /// Desc:发送号码 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string F_PhoneCode { get; set; }

        /// <summary>
        /// Desc:发送时间 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public DateTime? F_SendTime { get; set; }
        /// <summary>
        /// Desc:发送类型 （1=移动；2=联通；3=电信；默认是1）
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? F_Operator { get; set; }
        /// <summary>
        /// Desc:黑白 (1=无；2=黑名单；3=白名单)
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int? F_BlackWhite { get; set; }
        /// <summary>
        /// Desc:通道 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int? F_ChannelId { get; set; }
        /// <summary>
        /// Desc:省份 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string F_Province { get; set; }
        /// <summary>
        /// Desc:报告 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int? F_Report { get; set; }
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
        /// <summary>
        /// Desc:发送内容 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string F_SmsContent { get; set; }
        /// <summary>
        /// Desc:创建人 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string F_CreatorUserId { get; set; }

        public int? F_SubmitCount { get; set; }
        public int? F_SendCount { get; set; }
        public int F_SuccessCount { get; set; }
        public int F_SimulationSucceCount { get; set; }
        public int F_FailCount { get; set; }
        public int F_UnknownCount { get; set; }
        public int? F_ReissueCount { get; set; }
        public decimal? F_Price { get; set; }
        public int F_SuccessRate { get; set; }
    }
}
