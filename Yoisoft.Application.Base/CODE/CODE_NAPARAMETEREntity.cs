#region 说明

/* 以下代码由【ZCN.NET自动化项目生成器】自动生成！
 * 请勿随意修改，如果修改后导致程序无法正常运行，请重新再次生成！
 * 
 * 日期：2019-04-19 14:51:49
 * 说明：Ado.Net ORM 实体类
 */
 
#endregion

using System;
using System.ComponentModel.DataAnnotations;
using Yoisoft.Util;

namespace Yoisoft.Application.Base
{
  
   
    /// <summary>
    /// 表：YY_CODE_NAPARAMETER 实体类   
    /// </summary>
    public partial class CODE_NAPARAMETEREntity : IBaseEntity  
  
	{

		#region 属性	
        [Key]
        public int ID { get; set; }
		/// <summary>
        /// NAFORM  审核表单名称
        /// </summary>
		public string NAFORM { get; set; }
        
		/// <summary>
        /// DATAJSON  列表json数据
        /// </summary>
		public string DATAJSON { get; set; }
        
		/// <summary>
        /// CONDITION  条件
        /// </summary>
		public string CONDITION { get; set; }
        
		/// <summary>
        /// NALEVEL  审核级别
        /// </summary>
		public int? NALEVEL { get; set; }
		
		#endregion 
		
		
	}

}
