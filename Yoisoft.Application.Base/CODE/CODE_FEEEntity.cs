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
    /// 表：YY_CODE_FEE 实体类   系统码表--病人性质
    /// </summary>
    public partial class CODE_FEEEntity : IBaseEntity

    {

        #region 属性	

        /// <summary>
        /// FEEID  性质ID
        /// </summary>
        [Key]
        public string FEEID { get; set; }

        /// <summary>
        /// FEENAME  性质名称
        /// </summary>
        public string FEENAME { get; set; }

        /// <summary>
        /// INVALIDSTATE  作废状态
        /// </summary>
        public int? INVALIDSTATE { get; set; }

        #endregion


    }
}
