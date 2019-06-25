using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Application.Patient.Patient;
using Yoisoft.DataBase.Repository;
using Yoisoft.Util;

namespace Yoisoft.Application.Patient.Patient
{
    public class PatientService : RepositoryFactory
    {

        #region 属性 构造函数
        private string fieldSql;
        public PatientService()
        {
            fieldSql = @"     
                     t.PATIENTID,
                     t.ADMISSION_WARDCODE,
                     t.DEPTCODE,
                     t.WARDCODE,
                     t.DISCHARGE_WARDCODE,
                     t.OUTADMITTIME,
                     t.INADMITTIME,
                     t.NUMBER_OF_HOSPITALIZATION,
                     t.BEDNO,
                     t.NAME,
                     t.HOMEPLACE,
                     t.SEX,
                     t.MARRIAGEID,
                     t.SCHOOLID,
                     t.CAREERID,
                     t.RACEID,
                     t.RACENAME,
                     t.NATIONALITYID,
                     t.IDCARD,
                     t.UNITADDRESS,
                     t.UNIT,
                     t.UNITTELEPHONE,
                     t.UNITZIPCODE,
                     t.RESIDENCE_PLACE1,
                     t.RESIDENCE_PLACE2,
                     t.RESIDENCE_PLACE3,
                     t.RESIDENCE_PLACE4,
                     t.PRESENT_PLACE1,
                     t.PRESENT_PLACE2,
                     t.PRESENT_PLACE3,
                     t.PRESENT_PLACE4,
                     t.FAMILY_ZIPCODE,
                     t.FAMILY_TELEPHONE,
                     t.MOBILE,
                     t.CONTACTSNAME1,
                     t.CONTACTSRELATION1,
                     t.CONTACTSADDRESS1,
                     t.CONTACTSTELEPHONE1,
                     t.CONTACTSNAME2,
                     t.CONTACTSRELATION2,
                     t.CONTACTSADDRESS2,
                     t.CONTACTSTELEPHONE2,
                     t.HOSPITALIZATIONDAYS,
                     t.CLINIC_DIAGNOSIS,
                     t.INADMI_DIAGNOSIS,
                     t.INADMI_STATUS,
                     t.OUTADMIT_STATUS,
                     t.DIAGNOSISDATE,
                     t.FAITH,
                     t.COST_TYPE,
                     t.STATEID,
                     t.ATTNDOCTOR,
                     t.DIRECTORNURSE,
                     t.ISCONTAGION,
                     t.MEDICALHISTORY_DOCTOR,
                     t.TAKEOVER_DOCTOR,
                     t.SUPERIOR_DOCTORS,
                     t.NURSING_LEVEL,
                     t.HANDLE,
                     t.ADVANCE_PAYMENT,
                     t.PATHOLOGICAL_NUMBER,
                     t.XFILM_NUMBER,
                     t.MRI_NUMBER,
                     t.CT_NUMBER,
                     t.ECT_NUMBER,
                     t.BPD_NUMBER,
                     t.ACTUAL_INADMITTIME,
                     t.OPENBILL_DOCTOR,
                     t.CASEHISTORY_STATE,
                     t.SUBMISSION_TIME,
                     t.SUBMISSION_PEOPLE,
                     t.CASEHISTORY_SOURCE,
                     t.CASEHISTORY_INPUTER,
                     t.CLINIC_NUMBER,
                     t.FOLLOWUP_STATE,
                     t.PHYSIOLOGY_STATE,
                     t.EMAIL,
                     t.HISPATIENTID,
                     t.MRN,
                     t.HISINADMITTIME,
                     t.CASEHISTORYTYPE,
                     t.MOTHERPATIENTID,
                     t.PARENTNAME,
                     t.BIRTHTIME,
                     t.GESTATIONAL_AGE,
                     t.AGE_UNIT,
                     t.NATIVE_PLACE,
                     t.OCCUPATION,
                     t.SPARE_TELEPHONE1,
                     t.PARENTIDCARD,
                     t.PREGNANCY_PERMIT,
                     t.MEDICALCARE_GROUP,
                     t.RESIDENCE_ZIPCODE,
                     t.INADMI_CHANNEL,
                     t.CPSTATE,
                     t.CPID,
                     t.ZEYFBZ,
                     t.INSPECT,
                     t.VTE,
                     t.ZTBTY,
                     t.MORSE,
                     t.WOUND_ASSESSMENT_REPORT,
                     t.TJZT,
                     t.VTEC,
                     t.RESIDENCE_AREANUMBER,
                     t.PRESENT_AREANUMBER,
                     t.SKPFSBSJ,
                     t.MORSE2,
                     t.RESPONSIBILITY_NUSER,
                     t.QUALITYCONTROL_NUSER,
                     t.COHESIVE_SIGN,
                     t.YCSBSJ,
                     t.YCJKZT,
                     t.YCPF,
                     t.SKZG,
                     t.BIRTHDATE,
                     t.AGE,
                     t.CHIEF_DOCTOR
                        ";
        }
        #endregion
        #region 病人实体表
        #region 数据 查询
        /// <summary>
        /// 获取病区科室列表-分页
        /// </summary>
        /// <param name="pagination"></param>
        /// <returns></returns>
        public IEnumerable<PatientEntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_sys_patient t ");
                return this.BaseRepository().FindList<PatientEntity>(strSql.ToString(), pagination);
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

        public IEnumerable<PatientEntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_sys_patient  t");
                return this.BaseRepository().FindList<PatientEntity>(strSql.ToString());
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
        public IQueryable<PatientEntity> IQueryRecord(Expression<Func<PatientEntity, bool>> condition)
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
                var strSql = "select seq_yy_sys_patient.nextval from dual";
                return this.BaseRepository().FindTable(strSql).Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                return Guid.NewGuid().ToString("N");
            }
        }
        public PatientEntity GetEntity(string keyValue)
        {
            try
            {
                return this.BaseRepository().FindEntity<PatientEntity>(keyValue);
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
        public IEnumerable<PatientEntity> RecordQuery(string keyValue)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(string.Format(" FROM yy_sys_patient  t where patientid='{0}'", keyValue));
                return this.BaseRepository().FindList<PatientEntity>(strSql.ToString());
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
                PatientEntity entity = new PatientEntity()
                {
                    PATIENTID = keyValue,
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

        public void SaveEntity(string keyValue, PatientEntity patientEntity)
        {
            try
            {
                if (string.IsNullOrEmpty(keyValue))
                {
                    patientEntity.PATIENTID = GetKey();
                    this.BaseRepository().Insert(patientEntity);
                }
                else
                {

                    this.BaseRepository().Update(patientEntity);
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

        public void UpdateEntity(PatientEntity patientEntity)
        {
            try
            {
                this.BaseRepository().Update(patientEntity);
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

        #endregion
    }
}
