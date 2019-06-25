using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Util;

namespace Yoisoft.Application.Base
{
    /// <summary>
    /// 表：YY_CODE_BASIC 实体类   基础护理码表
    /// </summary>
    public partial class CODE_BASICEntity : IBaseEntity

    {

        #region 属性	

        /// <summary>
        /// ID  主键ID
        /// </summary>
        [Key]
        public int? ID { get; set; }

        /// <summary>
        /// NURSINGNAME  代码名称 
        /// </summary>
        public string NURSINGNAME { get; set; }

        /// <summary>
        /// ORDERINDEX  排序
        /// </summary>
        public int? ORDERINDEX { get; set; }

        /// <summary>
        /// ITEM  代码类型
        /// </summary>
        public int? ITEM { get; set; }

        /// <summary>
        /// INVALIDSTATE  作废
        /// </summary>
        public int? INVALIDSTATE { get; set; }

        #endregion


    }
}
