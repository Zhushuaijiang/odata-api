using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Util;

namespace Yoisoft.Application.Base
{
    public class Record_typeEntity : IBaseEntity
    {
        /// <summary> 页面控件编号 </summary>
        [Column("ITEMID")]
        [Key]
        public int ITEMID { get; set; }
        /// <summary> 项目ID </summary>
        [Column("XMID")]
        public int XMID { get; set; }
        /// <summary> 项目名称 </summary>
        [Column("XMNAME")]
        public string XMNAME { get; set; }
        /// <summary> 项目说明 </summary>
        [Column("XMSM")]
        public string XMSM { get; set; }
        /// <summary> 排序序号 </summary>
        [Column("ORDERINDEX")]
        public int? ORDERINDEX { get; set; }
        /// <summary> 删除标志，1为已删除 </summary>
        [Column("DEL_FLAG")]
        public string DEL_FLAG { get; set; }
        /// <summary>
        /// 自定义模板id
        /// </summary>
        [Column("SCHEMEID")]
        public string SCHEMEID { get; set; }

    }
}
