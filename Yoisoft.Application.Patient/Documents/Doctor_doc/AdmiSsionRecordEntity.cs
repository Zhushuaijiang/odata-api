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
    public class AdmiSsionRecordEntity:IBaseEntity
    {
        
        /// <summary> 住院序号 </summary>
        [Key]
        [Column("PATIENTID")]
        public string PATIENTID { get; set; }
        /// <summary> 病案号 </summary>
        [Column("MRN")]
        public string MRN { get; set; }
        /// <summary> 病史陈诉者 </summary>
        [Column("MEDICAL_HISTORY_COMPLAINT")]
        public string MEDICAL_HISTORY_COMPLAINT { get; set; }
        /// <summary> 用户组关系 </summary>
        [Column("USER_GROUP_RELATIONSHIP")]
        public int? USER_GROUP_RELATIONSHIP { get; set; }
        /// <summary> 主诉 </summary>
        [Column("CHIEF_COMPLAINT")]
        public string CHIEF_COMPLAINT { get; set; }
        /// <summary> 现病史 </summary>
        [Column("PRESENT_ILLNESS")]
        public string PRESENT_ILLNESS { get; set; }
        /// <summary> 既往史 </summary>
        [Column("PAST_HISTORY")]
        public string PAST_HISTORY { get; set; }
        /// <summary> 系统回顾 </summary>
        [Column("SYSTEMATIC_REVIEW")]
        public string SYSTEMATIC_REVIEW { get; set; }
        /// <summary> 个人史 </summary>
        [Column("PERSONAL_HISTORY")]
        public string PERSONAL_HISTORY { get; set; }
        /// <summary> 婚育史 </summary>
        [Column("OBSTERICAL_HISTORY")]
        public string OBSTERICAL_HISTORY { get; set; }
        /// <summary> 家族史 </summary>
        [Column("FAMILY_HISTORY")]
        public string FAMILY_HISTORY { get; set; }
        /// <summary> 辅助检查实验室检查 </summary>
        [Column("LABORATORY_INSPECT")]
        public string LABORATORY_INSPECT { get; set; }
        /// <summary> 辅助检查特殊检查 </summary>
        [Column("SPECIAL_INSPECT")]
        public string SPECIAL_INSPECT { get; set; }
        /// <summary> 辅助检查病理检查 </summary>
        [Column("PATHOLOGY_INSPECT")]
        public string PATHOLOGY_INSPECT { get; set; }
        /// <summary> 病史摘要 </summary>
        [Column("MEDICAL_HISTORY")]
        public string MEDICAL_HISTORY { get; set; }
        /// <summary> 书写医生 </summary>
        [Column("WRITING_DOCTORS")]
        public string WRITING_DOCTORS { get; set; }
        /// <summary> 记录日期 </summary>
        [Column("RECORDTIME")]
        public DateTime? RECORDTIME { get; set; }
        /// <summary> 系统记录时间 </summary>
        [Column("WRITINGTIME")]
        public DateTime? WRITINGTIME { get; set; }
        /// <summary> 书写状态 </summary>
        [Column("WRITING_STATE")]
        public int? WRITING_STATE { get; set; }
        /// <summary> 专科ID </summary>
        [Column("SPECIALTYID")]
        public string SPECIALTYID { get; set; }
        /// <summary> 机构iD </summary>
        [Column("GOVID")]
        public int? GOVID { get; set; }
        /// <summary> 专科检查 </summary>
        [Column("SPECIALTY_INSPECT")]
        public string SPECIALTY_INSPECT { get; set; }
        /// <summary> 辅助检查其他 </summary>
        [Column("OTHER")]
        public string OTHER { get; set; }
        /// <summary> 上级书写医生 </summary>
        [Column("SUPERIOR_DOCTORS")]
        public string SUPERIOR_DOCTORS { get; set; }
        /// <summary> 病史陈述者 </summary>
        [Column("RELATION")]
        public string RELATION { get; set; }
        /// <summary> 病史陈述者姓名 </summary>
        [Column("FAMILY")]
        public string FAMILY { get; set; }
        /// <summary> 病史陈述者是否可靠 </summary>
        [Column("RELIABLE")]
        public string RELIABLE { get; set; }
        /// <summary> 入院次数 </summary>
        [Column("NUMBERADMISSIONS")]
        public string NUMBERADMISSIONS { get; set; }
        /// <summary> 作废标志 1 作废 </summary>
        [Column("DEL")]
        public string DEL { get; set; }
        /// <summary> 月经史----产科 </summary>
        [Column("MENSTRUATION_HISTORY")]
        public string MENSTRUATION_HISTORY { get; set; }
        /// <summary> 计划分娩方式----产科 </summary>
        [Column("PLANNED_DELIVERY_MODE")]
        public int? PLANNED_DELIVERY_MODE { get; set; }
        /// <summary> 受孕方式  ----产科 </summary>
        [Column("CONCEIVE_MODE")]
        public int? CONCEIVE_MODE { get; set; }
        /// <summary> 孕次----产科 </summary>
        [Column("PREGNANCY_Y")]
        public string PREGNANCY_Y { get; set; }
        /// <summary> 丈夫姓名----产科 </summary>
        [Column("HUSBANDNAME")]
        public string HUSBANDNAME { get; set; }
        /// <summary> 末次月经  ----产科 </summary>
        [Column("LAST_MENSTRUATION")]
        public DateTime? LAST_MENSTRUATION { get; set; }
        /// <summary> 预产期----产科 </summary>
        [Column("EXPECTED_CHILDBIRTHDATE")]
        public DateTime? EXPECTED_CHILDBIRTHDATE { get; set; }
        /// <summary> 产次----产科 </summary>
        [Column("PREGNANCY_C")]
        public string PREGNANCY_C { get; set; }
        /// <summary> 删除时间 </summary>
        [Column("DELTIME")]
        public DateTime? DELTIME { get; set; }
        [Column("PHYSICAL_EXAMINATION")]

        public string PHYSICAL_EXAMINATION { get; set; }
        /// <summary> 父母姓名 </summary>
        [Column("PARENT_NAME")]
        public string PARENT_NAME { get; set; }

    }
}
