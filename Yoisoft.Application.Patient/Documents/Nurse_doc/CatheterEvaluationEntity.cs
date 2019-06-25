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
    public class CatheterEvaluationEntity : IBaseEntity
    {
        /// <summary> 主键ID </summary>
        [Key]
        [Column("ID")]
        public int ID { get; set; }
        /// <summary> 病人序号ID </summary>
        [Column("PATIENTID")]
        public string PATIENTID { get; set; }
        /// <summary> 导管号 </summary>
        [Column("CENUMBER")]
        public int? CENUMBER { get; set; }
        /// <summary> 导管名称 </summary>
        [Column("CENAME")]
        public string CENAME { get; set; }
        /// <summary> 部位 </summary>
        [Column("POSITION")]
        public string POSITION { get; set; }
        /// <summary> 置管时间 </summary>
        [Column("CATHETERTIME")]
        public DateTime? CATHETERTIME { get; set; }
        /// <summary> 深度 </summary>
        [Column("DEPTH")]
        public string DEPTH { get; set; }
        /// <summary> 深度量 </summary>
        [Column("DEPTH_AMOUNT")]
        public string DEPTH_AMOUNT { get; set; }
        /// <summary> 固定 </summary>
        [Column("FIXED")]
        public string FIXED { get; set; }
        /// <summary> 标记 </summary>
        [Column("SIGN")]
        public string SIGN { get; set; }
        /// <summary> 通畅 </summary>
        [Column("UNOBSTRUCTED")]
        public string UNOBSTRUCTED { get; set; }
        /// <summary> 局部情况 </summary>
        [Column("LOCAL_CONDITION")]
        public string LOCAL_CONDITION { get; set; }
        /// <summary> 局部情况其他  </summary>
        [Column("LOCAL_CONDITION_OTHER")]
        public string LOCAL_CONDITION_OTHER { get; set; }
        /// <summary> 引流液性质 </summary>
        [Column("DRAINAGE_NATURE")]
        public string DRAINAGE_NATURE { get; set; }
        /// <summary> 引流液量 </summary>
        [Column("DRAINAGE_AMOUNT")]
        public string DRAINAGE_AMOUNT { get; set; }
        /// <summary> 开始时间 </summary>
        [Column("STARTTIME")]
        public DateTime? STARTTIME { get; set; }
        /// <summary> 结束时间 </summary>
        [Column("ENDTIME")]
        public DateTime? ENDTIME { get; set; }
        /// <summary> 记录时间 </summary>
        [Column("RECORDTIME")]
        public DateTime? RECORDTIME { get; set; }
        /// <summary> 记录护士ID </summary>
        [Column("RECORD_NURSE_ID")]
        public string RECORD_NURSE_ID { get; set; }
        /// <summary> 上级护士 </summary>
        [Column("SUPERIOR_NURSE")]
        public string SUPERIOR_NURSE { get; set; }
        /// <summary> 父ID </summary>
        [Column("FATHERID")]
        public string FATHERID { get; set; }
        /// <summary> 导管类型 </summary>
        [Column("CETYPE")]
        public string CETYPE { get; set; }
    }
}
