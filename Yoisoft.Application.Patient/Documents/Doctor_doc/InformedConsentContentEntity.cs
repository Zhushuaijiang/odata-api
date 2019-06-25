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
    public class InformedConsentContentEntity:IBaseEntity
    {
        /// <summary> ID </summary>
        [Column("ID")]
        [Key]
        public string ID { get; set; }
        /// <summary> MBID Yy_xy_xynr 的主键 </summary>
        [Column("MBID")]
        public string MBID { get; set; }
        /// <summary> 模板标题 </summary>
        [Column("TITLE")]
        public string TITLE { get; set; }
        /// <summary> 内容 </summary>
        [Column("CONTENT")]
        public string CONTENT { get; set; }
        /// <summary> 修改时间 </summary>
        [Column("TIME")]
        public DateTime? TIME { get; set; }
        /// <summary> 住院序号 </summary>
        [Column("PATIENTID")]
        public string PATIENTID { get; set; }
        /// <summary> 书写医生 </summary>
        [Column("WRITING_DOCTORS")]
        public string WRITING_DOCTORS { get; set; }
        /// <summary> 保存状态 </summary>
        [Column("TYPE")]
        public int? TYPE { get; set; }
        /// <summary> 删除状态 </summary>
        [Column("DEL")]
        public int? DEL { get; set; }
        /// <summary> 围手术文书ID </summary>
        [Column("WSSQWSID")]
        public string WSSQWSID { get; set; }
    }
}
