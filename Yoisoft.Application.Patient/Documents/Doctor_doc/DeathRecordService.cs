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

    public class DeathRecordService : RepositoryFactory
    {
        #region 属性 构造函数
        private string fieldSql;
        public DeathRecordService()
        {
            fieldSql = @" t.PATIENTID,
                          t.INADMI_SITUATION,
                          t.DIAGNOSIS_AND_TREATMENT,
                          t.DEATH_CAUSE,
                          t.DEATH_DIAGNOSIS,
                          t.WRITING_DOCTORS,
                          t.DEATH_DISCUSSDATE,
                          t.DEATH_DISCUSSTIME,
                          t.DEATH_DISCUSSPLACE,
                          t.HOST,
                          t.PARTICIPANTS,
                          t.LAST_DIAGNOSIS,
                          t.DT_ADVICE,
                          t.DISCUSS_NOTETAKER,
                          t.DISCUSS_NOTETIME,
                          t.WRITINGTIME,
                          t.RECORDTIME,
                          t.WRITINGSTATE,
                          t.SUPERIOR_DOCTORS,
                          t.DEATH_TIME,
                          t.MAIN_COMPLAINT,
                          t.DISCUSSION_RESULTS
                         
                        ";
        }
        #endregion
        #region 数据 查询

        public IEnumerable<DeathRecordEntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_doctors_death_record t ");
                return this.BaseRepository().FindList<DeathRecordEntity>(strSql.ToString(), pagination);
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

        public IEnumerable<DeathRecordEntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_doctors_death_record  t");
                return this.BaseRepository().FindList<DeathRecordEntity>(strSql.ToString());
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


        public IQueryable<DeathRecordEntity> IQueryRecord(Expression<Func<DeathRecordEntity, bool>> condition)
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

        public DeathRecordEntity GetEntity(string keyValue)
        {
            try
            {
                return this.BaseRepository().FindEntity<DeathRecordEntity>(t => t.PATIENTID == keyValue);
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
        public int PhysicalDelRecord(string keyValue)
        {
            try
            {
                DeathRecordEntity entity = new DeathRecordEntity()
                {
                    PATIENTID = keyValue
                };
                return this.BaseRepository().Delete(entity);
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
        public int SaveEntity(string keyValue, DeathRecordEntity entity)
        {
            try
            {
                if (!string.IsNullOrEmpty(keyValue))
                {
                    return this.BaseRepository().Insert(entity);
                }
                else
                {
                    return 0;
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

        public int UpdateEntity(DeathRecordEntity entity)
        {
            try
            {
                return this.BaseRepository().Update(entity);
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

