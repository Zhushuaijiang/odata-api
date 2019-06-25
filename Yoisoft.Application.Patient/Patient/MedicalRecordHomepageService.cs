using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.DataBase.Repository;
using Yoisoft.Util;
namespace Yoisoft.Application.Patient.Patient
{

    public class MedicalRecordHomepageService : RepositoryFactory
    {
        #region 属性 构造函数
        private string fieldSql;
        public MedicalRecordHomepageService()
        {
            fieldSql = @"     
                   t.ID,
                   t.PATIENTID,
                   t.MRN,
                   t.INADMIWAY,
                   t.TREATMENT_CATEGORY,
                   t.IMPLEMENT_CLINICAL_PATHWAY,
                   t.CNMEDICINE_PREPARATION,
                   t.CNMEDICIN_MEDICAL_EQUIPMENT,
                   t.CNMEDICIN_MEDICAL_TECHNOLOGY,
                   t.DIALECTICAL_CARE,
                   t.OUTPATIENT_DIAGNOSIS_CN,
                   t.OUTPATIENT_DISEASE_CODE_CN,
                   t.OUTPATIENT_DIAGNOSIS_WESTERN,
                   t.DISEASE_CODE_WESTERN,
                   t.INJURY_POISONING,
                   t.PATHOLOGY_DIAGNOSIS,
                   t.PATHOLOGY_DISEASE_CODE,
                   t.PATHOLOGY_NUMBER,
                   t.DRUG_ALLERGY,
                   t.ALLERGY_DRUG,
                   t.BLOOD_GROUP,
                   t.RH,
                   t.AUTOPSY,
                   t.LEAVING_WAY,
                   t.INSTITUTION_NAME,
                   t.WHETHER_TOADMIT,
                   t.TOADMIT_PURPOSE,
                   t.ADMITBEFORE_DAY,
                   t.ADMITBEFORE_HOUSE,
                   t.ADMITBEFORE_MIN,
                   t.ADMITAFTER_DAY,
                   t.ADMITAFTER_HOUSE,
                   t.ADMITAFTER_MIN,
                   t.KDIRECTOR_NAME,
                   t.DIRECTOR_NAME,
                   t.ATTNDOCTOR_NAME,
                   t.RESIDENT_NAME,
                   t.RESPONSIBLE_NURSE,
                   t.STUDIE_NAME,
                   t.INTERN_NAME,
                   t.CODER,
                   t.CASE_QUALITY,
                   t.QUALITYDOCTOR,
                   t.QUALITYNURSE,
                   t.RECORDDATE,
                   t.SINGLE_DISEASE,
                   t.HOSPITAL_INFECTION,
                   t.INFECTION_DESCRIPTION,
                   t.BLOOD_REACTION,
                   t.CP_MANAGE,
                   t.DIAGNOSISSITUATION_MC,
                   t.DIAGNOSISSITUATION_RC,
                   t.DIAGNOSISSITUATION_SQSH,
                   t.DIAGNOSISSITUATION_LB,
                   t.DIAGNOSISSITUATION_FB,
                   t.RESCUE_SITUATION,
                   t.RESCUES_NUMBER,
                   t.SUCCESS_NUMBER,
                   t.ISCRITICAL,
                   t.EMERGENCY,
                   t.DIFFICULT_SITUATION,
                   t.RETURN_SITUATION,
                   t.CASE_CLASSIFICATION,
                   t.SURGERY_INFECTION,
                   t.DATEOFDIAGNOSIS,
                   t.REENTRY_SURGERY,
                   t.COMPLICATIONS,
                   t.COMPLICATION_SITE,
                   t.COMPLICATION_SITE_OTHER,
                   t.PAYMENT_METHODS,
                   t.TOTAL_COST,
                   t.SELFPAYAMOUNT,
                   t.SERVICE_FEE,
                   t.OPERATE_FEE,
                   t.NURSING_FEE,
                   t.OTHER_FEES,
                   t.PATHOLOGICAL_DIAGNOSIS_FEE,
                   t.LABORATORY_FEE,
                   t.VIDEO_FEE,
                   t.CLINICAL_FEE,
                   t.NONSURGERY_FEE,
                   t.CLINICALPHYSICS_FEE,
                   t.OPERATION_CURE_FEE,
                   t.HOCUS_FEE,
                   t.OPERATION_FEE,
                   t.RECOVERY_FEE,
                   t.CNMEDICIN_TREATMENT_FEE,
                   t.CNMEDICINE_DIAGNOSIS_FEE,
                   t.CNMEDICIN_TREATMENT,
                   t.CNMEDICIN_EXTERNAL_FEE,
                   t.CNMEDICIN_BONEINJURY_FEE,
                   t.ACUPUNCTURE_AND_MOXIBUSTION,
                   t.CNMEDICIN_MASSAGE,
                   t.CNMEDICIN_ANORECTAL,
                   t.CNMEDICIN_SPECIAL,
                   t.CNMEDICIN_OTHER,
                   t.CNMEDICIN_MACHINING,
                   t.DIALECTICAL_DIET,
                   t.WESTERN_MEDICINE_FEE,
                   t.ANTIBACTERIAL_DRUGS_FEE,
                   t.CNMEDICIN_MEDICINE_FEE,
                   t.CNHERBAL_MEDICINE_FEE,
                   t.BLOOD_FEE,
                   t.ALBUMIN_FEE,
                   t.GLOBULIN_FEE,
                   t.CLOTTINGFACTOR_FEE,
                   t.CELLFACTOR_FEE,
                   t.CHECK_MATERIAL_FEE,
                   t.TREATMENT_MATERIAL_FEE,
                   t.OPERATION_MATERIAL_FEE,
                   t.OTHER_FEE,
                   t.ISNEW,
                   t.WRITINGSTATE,
                   t.BIRTH_WEIGHT,
                   t.ADMISSION_WEIGHT,
                   t.HBS,
                   t.HCV,
                   t.HIV,
                   t.FILL_TIME,
                   t.WRITING_TIME,
                   t.RECORDING_TIME,
                   t.RECORDING_DOCTORID,
                   t.RECORDING_DOCTORNAME,
                   t.SYPHILIS_ANTIBODY,
                   t.POISONING_CODE
                        ";
        }
        #endregion
        #region 数据 查询

