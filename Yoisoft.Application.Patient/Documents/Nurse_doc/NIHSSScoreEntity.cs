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
    public class NIHSSScoreEntity:IBaseEntity
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
        /// <summary> 意识水平 </summary>
        [Column("CON_LEVEL")]
        public int? CON_LEVEL { get; set; }
        /// <summary> 意识水平提问 </summary>
        [Column("CON_LEVEL_QUIZ")]
        public int? CON_LEVEL_QUIZ { get; set; }
        /// <summary> 意识水平指令 </summary>
        [Column("CON_LEVEL_DIRECTIVE")]
        public int? CON_LEVEL_DIRECTIVE { get; set; }
        /// <summary> 凝视 </summary>
        [Column("GAZE")]
        public int? GAZE { get; set; }
        /// <summary> 视野 </summary>
        [Column("FIELD")]
        public int? FIELD { get; set; }
        /// <summary> 面瘫 </summary>
        [Column("FACIOPLEGIA")]
        public int? FACIOPLEGIA { get; set; }
        /// <summary> 上肢运动 </summary>
        [Column("UPLIMB_MOVEMENTS")]
        public int? UPLIMB_MOVEMENTS { get; set; }
        /// <summary> 下肢运动 </summary>
        [Column("DOLIMB_MOVEMENTS")]
        public int? DOLIMB_MOVEMENTS { get; set; }
        /// <summary> 肢体共济失调 </summary>
        [Column("ATAXIA_LIMBS")]
        public int? ATAXIA_LIMBS { get; set; }
        /// <summary> 感觉 </summary>
        [Column("FEEL")]
        public int? FEEL { get; set; }
        /// <summary> 语言 </summary>
        [Column("LANGUAGE")]
        public int? LANGUAGE { get; set; }
        /// <summary> 构音障碍 </summary>
        [Column("ARTICULATION_DISORDER")]
        public int? ARTICULATION_DISORDER { get; set; }
        /// <summary> 忽视 </summary>
        [Column("IGNORE")]
        public int? IGNORE { get; set; }
    }
}
