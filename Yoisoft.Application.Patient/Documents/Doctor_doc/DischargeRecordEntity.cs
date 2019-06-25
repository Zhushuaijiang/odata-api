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
    public class DischargeRecordEntity:IBaseEntity
    {
        /// <summary> 主键ID </summary>
        [Column("PATIENTID")]
        [Key]
        public string PATIENTID { get; set; }
        /// <summary> 病历诊断 </summary>
        [Column("MEDICAL_RECORD_DIAGNOSIS")]
        public string MEDICAL_RECORD_DIAGNOSIS { get; set; }
        /// <summary> 病历ID </summary>
        [Column("MEDICAL_RECORDID")]
        public string MEDICAL_RECORDID { get; set; }
        /// <summary> 诊疗经过 </summary>
        [Column("DIAGNOSIS_AND_TREATMENT")]
        public string DIAGNOSIS_AND_TREATMENT { get; set; }
        /// <summary> 出院情况 </summary>
        [Column("DISCHARGE_IS")]
        public string DISCHARGE_IS { get; set; }
        /// <summary> 出院状态 </summary>
        [Column("DISCHARGESTATE")]
        public int? DISCHARGESTATE { get; set; }
        /// <summary> 书写医生 </summary>
        [Column("WRITING_DOCTORS")]
        public string WRITING_DOCTORS { get; set; }
        /// <summary> 记录时间 </summary>
        [Column("RECORDTIME")]
        public DateTime? RECORDTIME { get; set; }
        /// <summary> 书写时间 </summary>
        [Column("WRITINGTIME")]
        public DateTime? WRITINGTIME { get; set; }
        /// <summary> 书写状态 </summary>
        [Column("WRITINGSTATE")]
        public int? WRITINGSTATE { get; set; }
        /// <summary> 上级医生 </summary>
        [Column("SUPERIOR_DOCTORS")]
        public string SUPERIOR_DOCTORS { get; set; }
        /// <summary> 检查项目 </summary>
        [Column("INSPECT_COMPANY")]
        public string INSPECT_COMPANY { get; set; }
        /// <summary> 疗效评价 </summary>
        [Column("CURATIVE_EFFECT_EVALUATE")]
        public string CURATIVE_EFFECT_EVALUATE { get; set; }
        /// <summary> 出院带药 </summary>
        [Column("DISCHARGE_WITH_MEDICINE")]
        public string DISCHARGE_WITH_MEDICINE { get; set; }
        /// <summary> 出院时间 </summary>
        [Column("OUTADMITTIME")]
        public DateTime? OUTADMITTIME { get; set; }
        /// <summary> 病理号 </summary>
        [Column("PATHOLOGY_NUMBER")]
        public string PATHOLOGY_NUMBER { get; set; }
        /// <summary> B超号 </summary>
        [Column("B_ULTRASOUND_NUMBER")]
        public string B_ULTRASOUND_NUMBER { get; set; }
        /// <summary> X片 </summary>
        [Column("X_FILM_NUMBER")]
        public string X_FILM_NUMBER { get; set; }
        /// <summary> MR号 </summary>
        [Column("MR_NUMBER")]
        public string MR_NUMBER { get; set; }
        /// <summary> CT号 </summary>
        [Column("CT_NUMBER")]
        public string CT_NUMBER { get; set; }
        /// <summary> PET号 </summary>
        [Column("PET_NUMBER")]
        public string PET_NUMBER { get; set; }
        /// <summary> ECT号 </summary>
        [Column("ECT_NUMBER")]
        public string ECT_NUMBER { get; set; }
        /// <summary> 出院医嘱 </summary>
        [Column("DISCHARGE_ORDER")]
        public string DISCHARGE_ORDER { get; set; }
        /// <summary> 注意事项 </summary>
        [Column("MATTERS_NEEDING_ATTENTION")]
        public string MATTERS_NEEDING_ATTENTION { get; set; }
        /// <summary> 复诊时间 </summary>
        [Column("REVISITTIME")]
        public DateTime? REVISITTIME { get; set; }
    }
}
