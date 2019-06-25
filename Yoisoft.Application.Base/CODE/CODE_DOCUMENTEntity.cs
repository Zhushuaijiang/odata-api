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
    /// 表：YY_CODE_DOCUMENT 实体类   入院记录文书类型码表
    /// </summary>
    public partial class CODE_DOCUMENTEntity : IBaseEntity
    {
        #region 属性	
        /// <summary>
        /// DOCUMENTTYPE  文书类型
        /// </summary>
        [Key]
        public string DOCUMENTTYPE { get; set; }

        /// <summary>
        /// DOCUMENTNAME  文书名称
        /// </summary>
        public string DOCUMENTNAME { get; set; }

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
        /// CHIEF_COMPLAINTSIGN  主诉标志
        /// </summary>
        public int? CHIEF_COMPLAINTSIGN { get; set; }

        /// <summary>
        /// CASEHISTORYSTYPE  病理类型
        /// </summary>
        public int? CASEHISTORYSTYPE { get; set; }

        /// <summary>
        /// CATEGORY  病历类别   0-西医  1-中医
        /// </summary>
        public int? CATEGORY { get; set; }

        #endregion


    }
}
