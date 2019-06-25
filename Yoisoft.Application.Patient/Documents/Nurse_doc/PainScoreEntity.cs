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
    public class PainScoreEntity:IBaseEntity
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
        /// <summary> 疼痛评分 </summary>
        [Column("PAINSCORE")]
        public int? PAINSCORE { get; set; }
        /// <summary> 部位 </summary>
        [Column("POSITION")]
        public string POSITION { get; set; }
    }
}
