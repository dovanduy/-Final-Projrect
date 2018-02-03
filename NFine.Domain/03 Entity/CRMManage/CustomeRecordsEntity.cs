﻿using System;


namespace NFine.Domain.Entity.CRMManage
{
    public class CustomeRecordsEntity : IEntity<CustomeRecordsEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
        {

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string F_Id { get; set; }

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string F_CustomeId { get; set; }

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string F_Record { get; set; }

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? F_SortCode { get; set; }

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Boolean? F_DeleteMark { get; set; }

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Boolean? F_EnabledMark { get; set; }

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string F_Description { get; set; }

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? F_CreatorTime { get; set; }

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string F_CreatorUserId { get; set; }

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? F_LastModifyTime { get; set; }

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string F_LastModifyUserId { get; set; }

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public DateTime? F_DeleteTime { get; set; }

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string F_DeleteUserId { get; set; }

    }
}
