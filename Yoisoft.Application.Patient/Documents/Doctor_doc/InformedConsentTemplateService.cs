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
 
    public class InformedConsentTemplateService : RepositoryFactory
    {
        #region 属性 构造函数
        private string fieldSql;
        public InformedConsentTemplateService()
        {
            fieldSql = @" t.ID,
                          t.MBID,
                          t.MBNR,                           
                          t.MBPYM,
                          t.HOSID,
                          t.HOSNAME,
                          t.SYKS,
                          t.SYZB,
                          t.CJR,
                          t.CJSJ,
                          t.DEL,
                          t.FL,
                          t.PLSX,
                          t.PMBID,
                          t.PYM
                        ";
        }
        #endregion
        #region 数据 查询

        public IEnumerable<InformedConsentTemplateEntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_xy_mb t ");
                return this.BaseRepository().FindList<InformedConsentTemplateEntity>(strSql.ToString(), pagination);
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

        public IEnumerable<InformedConsentTemplateEntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_xy_mb  t");
                return this.BaseRepository().FindList<InformedConsentTemplateEntity>(strSql.ToString());
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
        public IQueryable<InformedConsentTemplateEntity> IQueryRecord(Expression<Func<InformedConsentTemplateEntity, bool>> condition)
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

        public string GetKey()
        {
            try
            {
                var strSql = "select SEQ_YY_XY_MB.nextval from dual";
                return this.BaseRepository().FindTable(strSql).Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                return Guid.NewGuid().ToString("N");
            }
        }

        public InformedConsentTemplateEntity GetEntity(string keyValue)
        {
            try
            {
                return this.BaseRepository().FindEntity<InformedConsentTemplateEntity>(t => t.MBID == keyValue);
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
                InformedConsentTemplateEntity entity = new InformedConsentTemplateEntity()
                {
                    MBID = keyValue
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
        public void SaveEntity(string keyValue, InformedConsentTemplateEntity entity)
        {
            try
            {
                if (keyValue != "")
                {
                    entity.MBID = keyValue;
                }
                else
                {
                    entity.MBID = GetKey();
                }
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

        public void UpdateEntity(InformedConsentTemplateEntity entity)
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
