#region 说明

/* 以下代码由【ZCN.NET自动化项目生成器】自动生成！
 * 请勿随意修改，如果修改后导致程序无法正常运行，请重新再次生成！
 * 
 * 日期：2019-04-19 14:52:04
 * 说明：Ado.Net ORM 实体类
 */
 
#endregion

using System;
using System.ComponentModel.DataAnnotations;
using Yoisoft.Util;

namespace Yoisoft.Application.Base
{
  
   
    /// <summary>
    /// 表：YY_CODE_ORGAN 实体类   机构表
    /// </summary>
    public partial class CODE_ORGANEntity : IBaseEntity  
  
	{

		#region 属性	
        
		/// <summary>
        /// ORGANID  机构ID
        /// </summary>
        [Key]
		public int? ORGANID { get; set; }
        
		/// <summary>
        /// ORGANNAME  机构名称
        /// </summary>
		public string ORGANNAME { get; set; }
        
		/// <summary>
        /// INVALIDSTATE  作废状态
        /// </summary>
		public int? INVALIDSTATE { get; set; }
		
		#endregion 
		
		
	}

}
