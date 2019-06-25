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
    public class InformedConsentTemplateEntity:IBaseEntity
    {
        [Column("MBID")]
        [Key]
        public string MBID { get; set; }
        /// <summary> 知情同意书模板标题 </summary>
        [Column("MBBT")]
        public string MBBT { get; set; }
        /// <summary> 知情同意书模板内容 </summary>
        [Column("MBNR")]
        public string MBNR { get; set; }
        /// <summary> 知情同意书模板拼音码 </summary>
        [Column("MBPYM")]
        public string MBPYM { get; set; }
        /// <summary> 医院ID </summary>
        [Column("HOSID")]
        public string HOSID { get; set; }
        /// <summary> 医院名称 </summary>
        [Column("HOSNAME")]
        public string HOSNAME { get; set; }
        /// <summary> 使用科室 </summary>
        [Column("SYKS")]
        public long? SYKS { get; set; }
        /// <summary> 使用组别(00-医生全院,01-医生科室,02-医生病区,10-护士全院,11-护士科室-12-护士病区) </summary>
        [Column("SYZB")]
        public string SYZB { get; set; }
        /// <summary> 创建人(新版本无用) </summary>
        [Column("CJR")]
        public string CJR { get; set; }
        /// <summary> 创建时间(新版本无用) </summary>
        [Column("CJSJ")]
        public string CJSJ { get; set; }
        /// <summary> 作废标记 </summary>
        [Column("DEL")]
        public long? DEL { get; set; }
        /// <summary> 文件夹ID(新版本无用) </summary>
        [Column("FL")]
        public string FL { get; set; }
        [Column("PLSX")]
        public int? PLSX { get; set; }
        [Column("PMBID")]
        public string PMBID { get; set; }
        [Column("PYM")]
        public string PYM { get; set; }

    }
}
