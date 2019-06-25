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
    public class BradenScoreEntity:IBaseEntity
    {
        /// <summary> 主键ID </summary>
        [Key]
        [Column("ID")]
        public string ID { get; set; }
        /// <summary> 病人序号 </summary>
        [Column("PATIENTID")]
        public string PATIENTID { get; set; }
        /// <summary> 感受 </summary>
        [Column("FEEL")]
        public int? FEEL { get; set; }
        /// <summary> 潮湿 </summary>
        [Column("DAMP")]
        public int? DAMP { get; set; }
        /// <summary> 活动 </summary>
        [Column("ACTIVITY")]
        public int? ACTIVITY { get; set; }
        /// <summary> 活动能力 </summary>
        [Column("ACTIVITY_ABILITY")]
        public int? ACTIVITY_ABILITY { get; set; }
        /// <summary> 营养 </summary>
        [Column("NUTRITION")]
        public int? NUTRITION { get; set; }
        /// <summary> 摩擦和剪力 </summary>
        [Column("FRICTION_SHEARFORCE")]
        public int? FRICTION_SHEARFORCE { get; set; }
        /// <summary> 总分 </summary>
        [Column("TOTAL_SCORE")]
        public int? TOTAL_SCORE { get; set; }
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
        /// <summary> 护理部意见 </summary>
        [Column("ND_OPINION")]
        public string ND_OPINION { get; set; }
        /// <summary> 护理部主任意见 </summary>
        [Column("HEADNURSE_OPINION")]
        public string HEADNURSE_OPINION { get; set; }
        /// <summary> 护士长意见 </summary>
        [Column("NDDIRECTOR_OPINION")]
        public string NDDIRECTOR_OPINION { get; set; }
        /// <summary> 护理部签名 </summary>
        [Column("ND_AUTOGRAPH")]
        public string ND_AUTOGRAPH { get; set; }
        /// <summary> 护理部主任签名 </summary>
        [Column("NDDIRECTOR_AUTOGRAPH")]
        public string NDDIRECTOR_AUTOGRAPH { get; set; }
        /// <summary> 护士长签名 </summary>
        [Column("HEADNURSE_AUTOGRAPH")]
        public string HEADNURSE_AUTOGRAPH { get; set; }
    }
}
