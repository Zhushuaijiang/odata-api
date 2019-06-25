using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoisoft.Application.Patient
{
    public class PatientEntity
    {
        /// <summary> 病人序号ID </summary>
        [Key]
        public string PATIENTID { get; set; }
        /// <summary> 入院病区代码 </summary>

        public int? ADMISSION_WARDCODE { get; set; }
        /// <summary> 科室代码 </summary>

        public int? DEPTCODE { get; set; }
        /// <summary> 病区代码 </summary>

        public int? WARDCODE { get; set; }
        /// <summary> 出院病区代码 </summary>

        public int? DISCHARGE_WARDCODE { get; set; }
        /// <summary> 出院时间 </summary>

        public DateTime? OUTADMITTIME { get; set; }
        /// <summary> 入院时间 </summary>

        public DateTime? INADMITTIME { get; set; }
        /// <summary> 住院次数 </summary>

        public int? NUMBER_OF_HOSPITALIZATION { get; set; }
        /// <summary> 床号 </summary>

        public string BEDNO { get; set; }
        /// <summary> 姓名 </summary>

        public string NAME { get; set; }
        /// <summary> 出生地 </summary>

        public string HOMEPLACE { get; set; }
        /// <summary> 性别 </summary>

        public int? SEX { get; set; }
        /// <summary> 婚姻 </summary>

        public int? MARRIAGEID { get; set; }
        /// <summary> 学历 </summary>

        public int? SCHOOLID { get; set; }
        /// <summary> 职业 </summary>

        public int? CAREERID { get; set; }
        /// <summary> 民族 </summary>

        public int? RACEID { get; set; }
        /// <summary> 民族名称 </summary>

        public int? RACENAME { get; set; }
        /// <summary> 国籍 </summary>

        public int? NATIONALITYID { get; set; }
        /// <summary> 身份证号 </summary>

        public string IDCARD { get; set; }
        /// <summary> 单位地址 </summary>

        public string UNITADDRESS { get; set; }
        /// <summary> 工作单位 </summary>

        public string UNIT { get; set; }
        /// <summary> 单位电话 </summary>

        public string UNITTELEPHONE { get; set; }
        /// <summary> 单位邮编 </summary>

        public string UNITZIPCODE { get; set; }
        /// <summary> 户口地1 </summary>

        public string RESIDENCE_PLACE1 { get; set; }
        /// <summary> 户口地2 </summary>

        public string RESIDENCE_PLACE2 { get; set; }
        /// <summary> 户口地3 </summary>

        public string RESIDENCE_PLACE3 { get; set; }
        /// <summary> 户口地4 </summary>

        public string RESIDENCE_PLACE4 { get; set; }
        /// <summary> 现住地1 </summary>

        public string PRESENT_PLACE1 { get; set; }
        /// <summary> 现住地2 </summary>

        public string PRESENT_PLACE2 { get; set; }
        /// <summary> 现住地3 </summary>

        public string PRESENT_PLACE3 { get; set; }
        /// <summary> 现住地4 </summary>

        public string PRESENT_PLACE4 { get; set; }
        /// <summary> 家庭邮编 </summary>

        public string FAMILY_ZIPCODE { get; set; }
        /// <summary> 家庭电话 </summary>

        public string FAMILY_TELEPHONE { get; set; }
        /// <summary> 手机号码 </summary>

        public string MOBILE { get; set; }
        /// <summary> 第一联系人姓名 </summary>

        public string CONTACTSNAME1 { get; set; }
        /// <summary> 第一联系人与患者关系 </summary>

        public int? CONTACTSRELATION1 { get; set; }
        /// <summary> 第一联系人地址 </summary>

        public string CONTACTSADDRESS1 { get; set; }
        /// <summary> 第一联系人电话 </summary>

        public string CONTACTSTELEPHONE1 { get; set; }
        /// <summary> 第二联系人姓名 </summary>

        public string CONTACTSNAME2 { get; set; }
        /// <summary> 第二联系人与患者关系 </summary>

        public int? CONTACTSRELATION2 { get; set; }
        /// <summary> 第二联系人地址 </summary>

        public string CONTACTSADDRESS2 { get; set; }
        /// <summary> 第二联系人电话 </summary>

        public string CONTACTSTELEPHONE2 { get; set; }
        /// <summary> 住院天数 </summary>

        public int? HOSPITALIZATIONDAYS { get; set; }
        /// <summary> 门诊诊断 </summary>

        public string CLINIC_DIAGNOSIS { get; set; }
        /// <summary> 入院诊断 </summary>

        public string INADMI_DIAGNOSIS { get; set; }
        /// <summary> 入院时状况 </summary>

        public string INADMI_STATUS { get; set; }
        /// <summary> 出院时状况 </summary>

        public string OUTADMIT_STATUS { get; set; }
        /// <summary> 确诊日期 </summary>

        public DateTime? DIAGNOSISDATE { get; set; }
        /// <summary> 信仰 </summary>

        public string FAITH { get; set; }
        /// <summary> 费用类型 </summary>

        public int? COST_TYPE { get; set; }
        /// <summary> 在院状态，（见状态码表）1：在院；3：预出院；10：归档 </summary>

        public int? STATEID { get; set; }
        /// <summary> 主治医师ID </summary>

        public string ATTNDOCTOR { get; set; }
        /// <summary> 主管护士ID </summary>

        public string DIRECTORNURSE { get; set; }
        /// <summary> 0-不是传染病1-是传染病 </summary>

        public int? ISCONTAGION { get; set; }
        /// <summary> 病史书写医师ID </summary>

        public string MEDICALHISTORY_DOCTOR { get; set; }
        /// <summary> 接管医师ID </summary>

        public string TAKEOVER_DOCTOR { get; set; }
        /// <summary> 上级医师ID </summary>

        public string SUPERIOR_DOCTORS { get; set; }
        /// <summary> 护理级别，默认的为三级1-一级护理,2-二级护理,3-三级护 </summary>

        public int? NURSING_LEVEL { get; set; }
        /// <summary> 处理 </summary>

        public string HANDLE { get; set; }
        /// <summary> 住院预缴款 </summary>

        public string ADVANCE_PAYMENT { get; set; }
        /// <summary> 病理号 </summary>

        public string PATHOLOGICAL_NUMBER { get; set; }
        /// <summary> X片号 </summary>

        public string XFILM_NUMBER { get; set; }
        /// <summary> MRI号 </summary>

        public string MRI_NUMBER { get; set; }
        /// <summary> CT号 </summary>

        public string CT_NUMBER { get; set; }
        /// <summary> ECT号 </summary>

        public string ECT_NUMBER { get; set; }
        /// <summary> B超号 </summary>

        public string BPD_NUMBER { get; set; }
        /// <summary> 实际住院时间 </summary>

        public DateTime? ACTUAL_INADMITTIME { get; set; }
        /// <summary> 开单医师 </summary>

        public string OPENBILL_DOCTOR { get; set; }
        /// <summary> 病历状态，在科－1，医生提交或护士提交－0，归档－1，修改－ </summary>

        public int? CASEHISTORY_STATE { get; set; }
        /// <summary> 病历提交时间 </summary>

        public DateTime? SUBMISSION_TIME { get; set; }
        /// <summary> 提交人ID </summary>

        public string SUBMISSION_PEOPLE { get; set; }
        /// <summary> 病历来源 </summary>

        public string CASEHISTORY_SOURCE { get; set; }
        /// <summary> 病历录入者ID </summary>

        public string CASEHISTORY_INPUTER { get; set; }
        /// <summary> 门诊就诊卡号 </summary>

        public string CLINIC_NUMBER { get; set; }
        /// <summary> 随访状态 </summary>

        public int? FOLLOWUP_STATE { get; set; }
        /// <summary> 病生理状态 </summary>

        public string PHYSIOLOGY_STATE { get; set; }
        /// <summary> 邮箱 </summary>

        public string EMAIL { get; set; }
        /// <summary> HIS住院ID（病人每次住院一个ID） </summary>

        public string HISPATIENTID { get; set; }
        /// <summary> HIS病案号 </summary>

        public string MRN { get; set; }
        /// <summary> HIS住院时间 </summary>

        public DateTime? HISINADMITTIME { get; set; }
        /// <summary> 病历类型：0、null普通病人，1新生婴儿，2儿科病人，3产科病人，4妇科病人 </summary>

        public int? CASEHISTORYTYPE { get; set; }
        /// <summary> 母亲的住院序号 </summary>

        public string MOTHERPATIENTID { get; set; }
        /// <summary> 父母姓名 </summary>

        public string PARENTNAME { get; set; }
        /// <summary> 出生时分秒 </summary>

        public string BIRTHTIME { get; set; }
        /// <summary> 胎龄 </summary>

        public string GESTATIONAL_AGE { get; set; }
        /// <summary> 年龄单位 </summary>

        public string AGE_UNIT { get; set; }
        /// <summary> 籍贯 </summary>

        public string NATIVE_PLACE { get; set; }
        /// <summary> 职业名称 </summary>

        public string OCCUPATION { get; set; }
        /// <summary> 第一联系人备用电话 </summary>

        public string SPARE_TELEPHONE1 { get; set; }
        /// <summary> 父母身份证号 </summary>

        public string PARENTIDCARD { get; set; }
        /// <summary> 准生证号 </summary>

        public string PREGNANCY_PERMIT { get; set; }
        /// <summary> 医疗组 </summary>

        public string MEDICALCARE_GROUP { get; set; }
        /// <summary> 户口邮编 </summary>

        public string RESIDENCE_ZIPCODE { get; set; }
        /// <summary> 入院途径 </summary>

        public int? INADMI_CHANNEL { get; set; }

        public int? CPSTATE { get; set; }

        public string CPID { get; set; }

        public int? ZEYFBZ { get; set; }
        /// <summary> 检查 </summary>

        public int? INSPECT { get; set; }

        public string VTE { get; set; }

        public string ZTBTY { get; set; }

        public string MORSE { get; set; }
        /// <summary> 伤口评估上报 </summary>

        public string WOUND_ASSESSMENT_REPORT { get; set; }

        public string TJZT { get; set; }

        public string VTEC { get; set; }
        /// <summary> 户口地址行政辖区编号 </summary>

        public string RESIDENCE_AREANUMBER { get; set; }
        /// <summary> 现住地行政辖区编号 </summary>

        public string PRESENT_AREANUMBER { get; set; }

        public string SKPFSBSJ { get; set; }

        public string MORSE2 { get; set; }
        /// <summary> 责任护士 </summary>

        public string RESPONSIBILITY_NUSER { get; set; }
        /// <summary> 质控护士 </summary>

        public string QUALITYCONTROL_NUSER { get; set; }
        /// <summary> 衔接标志 </summary>

        public int? COHESIVE_SIGN { get; set; }

        public string YCSBSJ { get; set; }

        public string YCJKZT { get; set; }

        public string YCPF { get; set; }

        public string SKZG { get; set; }
        /// <summary> 出生日期 </summary>

        public DateTime? BIRTHDATE { get; set; }
        /// <summary> 年龄 </summary>

        public int? AGE { get; set; }
        /// <summary> 主诊医师 </summary>

        public string CHIEF_DOCTOR { get; set; }
    }
}
