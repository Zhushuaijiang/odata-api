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

    public class SYS_REPORTCARDService : RepositoryFactory
    {
        #region 属性 构造函数
        private string fieldSql;
        public SYS_REPORTCARDService()
        {
            fieldSql = @" t.ID,
                          t.SCHEMEID,
                          t.SCHEMEVER,
                          t.PATIENTID,
                          t.TEMPLETENAME,
                          t.CREATETIME,
                          t.CREATEUSERID,
                          t.CREATEUSER,
                          t.MODIFYTIME,
                          t.MODIFYUSERID,
                          t.MODIFYUSER,
                          t.ISDEL,
                          t.RELATIONID
                        ";
        }
        #endregion
        #region 数据 查询

        public IEnumerable<SYS_REPORTCARDEntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM YY_SYS_REPORTCARD t ");
                return this.BaseRepository().FindList<SYS_REPORTCARDEntity>(strSql.ToString(), pagination);
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

        public IEnumerable<SYS_REPORTCARDEntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM YY_SYS_REPORTCARD  t");
                return this.BaseRepository().FindList<SYS_REPORTCARDEntity>(strSql.ToString());
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

        public IQueryable<SYS_REPORTCARDEntity> IQueryRecord(Expression<Func<SYS_REPORTCARDEntity, bool>> condition)
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


        public SYS_REPORTCARDEntity GetEntity(string keyValue)
        {
            try
            {
                return this.BaseRepository().FindEntity<SYS_REPORTCARDEntity>(t => t.ID == keyValue);
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
        public void PhysicalDelRecord(string keyValue)
        {
            try
            {
                SYS_REPORTCARDEntity entity = new SYS_REPORTCARDEntity()
                {
                    ID = keyValue
                };
                this.BaseRepository().Delete(entity);
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
        /// 修改
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="userEntity">用户实体</param>
        /// <returns></returns>
        public void SaveEntity(SYS_REPORTCARDEntity entity)
        {
            try
            {
                this.BaseRepository().Insert(entity);

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

        public void UpdateEntity(SYS_REPORTCARDEntity entity)
        {
            try
            {
                this.BaseRepository().Update(entity);
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





