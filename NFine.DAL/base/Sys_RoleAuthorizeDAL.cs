﻿// <autogenerated>
//   This file was generated by T4 code generator DALScript.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

/*-------------------------------------------------------------------------
 * 版本号：v1.0
 * 本类主要用途描述：
 *  -------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using NFine.Entity;
using SqlSugar;
using NFine.Code;
using System.Linq.Expressions;
using System.Data.SqlClient;

namespace NFine.DAL
{
    /// <summary>
    /// 测试
    /// </summary>
    public partial class Sys_RoleAuthorizeDAL
    {
        #region 单例模式
        private static Sys_RoleAuthorizeDAL instance;
        private static object _lock = new object();

        private Sys_RoleAuthorizeDAL()
        {
        }

        public static Sys_RoleAuthorizeDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            instance = new Sys_RoleAuthorizeDAL();
                        }
                    }
                }
                return instance;
            }
        }
        #endregion 单例模式

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public object Add(Sys_RoleAuthorize model)
        {
            using (var db=DBHelper.GetWriteInstance())
            {
                return db.Insert(model);
            }
        }

        public List<object> Add(List<Sys_RoleAuthorize> entitys)
        {
            using (var db = DBHelper.GetWriteInstance())
            {
                return db.InsertRange(entitys);
            }
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(Sys_RoleAuthorize model)
        {
            using (var db=DBHelper.GetWriteInstance())
            {
                return db.Update(model);
            }
        }
		/// <summary>
        /// 批量更新
        /// </summary>
        /// <param name="list">数组</param>
        /// <returns></returns>
        public List<bool> UpdateRange(List<Sys_RoleAuthorize> list)
        {
            using (var db=DBHelper.GetWriteInstance())
            {
                return db.UpdateRange(list);
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public bool Delete(Expression<Func<Sys_RoleAuthorize, bool>> predicate)
        {
            using (var db = DBHelper.GetWriteInstance())
            {
                return db.Delete(predicate);
            }
        }
        /// <summary>
        /// 查询单个实体
        /// </summary>
        /// <param name="predicate">lamda表达式</param>
        /// <returns></returns>
        public Sys_RoleAuthorize FindEntity(Expression<Func<Sys_RoleAuthorize, bool>> predicate)
        {
            using (var db = DBHelper.GetReadInstance())
            {
                return db.Queryable<Sys_RoleAuthorize>().Single(predicate);
            }
        }
        /// <summary>
        /// 直接写sql查询
        /// </summary>
        /// <param name="strSql">sql语句</param>
        /// <returns></returns>
        public List<Sys_RoleAuthorize> FindList(string strSql)
        {
            using (var db = DBHelper.GetReadInstance())
            {
                return db.SqlQuery<Sys_RoleAuthorize>(strSql);
            }
        }
        /// <summary>
        /// 动态参数拼sql形式查询
        /// </summary>
        /// <param name="strSql">sql语句</param>
        /// <param name="pars">参数数组</param>
        /// <returns></returns>
        public List<Sys_RoleAuthorize> FindList(string strSql,List<SqlParameter> pars)
        {
            using (var db = DBHelper.GetReadInstance())
            {
                return db.SqlQuery<Sys_RoleAuthorize>(strSql, pars);
            }
        }
        /// <summary>
        /// 根据查询条件，查询列表数据
        /// </summary>
        /// <param name="predicate">lamda表达式</param>
        /// <returns></returns>
        public List<Sys_RoleAuthorize> FindList(Expression<Func<Sys_RoleAuthorize, bool>> predicate)
        {
            using (var db = DBHelper.GetReadInstance())
            {
                return db.Queryable<Sys_RoleAuthorize>().Where(predicate).ToList();
            }
        }
        /// <summary>
        /// 根据查询条件，查询列表数据，并排序
        /// </summary>
        /// <param name="predicate">lamda表达式</param>
        /// <param name="orderbyPredicate">排序lamda表达式</param>
        /// <param name="ordertype">排序方式</param>
        /// <returns></returns>
        public List<Sys_RoleAuthorize> FindList(Expression<Func<Sys_RoleAuthorize, bool>> predicate, Expression<Func<Sys_RoleAuthorize, object>> orderbyPredicate, OrderByType ordertype = OrderByType.Asc)
        {
            using (var db = DBHelper.GetReadInstance())
            {
                return db.Queryable<Sys_RoleAuthorize>().Where(predicate).OrderBy(orderbyPredicate, ordertype).ToList();
            }
        }
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="predicate">查询条件</param>
        /// <param name="pagination">分页组件</param>
        /// <returns></returns>
        public List<Sys_RoleAuthorize> FindPageList(Expression<Func<Sys_RoleAuthorize, bool>> predicate, Pagination pagination)
        {
            using (var db=DBHelper.GetReadInstance())
            {
                var tempData = db.Queryable<Sys_RoleAuthorize>().Where(predicate).OrderBy(pagination.sidx);
                pagination.records = tempData.Count();
                return tempData.ToPageList(pagination.page, pagination.rows);
            }
        }
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="pagination">分页组件</param>
        /// <returns></returns>
        public List<Sys_RoleAuthorize> FindPageList(Pagination pagination)
        {
            using (var db = DBHelper.GetReadInstance())
            {
                var tempData = db.Queryable<Sys_RoleAuthorize>().OrderBy(pagination.sidx);
                pagination.records = tempData.Count();
                return tempData.ToPageList(pagination.page, pagination.rows);
            }
        }
        /// <summary>
        /// 检查是否存在记录，存在返回true,否则返回false
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public bool Exists(Expression<Func<Sys_RoleAuthorize, bool>> predicate)
        {
            using (var db=DBHelper.GetReadInstance())
            {
                return db.Queryable<Sys_RoleAuthorize>().Any(predicate);
            }
        }
    }
}
