using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Util;

namespace Yoisoft.Application.Base
{
    /// 表：YY_CODE_CAREER 实体类   系统码表--职业
    /// </summary>
    public partial class CODE_CAREEREntity : IBaseEntity

    {

        #region 属性	

        /// <summary>
        /// CAREERID  职业ID
        /// </summary>
        [Key]
        public int? CAREERID { get; set; }

        /// <summary>
        /// CAREERNAME  职业名称
        /// </summary>
        public string CAREERNAME { get; set; }

        /// <summary>
        /// INVALIDSTATE  作废状态
        /// </summary>
        public int? INVALIDSTATE { get; set; }

        #endregion


    }
}
