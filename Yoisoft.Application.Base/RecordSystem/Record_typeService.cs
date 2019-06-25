using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.DataBase.Repository;
using Yoisoft.Util;

namespace Yoisoft.Application.Base
{
    public class Record_typeService : RepositoryFactory
    {
        #region 属性 构造函数
        private string fieldSql;
        public Record_typeService()
        {
            fieldSql = @" t.ITEMID,
                          t.XMID,
                          t.XMNAME,
                          t.XMSM,
                          t.ORDERINDEX,
                          t.DEL_FLAG,
                          t.SCHEMEID
                        ";
        }
        #endregion
        #region 数据 查询
        public IEnumerable<Record_typeEntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM t_xt_item t ");
                return this.BaseRepository().FindList<Record_typeEntity>(strSql.ToString(), pagination);
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }
        }
        /// <summary>
        /// 获取项目列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Record_typeEntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM t_xt_item  t");
                return this.BaseRepository().FindList<Record_typeEntity>(strSql.ToString());
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }
        }
        public IQueryable<Record_typeEntity> IQueryRecord(Expression<Func<Record_typeEntity, bool>> condition)
        {
            try
            {
                return this.BaseRepository().IQueryable(condition);
            }
            catch (Exception ex)
            {

                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }

        }

        /// <summary>
        /// 获取项目列表
        /// </summary>
        /// <returns></returns>
        public Record_typeEntity RecordQuery(int key1, int key2)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM t_xt_item  t where t.ITEMID=@ITEMID AND t.XMID=@XMID");
                return this.BaseRepository().FindEntity<Record_typeEntity>(strSql.ToString(),
                    new { ITEMID = Convert.ToInt32(key1), XMID = Convert.ToInt32(key2) });
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }
        }

        /// <summary>
        /// 获取主键
        /// </summary>
        /// <returns></returns>
        public string GetKey()
        {
            //try
            //{
            //    var strSql = "select seq_yy_sys_patient.nextval from dual";
            //    return this.BaseRepository().FindTable(strSql).Rows[0][0].ToString();
            //}
            //catch (Exception ex)
            //{
            //    return Guid.NewGuid().ToString("N");
            //}
            return Guid.NewGuid().ToString("N");
        }
        public Record_typeEntity GetEntity(string keyValue1, string keyValue2)
        {
            try
            {
                int id1 = 0;
                int.TryParse(keyValue1, out id1);
                int id2 = 0;
                int.TryParse(keyValue2, out id2);
                return this.BaseRepository().FindEntity<Record_typeEntity>(t =>
                t.ITEMID == id1 && t.XMID == id2);
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }
        }

        #endregion

        #region 操作数据
        public void VirtualDelRecord(int keyValue1, int keyValue2)
        {
            try
            {
                Record_typeEntity entity = new Record_typeEntity()
                {
                    ITEMID = Convert.ToInt32(keyValue1),
                    XMID = Convert.ToInt32(keyValue2),
                    DEL_FLAG = "1"
                };
                var strSql = new StringBuilder();
                strSql.Append("update ");
                strSql.Append(" t_xt_item");
                strSql.Append(" set DEL_FLAG='1'");
                strSql.Append(" where ITEMID=@ITEMID and XMID=@XMID");
                this.BaseRepository().ExecuteBySql(strSql.ToString(),
                    new { ITEMID = keyValue1, XMID = keyValue2 });

            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }
        }

        public void SaveEntity(Record_typeEntity record_TypeEntity)
        {
            try
            {
                this.BaseRepository().Insert(record_TypeEntity);
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }
        }

        public void UpdateEntity(Record_typeEntity record_TypeEntity)
        {
            try
            {
                Record_typeEntity entity = new Record_typeEntity()
                {
                    ITEMID = record_TypeEntity.ITEMID,
                    XMID = record_TypeEntity.XMID,
                    ORDERINDEX = record_TypeEntity.ORDERINDEX,
                    SCHEMEID = record_TypeEntity.SCHEMEID,
                    XMNAME = record_TypeEntity.XMNAME,
                    XMSM = record_TypeEntity.XMSM,
                    DEL_FLAG = "1"
                };
                var strSql = new StringBuilder();
                strSql.Append("update ");
                strSql.Append(" t_xt_item");
                strSql.Append(string.Format(
                    @" set ORDERINDEX='{0}'
                            SCHEMEID='{1}',
                            XMNAME='{2}',
                            XMSM='{3}'",
                            entity.ORDERINDEX,
                            entity.SCHEMEID,
                            entity.XMNAME,
                            entity.XMSM
                    ));
                strSql.Append(" where ITEMID=@ITEMID and XMID=@XMID");
                this.BaseRepository().ExecuteBySql(strSql.ToString(),
                    new { entity.ITEMID, entity.XMID });

            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }
        }
        #endregion
    }
}
