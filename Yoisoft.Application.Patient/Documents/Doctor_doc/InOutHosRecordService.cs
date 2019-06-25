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
    public class InOutHosRecordService : RepositoryFactory
    {
        #region 属性 构造函数
        private string fieldSql;
        public InOutHosRecordService()
        {
            fieldSql = @" t.PATIENTID,
                          t.CHIEF_COMPLAINT,
                          t.ADMISSION_IS,                           
                          t.DIAGNOSIS_AND_TREATMENT,
                          t.DISCHARGE_IS,
                          t.DISCHARGESTATE,
                          t.WRITING_DOCTORS,
                          t.RECORDTIME,
                          t.WRITINGTIME,
                          t.SUPERIOR_DOCTORS,
                          t.OUTADMITTIME,
                          t.WRITINGSTATE,
                          t.PRESENT_ILLNESS,
                          t.DISCHARGE_ORDER
                        ";
        }
        #endregion
        #region 数据 查询

        public IEnumerable<InOutHosRecordEntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_doctors_inouthosrecord t ");
                return this.BaseRepository().FindList<InOutHosRecordEntity>(strSql.ToString(), pagination);
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

        public IEnumerable<InOutHosRecordEntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_doctors_inouthosrecord  t");
                return this.BaseRepository().FindList<InOutHosRecordEntity>(strSql.ToString());
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
                var strSql = "select seq_admission_record.nextval from dual";
                return this.BaseRepository().FindTable(strSql).Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                return Guid.NewGuid().ToString("N");
            }
        }
        public IQueryable<InOutHosRecordEntity> IQueryRecord(Expression<Func<InOutHosRecordEntity, bool>> condition)
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
        public InOutHosRecordEntity GetEntity(string keyValue)
        {
            try
            {
                return this.BaseRepository().FindEntity<InOutHosRecordEntity>(t => t.PATIENTID == keyValue);
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
                InOutHosRecordEntity entity = new InOutHosRecordEntity()
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
        public void SaveEntity(string keyValue,InOutHosRecordEntity entity)
        {
            try
            {
                if (keyValue != "")
                {
                    entity.PATIENTID = keyValue;
                }
                else
                {
                    entity.PATIENTID = GetKey();
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

        public void UpdateEntity(InOutHosRecordEntity entity)
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
