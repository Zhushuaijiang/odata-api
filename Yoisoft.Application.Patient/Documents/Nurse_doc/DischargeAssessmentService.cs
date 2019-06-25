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
    public class DischargeAssessmentService : RepositoryFactory
    {
        #region 属性 构造函数
        private string fieldSql;
        public DischargeAssessmentService()
        {
            fieldSql = @"     
                     t.ID,
                     t.PATIENTID,
                     t.ADMISSION_DATE,
                     t.OPERATION_DATE,
                     t.DISCHARGE_DATE,
                     t.OPERATIVE_NAME,
                     t.DISCHARGE_DIAGNOSIS_CHINESE,
                     t.DISCHARGE_DIAGNOSIS_WESTERN,
                     t.PROGNOSIS_DISEASE,
                     t.KNOWLEDGE_DISEASE,
                     t.MENTALITY,
                     t.SELF_CARE_ABILITY,
                     t.SKIN_CONDITION,
                     t.COMPLICATION,
                     t.MEDICAL_ADVICE,
                     t.SPECIAL_MEDICATION_GUIDANCE,
                     t.OTHER_MEDICATION_GUIDANCE,
                     t.DAILY_LIFE,
                     t.EMOTION_REGULATION,
                     t.DIET_CONDITIONING,
                     t.DAILY_ROUTINE,
                     t.FUNCTIONAL_EXERCISE,
                     t.SPECIAL_GUIDANCE,
                     t.NURSE_NAME,
                     t.NURSE_ID,
                     t.HEAD_NURSE_NAME,
                     t.HEAD_NURSE_ID,
                     t.RECORD_DATE,
                     t.SAVE_STATE,
                     t.SKIN_CONDITION_OTHER          
                        ";
        }
        #endregion
        #region 数据 查询

        public IEnumerable<DischargeAssessmentEntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_nurse_da t ");
                return this.BaseRepository().FindList<DischargeAssessmentEntity>(strSql.ToString(), pagination);
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

        public IEnumerable<DischargeAssessmentEntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_nurse_da  t");
                return this.BaseRepository().FindList<DischargeAssessmentEntity>(strSql.ToString());
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
        public IQueryable<DischargeAssessmentEntity> IQueryRecord(Expression<Func<DischargeAssessmentEntity, bool>> condition)
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
                var strSql = "select seq_dischargeassessment.nextval from dual";
                return this.BaseRepository().FindTable(strSql).Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                return Guid.NewGuid().ToString("N");
            }
        }


        public DischargeAssessmentEntity GetEntity(string keyValue)
        {
            try
            {
                return this.BaseRepository().FindEntity<DischargeAssessmentEntity>(t => t.ID == keyValue);
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
                DischargeAssessmentEntity entity = new DischargeAssessmentEntity()
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
        public void SaveEntity(string keyValue,DischargeAssessmentEntity entity)
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

        public void UpdateEntity(DischargeAssessmentEntity entity)
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
