using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.DataBase.Repository;
using Yoisoft.Util;

namespace Yoisoft.Application.Patient
{
    public class InformedConsentContentService : RepositoryFactory
    {
        #region 属性 构造函数
        private string fieldSql;
        public InformedConsentContentService()
        {
            fieldSql = @" t.ID,
                          t.MBID,
                          t.TITLE,                           
                          t.CONTENT,
                          t.TIME,
                          t.PATIENTID,
                          t.WRITING_DOCTORS,
                          t.TYPE,
                          t.DEL,
                          t.WSSQWSID
                        ";
        }
        #endregion
        #region 数据 查询

        public IEnumerable<InformedConsentContentEntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_xy_content t ");
                return this.BaseRepository().FindList<InformedConsentContentEntity>(strSql.ToString(), pagination);
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

        public IEnumerable<InformedConsentContentEntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_xy_content  t");
                return this.BaseRepository().FindList<InformedConsentContentEntity>(strSql.ToString());
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

        public IQueryable<InformedConsentContentEntity> IQueryRecord(Expression<Func<InformedConsentContentEntity, bool>> condition)
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


        public InformedConsentContentEntity GetEntity(string keyValue)
        {
            try
            {
                return this.BaseRepository().FindEntity<InformedConsentContentEntity>(t => t.ID == keyValue);
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
                InformedConsentContentEntity entity = new InformedConsentContentEntity()
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
        public void SaveEntity(string keyValue, InformedConsentContentEntity entity)
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

        public void UpdateEntity(InformedConsentContentEntity entity)
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
