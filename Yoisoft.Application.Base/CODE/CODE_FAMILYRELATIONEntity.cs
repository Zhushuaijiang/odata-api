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
    /// 表：YY_CODE_FAMILYRELATION 实体类   家庭关系表
    /// </summary>
    public partial class CODE_FAMILYRELATIONEntity : IBaseEntity

    {

        #region 属性	

        /// <summary>
        /// RELATIONID  关系ID
        /// </summary>
        [Key]
        public int? RELATIONID { get; set; }

        /// <summary>
        /// RELATIONNAME  关系名称
        /// </summary>
        public string RELATIONNAME { get; set; }

        #endregion


    }
}
