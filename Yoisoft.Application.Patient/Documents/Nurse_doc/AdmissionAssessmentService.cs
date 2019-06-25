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
    public class AdmissionAssessmentService : RepositoryFactory
    {
        #region 属性 构造函数
        private string fieldSql;
        public AdmissionAssessmentService()
        {
            fieldSql = @"     
                     t.ID,
                     t.PATIENTID,
                     t.ADMISSION_METHOD,
                     t.SANITARY_DISPOSAL,
                     t.BRIEF_ILLNESS,
                     t.TEMPERATURE,
                     t.PULSE,
                     t.BREATHING,
                     t.BP1,
                     t.CONSCIOUSNESS,
                     t.EXPRESSION,
                     t.FACE_COLOR,
                     t.OTHER_FACE_COLOR,
                     t.HEIGHT,
                     t.WEIGHT,
                     t.LOSE_WEIGHT,
                     t.WEIGHT_LOSS_WEIGHT,
                     t.FIGURE,
                     t.OTHER_FIGURE,
                     t.SKIN,
                     t.SKIN_BEDSORE_SITE,
                     t.SKIN_BEDSORE_SIZE,
                     t.SKIN_PLUMPNESS,
                     t.EDEMA_SITE,
                     t.DEGREE_OF_EDEMA,
                     t.ORAL_MUCOSA,
                     t.OTHER_ORAL_MUCOSA,
                     t.FALSE_TEETH,
                     t.APPETITE,
                     t.DIET,
                     t.MICTURITION,
                     t.URINE_COLOR,
                     t.DEFECATION,
                     t.TIMES_OF_DIARRHOEA,
                     t.STOOL_COLOR,
                     t.ACTIVITY,
                     t.SELF_CARE_ABILITY,
                     t.SELF_CARE_ABILITY_DRESSING,
                     t.SLEEP,
                     t.NAME_OF_SLEEPING_AGENT,
                     t.SLEEPING_DOSE,
                     t.OTHER,
                     t.OTHER_OTHER,
                     t.HEARING,
                     t.OTHER_HEARING,
                     t.PAIN,
                     t.PART_OF_PAIN,
                     t.PROPERTIES_OF_PAIN,
                     t.TIME_OF_PAIN,
                     t.PAIN_INTERVAL_TIME,
                     t.DIET_TABOO,
                     t.DIET_PREFERENCE,
                     t.SMOKE,
                     t.NUMBER_OF_SMOKING,
                     t.SMOKING_TIME,
                     t.TIME_FOR_SMOKING_CESSATION,
                     t.DRINK_WINE,
                     t.ALCOHOL_CONSUMPTION,
                     t.NAME_OF_DRINKING,
                     t.ABSTINENCE_TIME,
                     t.DRUG,
                     t.DRUG_NAME,
                     t.DRUG_USE,
                     t.DRUG_TIME,
                     t.TIME_FOR_DRUG_ABSTINENCE,
                     t.ANAPHYLAXIS,
                     t.NAME_OF_ALLERGY_HISTORY,
                     t.ALLERGY_HISTORY_REACTION,
                     t.HAVE_DISEASE,
                     t.HAD_SURGERY_BEFORE,
                     t.FAMILY_HISTORY,
                     t.COMMUNICATIO_MODE,
                     t.EXPRESSION_AND_COMPREHENSION,
                     t.COMMUNICATE_WITH_PEOPLE,
                     t.KNOWLEDGE_OF_DISEASE,
                     t.PRIVATE_PROSECUTION,
                     t.INPATIENT_CONCERNS,
                     t.OTHER_INPATIENT_CONCERNS,
                     t.RECENT_PERSONAL_EVENTS,
                     t.OTHER_RECENT_PERSONAL_EVENTS,
                     t.FAMILY_ATTITUDE,
                     t.MEDICAL_EXPENSE,
                     t.MEMBER_OF_FAMILY,
                     t.ADMISSION_HOSPITAL,
                     t.SOURCE_INFORMATION,
                     t.OTHER_SOURCE_INFORMATION,
                     t.RECORD_NURSE,
                     t.RECORDING_TIME,
                     t.ACTUAL_RECORDING_TIME,
                     t.SIGNATURE_SUPERIOR_NURSE,
                     t.SAVE_TYPE,
                     t.PRESSURE_ULCER_SCORE,
                     t.INCREASED_FREQUENCY_DEFECATION,
                     t.OTHER_DEFECATION,
                     t.OTHER_STOOL_COLOR,
                     t.OTHER_FEELINGS,
                     t.ALLERGIC_FOOD,
                     t.ALLERGY_HISTORY,
                     t.FALL_SCORE,
                     t.SANITARY_DISPOSAL_OTHER,
                     t.ATTENDING_DOCTOR,
                     t.BP2,
                     t.EXPRESSION_OTHER,
                     t.DIET_OTHER,
                     t.MICTURITION_OTHER,
                     t.URINE_COLOR_OTHER,
                     t.ACTIVITY_OTHER,
                     t.ACTIVITY_HEMIPLEGIA,
                     t.ACTIVITY_PARAPLEGIA,
                     t.ACTIVITY_PARAPLEGIA_POSITION,
                     t.SELF_CARE_ABILITY_HELP,
                     t.COMMUNICATIO_MODE_OTHER,
                     t.INPATIENT_CONCERNS_HAVE                        
                        ";
        }
        #endregion
        #region 数据 查询

        public IEnumerable<AdmissionAssessmentEntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_nurse_aua t ");
                return this.BaseRepository().FindList<AdmissionAssessmentEntity>(strSql.ToString(), pagination);
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

        public IEnumerable<AdmissionAssessmentEntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_nurse_aua  t");
                return this.BaseRepository().FindList<AdmissionAssessmentEntity>(strSql.ToString());
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

        public IQueryable<AdmissionAssessmentEntity> IQueryRecord(Expression<Func<AdmissionAssessmentEntity, bool>> condition)
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


        public AdmissionAssessmentEntity GetEntity(string keyValue)
        {
            try
            {
                return this.BaseRepository().FindEntity<AdmissionAssessmentEntity>(t => t.ID == keyValue);
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
                AdmissionAssessmentEntity entity = new AdmissionAssessmentEntity()
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
        public void SaveEntity(AdmissionAssessmentEntity entity)
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

        public void UpdateEntity(AdmissionAssessmentEntity entity)
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