        public IEnumerable<MedicalRecordHomepageEntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_medical_record_homepage t ");
                return this.BaseRepository().FindList<MedicalRecordHomepageEntity>(strSql.ToString(), pagination);
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

        public IEnumerable<MedicalRecordHomepageEntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_medical_record_homepage t");
                return this.BaseRepository().FindList<MedicalRecordHomepageEntity>(strSql.ToString());
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

        public IQueryable<MedicalRecordHomepageEntity> IQueryRecord(Expression<Func<MedicalRecordHomepageEntity, bool>> condition)
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


        public MedicalRecordHomepageEntity GetEntity(string keyValue)
        {
            try
            {
                return this.BaseRepository().FindEntity<MedicalRecordHomepageEntity>(t => t.ID == keyValue);
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

        public MedicalRecordHomepageEntity GetEntityByPatientID(string keyValue)
        {
            try
            {

                return this.BaseRepository().FindEntity<MedicalRecordHomepageEntity>(t => t.PATIENTID.ToString() == keyValue);
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
                MedicalRecordHomepageEntity entity = new MedicalRecordHomepageEntity()
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
        public int SaveEntity(string keyValue, MedicalRecordHomepageEntity patientEntity)
        {
            try
            {
                if (string.IsNullOrEmpty(keyValue))
                {
                    patientEntity.PATIENTID = GetKey();
                    return this.BaseRepository().Insert(patientEntity);
                }
                else
                {

                    return this.BaseRepository().Update(patientEntity);
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
        public string GetKey()
        {
            try
            {
                var strSql = "select seq_yy_medical_record_homepage.nextval from dual";
                return this.BaseRepository().FindTable(strSql).Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                return Guid.NewGuid().ToString("N");
            }
        }

        public int UpdateEntity(MedicalRecordHomepageEntity entity)
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
