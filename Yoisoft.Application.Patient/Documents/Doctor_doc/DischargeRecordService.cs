
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

    public class DischargeRecordService : RepositoryFactory
    {
        #region 属性 构造函数
        private string fieldSql;
        public DischargeRecordService()
        {
            fieldSql = @" t.PATIENTID,
                          t.MEDICAL_RECORD_DIAGNOSIS,
                          t.MEDICAL_RECORDID,
                          t.DIAGNOSIS_AND_TREATMENT,
                          t.DISCHARGE_IS,
                          t.DISCHARGESTATE,
                          t.WRITING_DOCTORS,
                          t.RECORDTIME,
                          t.WRITINGTIME,
                          t.WRITINGSTATE,
                          t.SUPERIOR_DOCTORS,
                          t.INSPECT_COMPANY,   
                          t.SUPERIOR_DOCTORS,
                          t.CURATIVE_EFFECT_EVALUATE,     
                          t.DISCHARGE_WITH_MEDICINE,
                          t.OUTADMITTIME,
                          t.PATHOLOGY_NUMBER,
                          t.B_ULTRASOUND_NUMBER,   
                          t.X_FILM_NUMBER,
                          t.MR_NUMBER,     
                          t.CT_NUMBER,
                          t.PET_NUMBER   
                          t.ECT_NUMBER,
                          t.DISCHARGE_ORDER,   
                          t.MATTERS_NEEDING_ATTENTION,
                          t.REVISITTIME     
                       
                        ";
        }
        #endregion
        #region 数据 查询

        public IEnumerable<DischargeRecordEntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_doctors_discharge_record t ");
                return this.BaseRepository().FindList<DischargeRecordEntity>(strSql.ToString(), pagination);
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

        public IEnumerable<DischargeRecordEntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_doctors_discharge_record  t");
                return this.BaseRepository().FindList<DischargeRecordEntity>(strSql.ToString());
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

        public IQueryable<DischargeRecordEntity> IQueryRecord(Expression<Func<DischargeRecordEntity, bool>> condition)
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


        public DischargeRecordEntity GetEntity(string keyValue)
        {
            try
            {
                return this.BaseRepository().FindEntity<DischargeRecordEntity>(t => t.PATIENTID == keyValue);
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
                DischargeRecordEntity entity = new DischargeRecordEntity()
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
        public void SaveEntity(string keyValue, DischargeRecordEntity entity)
        {
            try
            {
                int itemp = 0;
                if (int.TryParse(keyValue, out itemp))
                {
                    if (itemp != 0)
                        this.BaseRepository().Insert(entity);
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

        public void UpdateEntity(DischargeRecordEntity entity)
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



