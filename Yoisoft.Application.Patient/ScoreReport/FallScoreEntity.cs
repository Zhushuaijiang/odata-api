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
    public class FallScoreEntity : IBaseEntity
    {
        /// <summary> 主键ID </summary>
        [Column("ID")]
        [Key]
        public string ID { get; set; }
        /// <summary> 病人序号 </summary>
        [Column("PATIENTID")]
        public string PATIENTID { get; set; }
        /// <summary> 评估人ID </summary>
        [Column("SCOREUSERID")]
        public string SCOREUSERID { get; set; }
        /// <summary> 评估状态 </summary>
        [Column("SCORESTATE")]
        public int? SCORESTATE { get; set; }
        /// <summary> 页码 </summary>
        [Column("PAGENUMBER")]
        public int? PAGENUMBER { get; set; }
        /// <summary> 评估时间 </summary>
        [Column("SCORETIME")]
        public DateTime? SCORETIME { get; set; }
        /// <summary> 修改时间 </summary>
        [Column("UPDATETIME")]
        public DateTime? UPDATETIME { get; set; }
        /// <summary> 上级护士审签 </summary>
        [Column("SUPERIOR_NURSE")]
        public string SUPERIOR_NURSE { get; set; }
        /// <summary> 审核 </summary>
        [Column("TO_EXAMINE")]
        public int? TO_EXAMINE { get; set; }
        /// <summary> 总分 </summary>
        [Column("TOTAL_SCORE")]
        public int? TOTAL_SCORE { get; set; }
        /// <summary> 跌倒经历 </summary>
        [Column("FALL_EXPERIENCE")]
        public int? FALL_EXPERIENCE { get; set; }
        /// <summary> 意识障碍 </summary>
        [Column("CON_OBSTACLE")]
        public int? CON_OBSTACLE { get; set; }
        /// <summary> 视力障碍 </summary>
        [Column("VISION_OBSTACLE")]
        public int? VISION_OBSTACLE { get; set; }
        /// <summary> 活动障碍 </summary>
        [Column("ACTIVITY_OBSTACLE")]
        public int? ACTIVITY_OBSTACLE { get; set; }
        /// <summary> 年龄 </summary>
        [Column("AGE")]
        public int? AGE { get; set; }
        /// <summary> 体能虚弱 </summary>
        [Column("PHYSICAL_WEAKNESS")]
        public int? PHYSICAL_WEAKNESS { get; set; }
        /// <summary> 头晕、眩晕 </summary>
        [Column("DIZZY_VERTIGO")]
        public int? DIZZY_VERTIGO { get; set; }
        /// <summary> 影响药物 </summary>
        [Column("INFLUENCE_MEDICINE")]
        public int? INFLUENCE_MEDICINE { get; set; }
        /// <summary> 药物内容 </summary>
        [Column("MEDICINE")]
        public string MEDICINE { get; set; }
        /// <summary> 住院中无家人或其他人员陪伴 </summary>
        [Column("NO_ACCOMPANY")]
        public int? NO_ACCOMPANY { get; set; }
    }
}
