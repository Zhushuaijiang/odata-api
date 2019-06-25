using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Util;

namespace Yoisoft.Application.Patient.Patient
{
    /// <summary>
    /// 病人基本信息（主索引）
    /// </summary>
    public class PatientViewEntity : IBaseEntity
    {
        public int? ADMISSION_WARDCODE { get; set; }
        /// <summary> 序号 </summary>

        public int? DEPTCODE { get; set; }
        /// <summary> 项目名称 </summary>

        public int? WARDCODE { get; set; }
        /// <summary> 项目内容备注 </summary>

        public int? DISCHARGE_WARDCODE { get; set; }
        /// <summary> 字段名称 </summary>

        public DateTime? OUTADMITTIME { get; set; }
        /// <summary> 父项目编码</summary>

        public int? NUMBER_OF_HOSPITALIZATION { get; set; }
        /// <summary> 分值 </summary>

        public string BEDNO { get; set; }
        /// <summary> 选项类别 0:文字   1:单选   2.多选</summary>

        public string NAME { get; set; }
        /// <summary> 顺序 </summary>

        public int? SEX { get; set; }
        /// <summary> 表单类型 </summary>

        public DateTime? BIRTHDATE { get; set; }

        public int? AGE { get; set; }

        public string AGE_UNIT { get; set; }

        public string HOMEPLACE { get; set; }

        public int? MARRIAGEID { get; set; }

        public int? SCHOOLID { get; set; }

        public int? CAREERID { get; set; }

        public int? RACEID { get; set; }

        public int? RACENAME { get; set; }

        public int? NATIONALITYID { get; set; }

        public string IDCARD { get; set; }

        public string UNIT { get; set; }

        public string UNITADDRESS { get; set; }

        public string UNITTELEPHONE { get; set; }

        public string UNITZIPCODE { get; set; }

        public string RESIDENCE_PLACE1 { get; set; }

        public string RESIDENCE_PLACE2 { get; set; }

        public string RESIDENCE_PLACE3 { get; set; }

        public string RESIDENCE_PLACE4 { get; set; }

        public string PRESENT_PLACE1 { get; set; }

        public string PRESENT_PLACE2 { get; set; }

        public string PRESENT_PLACE3 { get; set; }

        public string PRESENT_PLACE4 { get; set; }

        public string FAMILY_ZIPCODE { get; set; }

        public string FAMILY_TELEPHONE { get; set; }

        public string MOBILE { get; set; }

        public string CONTACTSNAME1 { get; set; }

        public int? CONTACTSRELATION1 { get; set; }

        public string CONTACTSADDRESS1 { get; set; }

        public string CONTACTSTELEPHONE1 { get; set; }

        public string CONTACTSNAME2 { get; set; }

        public int? CONTACTSRELATION2 { get; set; }

        public string CONTACTSADDRESS2 { get; set; }

        public string CONTACTSTELEPHONE2 { get; set; }

        public int? HOSPITALIZATIONDAYS { get; set; }

        public string CLINIC_DIAGNOSIS { get; set; }

        public string INADMI_DIAGNOSIS { get; set; }

        public string INADMI_STATUS { get; set; }

        public string OUTADMIT_STATUS { get; set; }

        public DateTime? DIAGNOSISDATE { get; set; }

        public string FAITH { get; set; }

        public int? COST_TYPE { get; set; }

        public int? STATEID { get; set; }

        public string ATTNDOCTOR { get; set; }

        public string DIRECTORNURSE { get; set; }

        public int? ISCONTAGION { get; set; }

        public string MEDICALHISTORY_DOCTOR { get; set; }

        public string TAKEOVER_DOCTOR { get; set; }

        public string SUPERIOR_DOCTORS { get; set; }

        public int? NURSING_LEVEL { get; set; }

        public string HANDLE { get; set; }

        public string ADVANCE_PAYMENT { get; set; }

        public string PATHOLOGICAL_NUMBER { get; set; }

        public string XFILM_NUMBER { get; set; }

        public string MRI_NUMBER { get; set; }

        public string CT_NUMBER { get; set; }

        public string ECT_NUMBER { get; set; }

        public string BPD_NUMBER { get; set; }

        public DateTime? INADMITTIME { get; set; }

        public string OPENBILL_DOCTOR { get; set; }

        public int? CASEHISTORY_STATE { get; set; }

        public DateTime? SUBMISSION_TIME { get; set; }

        public string SUBMISSION_PEOPLE { get; set; }

        public string CASEHISTORY_SOURCE { get; set; }

        public string CASEHISTORY_INPUTER { get; set; }

        public string CLINIC_NUMBER { get; set; }

        public int? FOLLOWUP_STATE { get; set; }

        public string PHYSIOLOGY_STATE { get; set; }

        public string EMAIL { get; set; }

        public string HISPATIENTID { get; set; }

        public string MRN { get; set; }

        public DateTime? HISINADMITTIME { get; set; }
        [Key]
        public string PATIENTID { get; set; }

        public string PARENTNAME { get; set; }

        public string MOTHERPATIENTID { get; set; }

        public string BIRTHTIME { get; set; }

        public int? CASEHISTORYTYPE { get; set; }

        public string GESTATIONAL_AGE { get; set; }

        public string NATIVE_PLACE { get; set; }

        public string OCCUPATION { get; set; }

        public string PARENTIDCARD { get; set; }

        public string PREGNANCY_PERMIT { get; set; }

        public string MEDICALCARE_GROUP { get; set; }

        public string SEXNAME { get; set; }

        public string CAREERNAME { get; set; }

        public string SCHOOLNAME { get; set; }

        public string WARDNAME { get; set; }

        public string USNAME { get; set; }

        public string MARRIAGENAME { get; set; }

        public string FEENAME { get; set; }

        public string JTZZ { get; set; }

        public string STATENAME { get; set; }

        public string RELATIONNAME { get; set; }

        public string DEPTNAME { get; set; }

        public string KDUSNAME { get; set; }

        public string RESIDENCE_ZIPCODE { get; set; }

        public int? CPSTATE { get; set; }

        public string CPID { get; set; }

        public int? INADMI_CHANNEL { get; set; }

        public int? INSPECT { get; set; }

        public string ZTBTY { get; set; }

        public string VTE { get; set; }

        public string MORSE { get; set; }

        public string VTEC { get; set; }

        public string RESIDENCE_AREANUMBER { get; set; }

        public string PRESENT_AREANUMBER { get; set; }

        public string MORSE2 { get; set; }

        public string RESPONSIBILITY_NUSER { get; set; }

        public string QUALITYCONTROL_NUSER { get; set; }
    }
}
