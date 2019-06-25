using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.DataBase.Repository;
using Yoisoft.Util;

namespace Yoisoft.Application.Base.RecordSystem
{
    public class RecordReviewService : RepositoryFactory
    {
        //
        #region 属性 构造函数
        private string fieldSql;
        public RecordReviewService()
        {
            fieldSql = @" t.id,
                          t.pid,
                          t.name,
                          t.type,
                          t.url,
                          t.title,
                          t.icon,
                          t.xh,
                          t.category
                        ";
        }
        #endregion

        #region 数据 查询
        public IEnumerable<RecordReviewEntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_xt_RecordReview t ");
                return this.BaseRepository().FindList<RecordReviewEntity>(strSql.ToString(), pagination);
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
        public IEnumerable<RecordReviewEntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_xt_RecordReview  t");
                return this.BaseRepository().FindList<RecordReviewEntity>(strSql.ToString());
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
        public IQueryable<RecordReviewEntity> IQueryRecord(Expression<Func<RecordReviewEntity, bool>> condition)
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
        /// 获取项目列表 主键
        /// </summary>
        /// <returns></returns>
        public RecordReviewEntity RecordQuery(string keyvalue)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_xt_RecordReview  t where ID=@ID");
                return this.BaseRepository().FindEntity<RecordReviewEntity>(strSql.ToString(), new { ID = Convert.ToInt32(keyvalue) });
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
        /// 查询实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public RecordReviewEntity GetEntity(int keyValue)
        {
            try
            {
                return this.BaseRepository().FindEntity<RecordReviewEntity>(t => t.ID == keyValue);
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
        //物理删除
        public void PhysicalDelRecord(int keyValue)
        {
            try
            {
                RecordReviewEntity entity = new RecordReviewEntity()
                {
                    ID = keyValue
                };
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
        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="userEntity">实体对象</param>
        public void UpdateEntity(RecordReviewEntity recordReviewEntity)
        {
            try
            {
                this.BaseRepository().Update(recordReviewEntity);
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
        public void SaveEntity(RecordReviewEntity recordReviewEntity)
        {
            try
            {
                if (!ExistEntity(recordReviewEntity.ID.ToString()))
                {
                    this.BaseRepository().Insert(recordReviewEntity);
                }

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

        #region
        public bool ExistEntity(string keyValue)
        {
            try
            {
                var expression = LinqExtensions.True<RecordReviewEntity>();
                expression = expression.And(t => t.ID == Convert.ToInt32(keyValue));
                return this.BaseRepository().IQueryable(expression).Count() == 0 ? true : false;
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
