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

    public class TemplatesService : RepositoryFactory
    {
        #region 属性 构造函数
        private string fieldSql;
        public TemplatesService()
        {
            fieldSql = @" t.MBID,
                          t.ITEMID,
                          t.FLMC1,
                          t.FLMC2,
                          t.MBMC,
                          t.NR,
                          t.SYFW,
                          t.CJRID,
                          t.KID,
                          t.DEL
                        ";
        }
        #endregion
        #region 数据 查询

        public IEnumerable<TemplatesEntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_xt_mb t ");
                return this.BaseRepository().FindList<TemplatesEntity>(strSql.ToString(), pagination);
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

        public IEnumerable<TemplatesEntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_xt_mb  t");
                return this.BaseRepository().FindList<TemplatesEntity>(strSql.ToString());
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


        public IQueryable<TemplatesEntity> IQueryRecord(Expression<Func<TemplatesEntity, bool>> condition)
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

        public TemplatesEntity GetEntity(string keyValue)
        {
            try
            {

                return this.BaseRepository().FindEntity<TemplatesEntity>(t => t.MBID == keyValue);
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
                TemplatesEntity entity = new TemplatesEntity()
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
        public void SaveEntity(TemplatesEntity entity)
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

        public void UpdateEntity(TemplatesEntity entity)
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







