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
    
    public class CODE_DOCUMENTService : RepositoryFactory
    {
        #region 属性 构造函数
        private string fieldSql;
        public CODE_DOCUMENTService()
        {
            fieldSql = @" t.DOCUMENTTYPE,
                          t.DOCUMENTNAME,
                          t.MEDICALRECORD,
                          t.URL,
                          t.ORDERINDEX,
                          t.CHIEF_COMPLAINTSIGN,
                          t.CASEHISTORYSTYPE,
                          t.CATEGORY
                        ";
        }
        #endregion
        #region 数据 查询

        public IEnumerable<CODE_DOCUMENTEntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM YY_CODE_DOCUMENT t ");
                return this.BaseRepository().FindList<CODE_DOCUMENTEntity>(strSql.ToString(), pagination);
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

        public IEnumerable<CODE_DOCUMENTEntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM YY_CODE_DOCUMENT  t");
                return this.BaseRepository().FindList<CODE_DOCUMENTEntity>(strSql.ToString());
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

        public IQueryable<CODE_DOCUMENTEntity> IQueryRecord(Expression<Func<CODE_DOCUMENTEntity, bool>> condition)
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


        public CODE_DOCUMENTEntity GetEntity(string keyValue)
        {
            try
            {

                return this.BaseRepository().FindEntity<CODE_DOCUMENTEntity>(t => t.DOCUMENTTYPE == keyValue);
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
                CODE_DOCUMENTEntity entity = new CODE_DOCUMENTEntity()
                {
                    DOCUMENTTYPE = keyValue
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
        public void SaveEntity(CODE_DOCUMENTEntity entity)
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

        public void UpdateEntity(CODE_DOCUMENTEntity entity)
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
