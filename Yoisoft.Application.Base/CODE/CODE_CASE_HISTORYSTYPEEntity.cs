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
    /// 表：YY_CODE_CASE_HISTORYSTYPE 实体类   病历类型
    /// </summary>
    public partial class CODE_CASE_HISTORYSTYPEEntity : IBaseEntity

    {

        #region 属性	

        /// <summary>
        /// CASEHISTORYSTYPE  病历类型
        /// </summary>
        [Key]
        public int? CASEHISTORYSTYPE { get; set; }

        /// <summary>
        /// CASEHISTORYSTYPENAME  类型名称
        /// </summary>
        public string CASEHISTORYSTYPENAME { get; set; }

        /// <summary>
        /// MEDICALRECORD  作废状态
        /// </summary>
        public int? MEDICALRECORD { get; set; }

        /// <summary>
        /// URL  路径
        /// </summary>
        public string URL { get; set; }

        /// <summary>
        /// ORDERINDEX  排序编号
        /// </summary>
        public int? ORDERINDEX { get; set; }

        /// <summary>
        /// CATEGORY  病历类别
        /// </summary>
        public int? CATEGORY { get; set; }

        #endregion


    }
}
