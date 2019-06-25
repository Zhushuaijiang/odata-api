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

    public class SYS_RIGHTBARService : RepositoryFactory
    {
        #region 属性 构造函数
        private string fieldSql;
        public SYS_RIGHTBARService()
        {
            fieldSql = @" t.ID,
                          t.DIVID,
                          t.CDDR,
                          t.CDDI,
                          t.URL,
                          t.STATE
                        ";
        }
        #endregion
        #region 数据 查询

        public IEnumerable<SYS_RIGHTBAREntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM YY_SYS_RIGHTBAR t ");
                return this.BaseRepository().FindList<SYS_RIGHTBAREntity>(strSql.ToString(), pagination);
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

        public IEnumerable<SYS_RIGHTBAREntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM YY_SYS_RIGHTBAR  t");
                return this.BaseRepository().FindList<SYS_RIGHTBAREntity>(strSql.ToString());
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


        public IQueryable<SYS_RIGHTBAREntity> IQueryRecord(Expression<Func<SYS_RIGHTBAREntity, bool>> condition)
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

        public SYS_RIGHTBAREntity GetEntity(string keyValue)
        {
            try
            {
                int id = 0;
                int.TryParse(keyValue, out id);
                return this.BaseRepository().FindEntity<SYS_RIGHTBAREntity>(t => t.ID == id);
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
                SYS_RIGHTBAREntity entity = new SYS_RIGHTBAREntity()
                {
                    ID = Convert.ToInt32(keyValue)
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
        public void SaveEntity(SYS_RIGHTBAREntity entity)
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

        public void UpdateEntity(SYS_RIGHTBAREntity entity)
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






