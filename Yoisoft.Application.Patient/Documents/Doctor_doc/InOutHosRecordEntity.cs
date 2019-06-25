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
    public class InOutHosRecordEntity:IBaseEntity
    {
        /// <summary> 病人序号 </summary>
        [Column("PATIENTID")]
        [Key]
        public string PATIENTID { get; set; }
        /// <summary> 主诉 </summary>
        [Column("CHIEF_COMPLAINT")]
        public string CHIEF_COMPLAINT { get; set; }
        /// <summary> 入院情况 </summary>
        [Column("ADMISSION_IS")]
        public string ADMISSION_IS { get; set; }
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
        /// <summary> 上级医生 </summary>
        [Column("SUPERIOR_DOCTORS")]
        public string SUPERIOR_DOCTORS { get; set; }
        /// <summary> 出院时间 </summary>
        [Column("OUTADMITTIME")]
        public DateTime? OUTADMITTIME { get; set; }
        /// <summary> 书写状态 </summary>
        [Column("WRITINGSTATE")]
        public int? WRITINGSTATE { get; set; }
        /// <summary> 现病史 </summary>
        [Column("PRESENT_ILLNESS")]
        public string PRESENT_ILLNESS { get; set; }
        /// <summary> 出院医嘱 </summary>
        [Column("DISCHARGE_ORDER")]
        public string DISCHARGE_ORDER { get; set; }
    }
}
