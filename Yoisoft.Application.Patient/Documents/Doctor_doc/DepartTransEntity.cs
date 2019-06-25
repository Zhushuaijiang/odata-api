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
    public class DepartTransEntity:IBaseEntity
    {
        /// <summary> 自增ID </summary>
        [Column("ID")]
        [Key]
        public string ID { get; set; }
        /// <summary> 实际记录时间 </summary>
        [Column("RECORDTIME")]
        public DateTime? RECORDTIME { get; set; }
        [Column("ACTUALRECORDTIME")]
        public DateTime? ACTUALRECORDTIME { get; set; }
        /// <summary> 转出科室ID </summary>
        [Column("OUTDEPARTID")]
        public int? OUTDEPARTID { get; set; }
        /// <summary> 转出病区ID </summary>
        [Column("OUTWARDID")]
        public int? OUTWARDID { get; set; }
        /// <summary> 转入科室ID </summary>
        [Column("INDEPARTID")]
        public int? INDEPARTID { get; set; }
        /// <summary> 转入病区ID </summary>
        [Column("INWARDID")]
        public int? INWARDID { get; set; }
        /// <summary> 转入操作人ID </summary>
        [Column("INOPERATORID")]
        public string INOPERATORID { get; set; }
        /// <summary> 转出操作人ID </summary>
        [Column("OUTOPERATORID")]
        public string OUTOPERATORID { get; set; }
        /// <summary> 病人ID </summary>
        [Column("PATIENTID")]
        public string PATIENTID { get; set; }
        /// <summary> HIS科室ID </summary>
        [Column("HISDEPARTID")]
        public string HISDEPARTID { get; set; }
        /// <summary> 病程记录ID </summary>
        [Column("PROGRESSNOTEID")]
        public string PROGRESSNOTEID { get; set; }
    }
}
