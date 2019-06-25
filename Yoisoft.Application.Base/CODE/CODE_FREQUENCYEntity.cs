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
    /// 表：YY_CODE_FREQUENCY 实体类   用药频率表
    /// </summary>
    public partial class CODE_FREQUENCYEntity : IBaseEntity

    {

        #region 属性	

        /// <summary>
        /// ID  ID主键 
        /// </summary>
        [Key]
        public int? ID { get; set; }

        /// <summary>
        /// FREQUENCYNAME  频率名称
        /// </summary>
        public string FREQUENCYNAME { get; set; }

        /// <summary>
        /// REMARK  备注
        /// </summary>
        public string REMARK { get; set; }

        /// <summary>
        /// CODE  代码
        /// </summary>
        public string CODE { get; set; }

        /// <summary>
        /// DELFLAG  
        /// </summary>
        public string DELFLAG { get; set; }

        #endregion


    }

}