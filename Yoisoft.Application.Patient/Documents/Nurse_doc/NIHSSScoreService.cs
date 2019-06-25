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
    public class NIHSSScoreService : RepositoryFactory
    {
        #region 属性 构造函数
        private string fieldSql;
        public NIHSSScoreService()
        {
            fieldSql = @"     
                     t.ID,
                     t.PATIENTID,
                     t.SCOREUSERID,
                     t.SCORESTATE,
                     t.PAGENUMBER,
                     t.SCORETIME,
                     t.UPDATETIME,
                     t.SUPERIOR_NURSE,
                     t.TO_EXAMINE,
                     t.TOTAL_SCORE,
                     t.CON_LEVEL,
                     t.CON_LEVEL_QUIZ,
                     t.CON_LEVEL_DIRECTIVE,
                     t.GAZE,
                     t.FIELD,
                     t.FACIOPLEGIA,
                     t.UPLIMB_MOVEMENTS,
                     t.DOLIMB_MOVEMENTS,
                     t.ATAXIA_LIMBS,
                     t.FEEL,
                     t.LANGUAGE,
                     t.ARTICULATION_DISORDER,
                     t.IGNORE
                   
                        ";
        }
        #endregion
        #region 数据 查询

        public IEnumerable<NIHSSScoreEntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM YY_NURSE_NIHSSSCORE t ");
                return this.BaseRepository().FindList<NIHSSScoreEntity>(strSql.ToString(), pagination);
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

        public IEnumerable<NIHSSScoreEntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM YY_NURSE_NIHSSSCORE  t");
                return this.BaseRepository().FindList<NIHSSScoreEntity>(strSql.ToString());
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

        public IQueryable<NIHSSScoreEntity> IQueryRecord(Expression<Func<NIHSSScoreEntity, bool>> condition)
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
                var strSql = "select SEQ_YY_NURSE_NIHSSSCORE.nextval from dual";
                return this.BaseRepository().FindTable(strSql).Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                return Guid.NewGuid().ToString("N");
            }
        }


        public NIHSSScoreEntity GetEntity(string keyValue)
        {
            try
            {
                return this.BaseRepository().FindEntity<NIHSSScoreEntity>(t => t.ID == keyValue);
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
                NIHSSScoreEntity entity = new NIHSSScoreEntity()
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
        public void SaveEntity(string keyValue,NIHSSScoreEntity entity)
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

        public void UpdateEntity(NIHSSScoreEntity entity)
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
