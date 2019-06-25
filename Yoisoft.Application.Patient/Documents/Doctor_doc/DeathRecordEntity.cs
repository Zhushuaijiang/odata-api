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
    public class DeathRecordEntity : IBaseEntity
    {
        /// <summary> 病人ID  ---- 唯一序号  </summary>
        [Key]
        [Column("PATIENTID")]
        public string PATIENTID { get; set; }
        /// <summary> 入院情况 </summary>
        [Column("INADMI_SITUATION")]
        public string INADMI_SITUATION { get; set; }
        /// <summary> 诊疗经过 </summary>
        [Column("DIAGNOSIS_AND_TREATMENT")]
        public string DIAGNOSIS_AND_TREATMENT { get; set; }
        /// <summary> 死亡原因 </summary>
        [Column("DEATH_CAUSE")]
        public string DEATH_CAUSE { get; set; }
        /// <summary> 死亡诊断 </summary>
        [Column("DEATH_DIAGNOSIS")]
        public string DEATH_DIAGNOSIS { get; set; }
        /// <summary> 书写医生 </summary>
        [Column("WRITING_DOCTORS")]
        public string WRITING_DOCTORS { get; set; }
        /// <summary> 死亡讨论日期 </summary>
        [Column("DEATH_DISCUSSDATE")]
        public DateTime? DEATH_DISCUSSDATE { get; set; }
        /// <summary> 死亡讨论时间 </summary>
        [Column("DEATH_DISCUSSTIME")]
        public DateTime? DEATH_DISCUSSTIME { get; set; }
        /// <summary> 死亡讨论地点 </summary>
        [Column("DEATH_DISCUSSPLACE")]
        public string DEATH_DISCUSSPLACE { get; set; }
        /// <summary> 主持人 </summary>
        [Column("HOST")]
        public string HOST { get; set; }
        /// <summary> 参加人员 </summary>
        [Column("PARTICIPANTS")]
        public string PARTICIPANTS { get; set; }
        /// <summary> 最后诊断 </summary>
        [Column("LAST_DIAGNOSIS")]
        public string LAST_DIAGNOSIS { get; set; }
        /// <summary> 诊疗处理意见 </summary>
        [Column("DT_ADVICE")]
        public string DT_ADVICE { get; set; }
        /// <summary> 讨论记录人ID </summary>
        [Column("DISCUSS_NOTETAKER")]
        public string DISCUSS_NOTETAKER { get; set; }
        /// <summary> 讨论记录时间 </summary>
        [Column("DISCUSS_NOTETIME")]
        public DateTime? DISCUSS_NOTETIME { get; set; }
        /// <summary> 书写时间 </summary>
        [Column("WRITINGTIME")]
        public DateTime? WRITINGTIME { get; set; }
        /// <summary> 记录时间 </summary>
        [Column("RECORDTIME")]
        public DateTime? RECORDTIME { get; set; }
        /// <summary> 书写状态 </summary>
        [Column("WRITINGSTATE")]
        public int? WRITINGSTATE { get; set; }
        /// <summary> 上级医生 </summary>
        [Column("SUPERIOR_DOCTORS")]
        public string SUPERIOR_DOCTORS { get; set; }
        /// <summary> 死亡时间 </summary>
        [Column("DEATH_TIME")]
        public DateTime? DEATH_TIME { get; set; }
        /// <summary> 主诉 </summary>
        [Column("MAIN_COMPLAINT")]
        public string MAIN_COMPLAINT { get; set; }
        /// <summary> 讨论结论 </summary>
        [Column("DISCUSSION_RESULTS")]
        public string DISCUSSION_RESULTS { get; set; }
    }
}
