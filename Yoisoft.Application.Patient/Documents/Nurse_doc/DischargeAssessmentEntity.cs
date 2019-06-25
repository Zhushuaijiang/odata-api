using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Util;

namespace Yoisoft.Application.Patient
{
    public class DischargeAssessmentEntity:IBaseEntity
    {
        /// <summary> 主记录ID </summary>
        [Column("ID")]
        [Key]
        public string ID { get; set; }
        /// <summary> 病人ID </summary>
        [Column("PATIENTID")]
        public string PATIENTID { get; set; }
        /// <summary> 入院日期 </summary>
        [Column("ADMISSION_DATE")]
        public string ADMISSION_DATE { get; set; }
        /// <summary> 手术日期 </summary>
        [Column("OPERATION_DATE")]
        public string OPERATION_DATE { get; set; }
        /// <summary> 出院日期 </summary>
        [Column("DISCHARGE_DATE")]
        public string DISCHARGE_DATE { get; set; }
        /// <summary> 手术名称 </summary>
        [Column("OPERATIVE_NAME")]
        public string OPERATIVE_NAME { get; set; }
        /// <summary> 出院诊断(中医) </summary>
        [Column("DISCHARGE_DIAGNOSIS_CHINESE")]
        public string DISCHARGE_DIAGNOSIS_CHINESE { get; set; }
        /// <summary> 出院诊断(西医) </summary>
        [Column("DISCHARGE_DIAGNOSIS_WESTERN")]
        public string DISCHARGE_DIAGNOSIS_WESTERN { get; set; }
        /// <summary> 疾病转归(0_痊愈,1_转好,2_稳定,3_恶化,4_自动出院,5_死亡) </summary>
        [Column("PROGNOSIS_DISEASE")]
        public string PROGNOSIS_DISEASE { get; set; }
        /// <summary> 对疾病的认识程度(0_了解,1_部分了解,2_不了解) </summary>
        [Column("KNOWLEDGE_DISEASE")]
        public string KNOWLEDGE_DISEASE { get; set; }
        /// <summary> 心理状态(0_稳定,1_焦虑,2_压抑,3_否认,4_对抗) </summary>
        [Column("MENTALITY")]
        public string MENTALITY { get; set; }
        /// <summary> 自理能力(0_自理 ,1_协助（进食、入厕、沐浴、穿衣、行走）,2_完全依赖 ) </summary>
        [Column("SELF_CARE_ABILITY")]
        public string SELF_CARE_ABILITY { get; set; }
        /// <summary> 皮肤情况(0_完整,不为0则描述具体情况) </summary>
        [Column("SKIN_CONDITION")]
        public string SKIN_CONDITION { get; set; }
        /// <summary> 并发症(0_无,1_有（肺部感染、尿路感染、褥疮、伤口感染、静脉炎、口腔感染） ) </summary>
        [Column("COMPLICATION")]
        public string COMPLICATION { get; set; }
        /// <summary> 按医嘱服药 </summary>
        [Column("MEDICAL_ADVICE")]
        public string MEDICAL_ADVICE { get; set; }
        /// <summary> 特殊用药指导 </summary>
        [Column("SPECIAL_MEDICATION_GUIDANCE")]
        public string SPECIAL_MEDICATION_GUIDANCE { get; set; }
        /// <summary> 其他(用药指导) </summary>
        [Column("OTHER_MEDICATION_GUIDANCE")]
        public string OTHER_MEDICATION_GUIDANCE { get; set; }
        /// <summary> 生活起居 </summary>
        [Column("DAILY_LIFE")]
        public string DAILY_LIFE { get; set; }
        /// <summary> 情志调节 </summary>
        [Column("EMOTION_REGULATION")]
        public string EMOTION_REGULATION { get; set; }
        /// <summary> 饮食调理 </summary>
        [Column("DIET_CONDITIONING")]
        public string DIET_CONDITIONING { get; set; }
        /// <summary> 日常生活 </summary>
        [Column("DAILY_ROUTINE")]
        public string DAILY_ROUTINE { get; set; }
        /// <summary> 功能锻炼 </summary>
        [Column("FUNCTIONAL_EXERCISE")]
        public string FUNCTIONAL_EXERCISE { get; set; }
        /// <summary> 特殊指导 </summary>
        [Column("SPECIAL_GUIDANCE")]
        public string SPECIAL_GUIDANCE { get; set; }
        /// <summary> 护士姓名 </summary>
        [Column("NURSE_NAME")]
        public string NURSE_NAME { get; set; }
        /// <summary> 护士工号 </summary>
        [Column("NURSE_ID")]
        public string NURSE_ID { get; set; }
        /// <summary> 护士长姓名 </summary>
        [Column("HEAD_NURSE_NAME")]
        public string HEAD_NURSE_NAME { get; set; }
        /// <summary> 护士长工号 </summary>
        [Column("HEAD_NURSE_ID")]
        public string HEAD_NURSE_ID { get; set; }
        /// <summary> 记录日期 </summary>
        [Column("RECORD_DATE")]
        public string RECORD_DATE { get; set; }
        /// <summary> 保存状态1表示保存0表示暂存 </summary>
        [Column("SAVE_STATE")]
        public string SAVE_STATE { get; set; }
        /// <summary> 皮肤情况其他 </summary>
        [Column("SKIN_CONDITION_OTHER")]
        public string SKIN_CONDITION_OTHER { get; set; }
    }
}
