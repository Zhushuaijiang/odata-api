using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Util;

namespace Yoisoft.Application.Patient.Patient
{
    public class MedicalRecordHomepageEntity:IBaseEntity
    {
        /// <summary> 编号 </summary>
        [Column("ID")]
        [Key]
        public string ID { get; set; }
        /// <summary> 病人住院序号 </summary>
        [Column("PATIENTID")]
        public string PATIENTID { get; set; }
        /// <summary> 病案编码，HIS病案号 </summary>
        [Column("MRN")]
        public string MRN { get; set; }
        /// <summary> 入院途径 </summary>
        [Column("INADMIWAY")]
        public int? INADMIWAY { get; set; }
        /// <summary> 治疗类别 </summary>
        [Column("TREATMENT_CATEGORY")]
        public string TREATMENT_CATEGORY { get; set; }
        /// <summary> 实施临床路径 </summary>
        [Column("IMPLEMENT_CLINICAL_PATHWAY")]
        public int? IMPLEMENT_CLINICAL_PATHWAY { get; set; }
        /// <summary> 自制中药制剂 </summary>
        [Column("CNMEDICINE_PREPARATION")]
        public int? CNMEDICINE_PREPARATION { get; set; }
        /// <summary> 使用中医诊疗设备 </summary>
        [Column("CNMEDICIN_MEDICAL_EQUIPMENT")]
        public int? CNMEDICIN_MEDICAL_EQUIPMENT { get; set; }
        /// <summary> 使用中医诊疗技术 </summary>
        [Column("CNMEDICIN_MEDICAL_TECHNOLOGY")]
        public int? CNMEDICIN_MEDICAL_TECHNOLOGY { get; set; }
        /// <summary> 辨证施护 </summary>
        [Column("DIALECTICAL_CARE")]
        public int? DIALECTICAL_CARE { get; set; }
        /// <summary> 门诊诊断（中医） </summary>
        [Column("OUTPATIENT_DIAGNOSIS_CN")]
        public string OUTPATIENT_DIAGNOSIS_CN { get; set; }
        /// <summary> 门诊疾病编码（中医） </summary>
        [Column("OUTPATIENT_DISEASE_CODE_CN")]
        public string OUTPATIENT_DISEASE_CODE_CN { get; set; }
        /// <summary> 门诊诊断（西医） </summary>
        [Column("OUTPATIENT_DIAGNOSIS_WESTERN")]
        public string OUTPATIENT_DIAGNOSIS_WESTERN { get; set; }
        /// <summary> 门诊疾病编码（西医） </summary>
        [Column("DISEASE_CODE_WESTERN")]
        public string DISEASE_CODE_WESTERN { get; set; }
        /// <summary> 损伤、中毒的外部原因 </summary>
        [Column("INJURY_POISONING")]
        public string INJURY_POISONING { get; set; }
        /// <summary> 病理诊断  </summary>
        [Column("PATHOLOGY_DIAGNOSIS")]
        public string PATHOLOGY_DIAGNOSIS { get; set; }
        /// <summary> 病理疾病编码 </summary>
        [Column("PATHOLOGY_DISEASE_CODE")]
        public string PATHOLOGY_DISEASE_CODE { get; set; }
        /// <summary> 病理号 </summary>
        [Column("PATHOLOGY_NUMBER")]
        public string PATHOLOGY_NUMBER { get; set; }
        /// <summary> 药物过敏 </summary>
        [Column("DRUG_ALLERGY")]
        public string DRUG_ALLERGY { get; set; }
        /// <summary> 过敏药物 </summary>
        [Column("ALLERGY_DRUG")]
        public string ALLERGY_DRUG { get; set; }
        /// <summary> 血型 </summary>
        [Column("BLOOD_GROUP")]
        public int? BLOOD_GROUP { get; set; }
        /// <summary> RH </summary>
        [Column("RH")]
        public int? RH { get; set; }
        /// <summary> 死亡患者尸检 </summary>
        [Column("AUTOPSY")]
        public int? AUTOPSY { get; set; }
        /// <summary> 离院方式 </summary>
        [Column("LEAVING_WAY")]
        public int? LEAVING_WAY { get; set; }
        /// <summary> 拟接收医疗机构名称 </summary>
        [Column("INSTITUTION_NAME")]
        public string INSTITUTION_NAME { get; set; }
        /// <summary> 是否有31天内再住院计划 </summary>
        [Column("WHETHER_TOADMIT")]
        public string WHETHER_TOADMIT { get; set; }
        /// <summary> 再住院计划目的 </summary>
        [Column("TOADMIT_PURPOSE")]
        public string TOADMIT_PURPOSE { get; set; }
        /// <summary> 颅脑损伤患者昏迷时间-入院前(天) </summary>
        [Column("ADMITBEFORE_DAY")]
        public string ADMITBEFORE_DAY { get; set; }
        /// <summary> 颅脑损伤患者昏迷时间-入院前(小时) </summary>
        [Column("ADMITBEFORE_HOUSE")]
        public string ADMITBEFORE_HOUSE { get; set; }
        /// <summary> 颅脑损伤患者昏迷时间-入院前(分钟) </summary>
        [Column("ADMITBEFORE_MIN")]
        public string ADMITBEFORE_MIN { get; set; }
        /// <summary> 颅脑损伤患者昏迷时间-入院后(天) </summary>
        [Column("ADMITAFTER_DAY")]
        public string ADMITAFTER_DAY { get; set; }
        /// <summary> 颅脑损伤患者昏迷时间-入院后(小时) </summary>
        [Column("ADMITAFTER_HOUSE")]
        public string ADMITAFTER_HOUSE { get; set; }
        /// <summary> 颅脑损伤患者昏迷时间-入院后(分钟) </summary>
        [Column("ADMITAFTER_MIN")]
        public string ADMITAFTER_MIN { get; set; }
        /// <summary> 科主任 </summary>
        [Column("KDIRECTOR_NAME")]
        public string KDIRECTOR_NAME { get; set; }
        /// <summary> 主任(副主任)医师 </summary>
        [Column("DIRECTOR_NAME")]
        public string DIRECTOR_NAME { get; set; }
        /// <summary> 主治医师 </summary>
        [Column("ATTNDOCTOR_NAME")]
        public string ATTNDOCTOR_NAME { get; set; }
        /// <summary> 住院医师 </summary>
        [Column("RESIDENT_NAME")]
        public string RESIDENT_NAME { get; set; }
        /// <summary> 责任护士 </summary>
        [Column("RESPONSIBLE_NURSE")]
        public string RESPONSIBLE_NURSE { get; set; }
        /// <summary> 进修医师 </summary>
        [Column("STUDIE_NAME")]
        public string STUDIE_NAME { get; set; }
        /// <summary> 实习医师 </summary>
        [Column("INTERN_NAME")]
        public string INTERN_NAME { get; set; }
        /// <summary> 编码员 </summary>
        [Column("CODER")]
        public string CODER { get; set; }
        /// <summary> 病案质量 </summary>
        [Column("CASE_QUALITY")]
        public int? CASE_QUALITY { get; set; }
        /// <summary> 质控医师 </summary>
        [Column("QUALITYDOCTOR")]
        public string QUALITYDOCTOR { get; set; }
        /// <summary> 质控护士 </summary>
        [Column("QUALITYNURSE")]
        public string QUALITYNURSE { get; set; }
        /// <summary> 日期 </summary>
        [Column("RECORDDATE")]
        public DateTime? RECORDDATE { get; set; }
        /// <summary> 单病种管理 </summary>
        [Column("SINGLE_DISEASE")]
        public int? SINGLE_DISEASE { get; set; }
        /// <summary> 医院感染情况 </summary>
        [Column("HOSPITAL_INFECTION")]
        public int? HOSPITAL_INFECTION { get; set; }
        /// <summary> 医院感染情况说明 </summary>
        [Column("INFECTION_DESCRIPTION")]
        public string INFECTION_DESCRIPTION { get; set; }
        /// <summary> 输血反应 </summary>
        [Column("BLOOD_REACTION")]
        public int? BLOOD_REACTION { get; set; }
        /// <summary> 临床路径管理 </summary>
        [Column("CP_MANAGE")]
        public int? CP_MANAGE { get; set; }
        /// <summary> 诊断符合情况-门诊与出院 </summary>
        [Column("DIAGNOSISSITUATION_MC")]
        public int? DIAGNOSISSITUATION_MC { get; set; }
        /// <summary> 诊断符合情况-入院与出院 </summary>
        [Column("DIAGNOSISSITUATION_RC")]
        public int? DIAGNOSISSITUATION_RC { get; set; }
        /// <summary> 诊断符合情况-术前与术后 </summary>
        [Column("DIAGNOSISSITUATION_SQSH")]
        public int? DIAGNOSISSITUATION_SQSH { get; set; }
        /// <summary> 诊断符合情况-临床与病理 </summary>
        [Column("DIAGNOSISSITUATION_LB")]
        public int? DIAGNOSISSITUATION_LB { get; set; }
        /// <summary> 诊断符合情况-放射与病理 </summary>
        [Column("DIAGNOSISSITUATION_FB")]
        public int? DIAGNOSISSITUATION_FB { get; set; }
        /// <summary> 抢救情况 </summary>
        [Column("RESCUE_SITUATION")]
        public int? RESCUE_SITUATION { get; set; }
        /// <summary> 抢救情况-抢救次数 </summary>
        [Column("RESCUES_NUMBER")]
        public int? RESCUES_NUMBER { get; set; }
        /// <summary> 抢救情况-成功次数 </summary>
        [Column("SUCCESS_NUMBER")]
        public int? SUCCESS_NUMBER { get; set; }
        /// <summary> 住院期间是否出现危重 </summary>
        [Column("ISCRITICAL")]
        public int? ISCRITICAL { get; set; }
        /// <summary> 急症 </summary>
        [Column("EMERGENCY")]
        public int? EMERGENCY { get; set; }
        /// <summary> 疑难情况 </summary>
        [Column("DIFFICULT_SITUATION")]
        public int? DIFFICULT_SITUATION { get; set; }
        /// <summary> 转归情况 </summary>
        [Column("RETURN_SITUATION")]
        public int? RETURN_SITUATION { get; set; }
        /// <summary> 病例分型 </summary>
        [Column("CASE_CLASSIFICATION")]
        public int? CASE_CLASSIFICATION { get; set; }
        /// <summary> 手术相关院内感染 </summary>
        [Column("SURGERY_INFECTION")]
        public int? SURGERY_INFECTION { get; set; }
        /// <summary> 入院后确诊日期 </summary>
        [Column("DATEOFDIAGNOSIS")]
        public DateTime? DATEOFDIAGNOSIS { get; set; }
        /// <summary> 非预期重返手术 </summary>
        [Column("REENTRY_SURGERY")]
        public int? REENTRY_SURGERY { get; set; }
        /// <summary> 并发症情况 </summary>
        [Column("COMPLICATIONS")]
        public string COMPLICATIONS { get; set; }
        /// <summary> 并发症部位 </summary>
        [Column("COMPLICATION_SITE")]
        public string COMPLICATION_SITE { get; set; }
        /// <summary> 并发症部位其他 </summary>
        [Column("COMPLICATION_SITE_OTHER")]
        public string COMPLICATION_SITE_OTHER { get; set; }
        /// <summary> 医疗付费方式 </summary>
        [Column("PAYMENT_METHODS")]
        public int? PAYMENT_METHODS { get; set; }
        /// <summary> 总费用 </summary>
        [Column("TOTAL_COST")]
        public string TOTAL_COST { get; set; }
        /// <summary> 自付金额 </summary>
        [Column("SELFPAYAMOUNT")]
        public string SELFPAYAMOUNT { get; set; }
        /// <summary> 一般医疗服务费 </summary>
        [Column("SERVICE_FEE")]
        public string SERVICE_FEE { get; set; }
        /// <summary> 一般治疗操作费 </summary>
        [Column("OPERATE_FEE")]
        public string OPERATE_FEE { get; set; }
        /// <summary> 护理费 </summary>
        [Column("NURSING_FEE")]
        public string NURSING_FEE { get; set; }
        /// <summary> 其他费用 </summary>
        [Column("OTHER_FEES")]
        public string OTHER_FEES { get; set; }
        /// <summary> 病理诊断费 </summary>
        [Column("PATHOLOGICAL_DIAGNOSIS_FEE")]
        public string PATHOLOGICAL_DIAGNOSIS_FEE { get; set; }
        /// <summary> 实验室诊断费 </summary>
        [Column("LABORATORY_FEE")]
        public string LABORATORY_FEE { get; set; }
        /// <summary> 影像学诊断费 </summary>
        [Column("VIDEO_FEE")]
        public string VIDEO_FEE { get; set; }
        /// <summary> 临床诊断项目费 </summary>
        [Column("CLINICAL_FEE")]
        public string CLINICAL_FEE { get; set; }
        /// <summary> 非手术治疗项目 </summary>
        [Column("NONSURGERY_FEE")]
        public string NONSURGERY_FEE { get; set; }
        /// <summary> 临床物理治疗费 </summary>
        [Column("CLINICALPHYSICS_FEE")]
        public string CLINICALPHYSICS_FEE { get; set; }
        /// <summary> 手术治疗费 </summary>
        [Column("OPERATION_CURE_FEE")]
        public string OPERATION_CURE_FEE { get; set; }
        /// <summary> 麻醉费 </summary>
        [Column("HOCUS_FEE")]
        public string HOCUS_FEE { get; set; }
        /// <summary> 手术费 </summary>
        [Column("OPERATION_FEE")]
        public string OPERATION_FEE { get; set; }
        /// <summary> 康复费 </summary>
        [Column("RECOVERY_FEE")]
        public string RECOVERY_FEE { get; set; }
        /// <summary> 中医治疗 </summary>
        [Column("CNMEDICIN_TREATMENT_FEE")]
        public string CNMEDICIN_TREATMENT_FEE { get; set; }
        /// <summary> 中医诊断 </summary>
        [Column("CNMEDICINE_DIAGNOSIS_FEE")]
        public string CNMEDICINE_DIAGNOSIS_FEE { get; set; }
        /// <summary> 中医治疗费 </summary>
        [Column("CNMEDICIN_TREATMENT")]
        public string CNMEDICIN_TREATMENT { get; set; }
        /// <summary> 中医外治 </summary>
        [Column("CNMEDICIN_EXTERNAL_FEE")]
        public string CNMEDICIN_EXTERNAL_FEE { get; set; }
        /// <summary> 中医骨伤 </summary>
        [Column("CNMEDICIN_BONEINJURY_FEE")]
        public string CNMEDICIN_BONEINJURY_FEE { get; set; }
        /// <summary> 针刺与灸法 </summary>
        [Column("ACUPUNCTURE_AND_MOXIBUSTION")]
        public string ACUPUNCTURE_AND_MOXIBUSTION { get; set; }
        /// <summary> 中医推拿治疗 </summary>
        [Column("CNMEDICIN_MASSAGE")]
        public string CNMEDICIN_MASSAGE { get; set; }
        /// <summary> 中医肛肠治疗 </summary>
        [Column("CNMEDICIN_ANORECTAL")]
        public string CNMEDICIN_ANORECTAL { get; set; }
        /// <summary> 中医特殊治疗 </summary>
        [Column("CNMEDICIN_SPECIAL")]
        public string CNMEDICIN_SPECIAL { get; set; }
        /// <summary> 中医其他 </summary>
        [Column("CNMEDICIN_OTHER")]
        public string CNMEDICIN_OTHER { get; set; }
        /// <summary> 中医特殊调配加工 </summary>
        [Column("CNMEDICIN_MACHINING")]
        public string CNMEDICIN_MACHINING { get; set; }
        /// <summary> 辨证施膳 </summary>
        [Column("DIALECTICAL_DIET")]
        public string DIALECTICAL_DIET { get; set; }
        /// <summary> 西药费 </summary>
        [Column("WESTERN_MEDICINE_FEE")]
        public string WESTERN_MEDICINE_FEE { get; set; }
        /// <summary> 抗菌药物费用 </summary>
        [Column("ANTIBACTERIAL_DRUGS_FEE")]
        public string ANTIBACTERIAL_DRUGS_FEE { get; set; }
        /// <summary> 中成药费 </summary>
        [Column("CNMEDICIN_MEDICINE_FEE")]
        public string CNMEDICIN_MEDICINE_FEE { get; set; }
        /// <summary> 中草药费 </summary>
        [Column("CNHERBAL_MEDICINE_FEE")]
        public string CNHERBAL_MEDICINE_FEE { get; set; }
        /// <summary> 血费 </summary>
        [Column("BLOOD_FEE")]
        public string BLOOD_FEE { get; set; }
        /// <summary> 白蛋白类制品费 </summary>
        [Column("ALBUMIN_FEE")]
        public string ALBUMIN_FEE { get; set; }
        /// <summary> 球蛋白类制品费 </summary>
        [Column("GLOBULIN_FEE")]
        public string GLOBULIN_FEE { get; set; }
        /// <summary> 凝血因子类制品费 </summary>
        [Column("CLOTTINGFACTOR_FEE")]
        public string CLOTTINGFACTOR_FEE { get; set; }
        /// <summary> 细胞因子类制品费 </summary>
        [Column("CELLFACTOR_FEE")]
        public string CELLFACTOR_FEE { get; set; }
        /// <summary> 检查用一次性医用材料费 </summary>
        [Column("CHECK_MATERIAL_FEE")]
        public string CHECK_MATERIAL_FEE { get; set; }
        /// <summary> 治疗用一次性医用材料费 </summary>
        [Column("TREATMENT_MATERIAL_FEE")]
        public string TREATMENT_MATERIAL_FEE { get; set; }
        /// <summary> 手术用一次性医用材料费 </summary>
        [Column("OPERATION_MATERIAL_FEE")]
        public string OPERATION_MATERIAL_FEE { get; set; }
        /// <summary> 其他费 </summary>
        [Column("OTHER_FEE")]
        public string OTHER_FEE { get; set; }
        /// <summary> 是否新版病案首页 1=新 </summary>
        [Column("ISNEW")]
        public int? ISNEW { get; set; }
        /// <summary> 书写状态 0-暂存，1-保存 </summary>
        [Column("WRITINGSTATE")]
        public int? WRITINGSTATE { get; set; }
        /// <summary> 新生儿出生体重 </summary>
        [Column("BIRTH_WEIGHT")]
        public string BIRTH_WEIGHT { get; set; }
        /// <summary> 新生儿入院体重 </summary>
        [Column("ADMISSION_WEIGHT")]
        public string ADMISSION_WEIGHT { get; set; }
        /// <summary> HBsAg，3未做，2阴性，1阳性 </summary>
        [Column("HBS")]
        public int? HBS { get; set; }
        /// <summary> HCV-Ab,3未做，2阴性，1阳性 </summary>
        [Column("HCV")]
        public int? HCV { get; set; }
        /// <summary> HIV-Ab， </summary>
        [Column("HIV")]
        public int? HIV { get; set; }
        /// <summary> 病案首页填写时间 </summary>
        [Column("FILL_TIME")]
        public DateTime? FILL_TIME { get; set; }
        /// <summary> 书写时间 </summary>
        [Column("WRITING_TIME")]
        public DateTime? WRITING_TIME { get; set; }
        /// <summary> 记录时间 </summary>
        [Column("RECORDING_TIME")]
        public DateTime? RECORDING_TIME { get; set; }
        /// <summary> 记录医师ID </summary>
        [Column("RECORDING_DOCTORID")]
        public string RECORDING_DOCTORID { get; set; }
        /// <summary> 记录医师姓名 </summary>
        [Column("RECORDING_DOCTORNAME")]
        public string RECORDING_DOCTORNAME { get; set; }
    }
}
