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

    public class DOCTORS_24DEATH_RECORDService : RepositoryFactory
    {
        #region 属性 构造函数
        private string fieldSql;
        public DOCTORS_24DEATH_RECORDService()
        {
            fieldSql = @" t.PATIENTID,
                          t.DEATHTIME,
                          t.CHIEF_COMPLAINT,
                          t.ADMISSION_IS,
                          t.DIAGNOSIS_AND_TREATMENT,
                          t.DEATHHOSPITAL,
                          t.WRITING_DOCTORS,
                          t.RECORDTIME,
                          t.WRITINGTIME,
                          t.WRITINGSTATE,
                          t.SUPERIOR_DOCTORS,
                          t.OTHER,
                          t.BIRTHDATE
                        ";
        }
        #endregion
        #region 数据 查询

        public IEnumerable<DOCTORS_24DEATH_RECORDEntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_DOCTORS_24DEATH_RECORD t ");
                return this.BaseRepository().FindList<DOCTORS_24DEATH_RECORDEntity>(strSql.ToString(), pagination);
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

        public IEnumerable<DOCTORS_24DEATH_RECORDEntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_DOCTORS_24DEATH_RECORD  t");
                return this.BaseRepository().FindList<DOCTORS_24DEATH_RECORDEntity>(strSql.ToString());
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


        public IQueryable<DOCTORS_24DEATH_RECORDEntity> IQueryRecord(Expression<Func<DOCTORS_24DEATH_RECORDEntity, bool>> condition)
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

        public DOCTORS_24DEATH_RECORDEntity GetEntity(string keyValue)
        {
            try
            {
                return this.BaseRepository().FindEntity<DOCTORS_24DEATH_RECORDEntity>(t => t.PATIENTID == keyValue);
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
                DOCTORS_24DEATH_RECORDEntity entity = new DOCTORS_24DEATH_RECORDEntity()
                {
                    PATIENTID = keyValue
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
        public void SaveEntity(string keyValue, DOCTORS_24DEATH_RECORDEntity entity)
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

        public void UpdateEntity(DOCTORS_24DEATH_RECORDEntity entity)
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



