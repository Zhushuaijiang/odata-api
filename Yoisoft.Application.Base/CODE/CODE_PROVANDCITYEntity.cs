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
    /// 表：YY_CODE_PROVANDCITY 实体类   系统码表--行政区划
    /// </summary>
    public partial class CODE_PROVANDCITYEntity : IBaseEntity

    {

        #region 属性	

        /// <summary>
        /// ITEM_CODE  行政ID
        /// </summary>
        [Key]
        public string ITEM_CODE { get; set; }

        /// <summary>
        /// ITEM_NAME  行政名称
        /// </summary>
        public string ITEM_NAME { get; set; }

        /// <summary>
        /// LEVE  级别
        /// </summary>
        public int? LEVE { get; set; }

        /// <summary>
        /// ORDERINDEX  
        /// </summary>
        public int? ORDERINDEX { get; set; }

        #endregion


    }
}
