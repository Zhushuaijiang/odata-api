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
    public class CNREntity:IBaseEntity
    {
        /// <summary> 记录ID </summary>
        [Key]
        [Column("ID")]
        public string ID { get; set; }
        /// <summary> 主记录id </summary>
        [Column("PARENTID")]
        public string PARENTID { get; set; }
        /// <summary> 首次记录时间 </summary>
        [Column("RECORDING_TIME")]
        public DateTime? RECORDING_TIME { get; set; }
        /// <summary> 记录护士id </summary>
        [Column("RECORD_NURSE_ID")]
        public string RECORD_NURSE_ID { get; set; }
        /// <summary> 体温 </summary>
        [Column("TEMPERATURE")]
        public string TEMPERATURE { get; set; }
        /// <summary> 脉搏 </summary>
        [Column("PULSE")]
        public string PULSE { get; set; }
        /// <summary> 呼吸 </summary>
        [Column("BREATHING")]
        public string BREATHING { get; set; }
        /// <summary> 舒张压---低压 </summary>
        [Column("DIASTOLIC_PRESSURE")]
        public string DIASTOLIC_PRESSURE { get; set; }
        /// <summary> 收缩压---高压 </summary>
        [Column("SYSTOLIC_PRESSURE")]
        public string SYSTOLIC_PRESSURE { get; set; }
        /// <summary> 意识 </summary>
        [Column("CONSCIOUSNESS")]
        public string CONSCIOUSNESS { get; set; }
        /// <summary> 瞳孔左 </summary>
        [Column("LEFT_PUPIL")]
        public string LEFT_PUPIL { get; set; }
        /// <summary> 瞳孔右 </summary>
        [Column("RIGHT_PUPIL")]
        public string RIGHT_PUPIL { get; set; }
        /// <summary> 入量名称 </summary>
        [Column("INTAKE_NAME")]
        public string INTAKE_NAME { get; set; }
        /// <summary> 入量量 </summary>
        [Column("INTAKE_AMOUNT")]
        public int? INTAKE_AMOUNT { get; set; }
        /// <summary> 入量单位 </summary>
        [Column("INTAKE_COMPANY")]
        public string INTAKE_COMPANY { get; set; }
        /// <summary> 出量名称 </summary>
        [Column("OUTPUT_NAME")]
        public string OUTPUT_NAME { get; set; }
        /// <summary> 出量量 </summary>
        [Column("OUTPUT_AMOUNT")]
        public int? OUTPUT_AMOUNT { get; set; }
        /// <summary> 出量单位 </summary>
        [Column("OUTPUT_COMPANY")]
        public string OUTPUT_COMPANY { get; set; }
        /// <summary> 出量颜色 </summary>
        [Column("OUTPUT_COLOR")]
        public string OUTPUT_COLOR { get; set; }
        /// <summary> 出量性状 </summary>
        [Column("OUTPUT_CHARACTER")]
        public string OUTPUT_CHARACTER { get; set; }
        /// <summary> 基础护理 </summary>
        [Column("BASIC_NURSING")]
        public string BASIC_NURSING { get; set; }
        /// <summary> 特殊护理 </summary>
        [Column("SPECIAL_CARE")]
        public string SPECIAL_CARE { get; set; }
        /// <summary> 实际记录时间 </summary>
        [Column("ACTUAL_RECORDING_TIME")]
        public DateTime? ACTUAL_RECORDING_TIME { get; set; }
        /// <summary> 保存类型0-暂存1-保存 </summary>
        [Column("SAVE_TYPE")]
        public int? SAVE_TYPE { get; set; }
        /// <summary> 氧饱和度 </summary>
        [Column("OXYGEN_SATURATION")]
        public string OXYGEN_SATURATION { get; set; }
        /// <summary> 是否红线 </summary>
        [Column("ISREDLINE")]
        public int? ISREDLINE { get; set; }
        /// <summary> 总入量 </summary>
        [Column("TOTAL_INTAKE")]
        public int? TOTAL_INTAKE { get; set; }
        /// <summary> 总出量 </summary>
        [Column("TOTAL_OUTPUT")]
        public int? TOTAL_OUTPUT { get; set; }
        /// <summary> 出入量类型 </summary>
        [Column("TOTAL_INPUT_TYPE")]
        public int? TOTAL_INPUT_TYPE { get; set; }
        /// <summary> 记录类型      1-危重手术记录单,(null or 0)-危重患者护理记录单 </summary>
        [Column("RECORD_TYPE")]
        public int? RECORD_TYPE { get; set; }
        /// <summary> 上级护士签名 </summary>
        [Column("SIGNATURE_SUPERIOR_NURSE")]
        public string SIGNATURE_SUPERIOR_NURSE { get; set; }
        /// <summary> 病人ID </summary>
        [Column("PATIENTID")]
        public string PATIENTID { get; set; }
        /// <summary> 总入出量的时间 </summary>
        [Column("TOTAL_INPUT_TIME")]
        public DateTime? TOTAL_INPUT_TIME { get; set; }
        /// <summary> 总入出量的签名人员id </summary>
        [Column("TOTAL_SIGNATURE_ID")]
        public string TOTAL_SIGNATURE_ID { get; set; }
        /// <summary> 总入出量的签名人员姓名 </summary>
        [Column("TOTAL_SIGNATURE_NAME")]
        public string TOTAL_SIGNATURE_NAME { get; set; }
        /// <summary> 护理措施 </summary>
        [Column("NURSING_MEASURES")]
        public string NURSING_MEASURES { get; set; }
        /// <summary> 入量名称组合字符串 </summary>
        [Column("INTAKE_STR")]
        public string INTAKE_STR { get; set; }
        /// <summary> 导管 </summary>
        [Column("CATHETER")]
        public string CATHETER { get; set; }
        /// <summary> 护理评估 </summary>
        [Column("NURSING_ASSESSMENT")]
        public string NURSING_ASSESSMENT { get; set; }
        /// <summary> 体温类型 </summary>
        [Column("TYPE_TEMPERATURE")]
        public string TYPE_TEMPERATURE { get; set; }
        /// <summary> 脉搏类型 </summary>
        [Column("TYPE_PULSE")]
        public int? TYPE_PULSE { get; set; }
        /// <summary> 护理级别 </summary>
        [Column("NURSING_LEVEL")]
        public int? NURSING_LEVEL { get; set; }
        /// <summary> 安全措施 </summary>
        [Column("SAFETY_MEASURES")]
        public string SAFETY_MEASURES { get; set; }
        /// <summary> 卧位 </summary>
        [Column("DECUBITUS_POSITION")]
        public string DECUBITUS_POSITION { get; set; }
        /// <summary> 皮肤情况 </summary>
        [Column("SKIN_CONDITION")]
        public string SKIN_CONDITION { get; set; }
        /// <summary> 管道护理项目 </summary>
        [Column("PIPELINE_NURSING_PROJECT")]
        public string PIPELINE_NURSING_PROJECT { get; set; }
        /// <summary> 管道护理情况 </summary>
        [Column("PIPELINE_NURSING")]
        public string PIPELINE_NURSING { get; set; }
        /// <summary> 删除时间 </summary>
        [Column("DELTIME")]
        public DateTime? DELTIME { get; set; }
        /// <summary> 删除状态 </summary>
        [Column("DEL")]
        public int? DEL { get; set; }
        /// <summary> 书写时间 </summary>
        [Column("WRITINGTIME")]
        public DateTime? WRITINGTIME { get; set; }
        /// <summary> 吸氧 </summary>
        [Column("OXYGEN_INHALATION")]
        public string OXYGEN_INHALATION { get; set; }
        /// <summary> SPO2 </summary>
        [Column("SPO2")]
        public string SPO2 { get; set; }
        /// <summary> FiO2 </summary>
        [Column("FIO2")]
        public string FIO2 { get; set; }
        /// <summary> 瞳孔左 </summary>
        [Column("PUPIL_LEFT")]
        public string PUPIL_LEFT { get; set; }
        /// <summary> 瞳孔右 </summary>
        [Column("PUPIL_RIGHT")]
        public string PUPIL_RIGHT { get; set; }
        /// <summary> 对光反射左 </summary>
        [Column("LIGHT_REFLECTION_LEFT")]
        public string LIGHT_REFLECTION_LEFT { get; set; }
        /// <summary> 对光反射右 </summary>
        [Column("LIGHT_REFLECTION_RIGHT")]
        public string LIGHT_REFLECTION_RIGHT { get; set; }
        /// <summary> 健康宣教 </summary>
        [Column("HEALTH_EDUCATION")]
        public string HEALTH_EDUCATION { get; set; }

    }
}
