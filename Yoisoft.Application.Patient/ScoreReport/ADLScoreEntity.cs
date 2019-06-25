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
    public class ADLScoreEntity :IBaseEntity
    {
        /// <summary> 主键ID </summary>
        [Key]
        [Column("ID")]
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
        /// <summary> 进食 </summary>
        [Column("EAT")]
        public int? EAT { get; set; }
        /// <summary> 洗澡 </summary>
        [Column("BATHE")]
        public int? BATHE { get; set; }
        /// <summary> 修饰 </summary>
        [Column("MODIFICATION")]
        public int? MODIFICATION { get; set; }
        /// <summary> 穿衣 </summary>
        [Column("DRESSING")]
        public int? DRESSING { get; set; }
        /// <summary> 控制大便 </summary>
        [Column("CONTROL_STOOL")]
        public int? CONTROL_STOOL { get; set; }
        /// <summary> 控制小便 </summary>
        [Column("CONTROL_URINATION")]
        public int? CONTROL_URINATION { get; set; }
        /// <summary> 如厕 </summary>
        [Column("ASTOILET")]
        public int? ASTOILET { get; set; }
        /// <summary> 床椅转动 </summary>
        [Column("BC_ROTATION")]
        public int? BC_ROTATION { get; set; }
        /// <summary> 平地行走 </summary>
        [Column("FLATGROUND_WALK")]
        public int? FLATGROUND_WALK { get; set; }
        /// <summary> 上下楼梯 </summary>
        [Column("UPDOWN_STAIRS")]
        public int? UPDOWN_STAIRS { get; set; }
        /// <summary> 总分 </summary>
        [Column("TOTAL_SCORE")]
        public int? TOTAL_SCORE { get; set; }
    }
}
