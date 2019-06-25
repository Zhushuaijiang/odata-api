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
    public class BradenScoreService : RepositoryFactory
    {
        #region 属性 构造函数
        private string fieldSql;
        public BradenScoreService()
        {
            fieldSql = @"     
             t.ID,
             t.PATIENTID,
             t.FEEL,
             t.DAMP,
             t.ACTIVITY,
             t.ACTIVITY_ABILITY,
             t.NUTRITION,
             t.FRICTION_SHEARFORCE,
             t.TOTAL_SCORE,
             t.SCOREUSERID,
             t.SCORESTATE,
             t.PAGENUMBER,
             t.SCORETIME,
             t.UPDATETIME,
             t.SUPERIOR_NURSE,
             t.TO_EXAMINE,
             t.ND_OPINION,
             t.HEADNURSE_OPINION,
             t.NDDIRECTOR_OPINION,
             t.ND_AUTOGRAPH,
             t.NDDIRECTOR_AUTOGRAPH,
             t.HEADNURSE_AUTOGRAPH
                        ";
        }
        #endregion
        #region 数据 查询

        public IEnumerable<BradenScoreEntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_nurse_BradenScore t ");
                return this.BaseRepository().FindList<BradenScoreEntity>(strSql.ToString(), pagination);
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

        public IEnumerable<BradenScoreEntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_nurse_BradenScore t");
                return this.BaseRepository().FindList<BradenScoreEntity>(strSql.ToString());
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
        public IQueryable<BradenScoreEntity> IQueryRecord(Expression<Func<BradenScoreEntity, bool>> condition)
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
        /// 获取主键
        /// </summary>
        /// <returns></returns>
        public string GetKey()
        {
            try
            {
                var strSql = "select seq_yy_nurse_BradenScore.nextval from dual";
                return this.BaseRepository().FindTable(strSql).Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                return Guid.NewGuid().ToString("N");
            }
        }


        public BradenScoreEntity GetEntity(string keyValue)
        {
            try
            {
                return this.BaseRepository().FindEntity<BradenScoreEntity>(t => t.ID == keyValue);
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
                BradenScoreEntity entity = new BradenScoreEntity()
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
        public void SaveEntity(string keyValue, BradenScoreEntity entity)
        {
            try
            {
                if (keyValue != "")
                {
                    entity.ID = keyValue;
                }
                else
                {
                    entity.ID = GetKey();
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

        public void UpdateEntity(BradenScoreEntity entity)
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
