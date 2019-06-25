#region 说明

/* 以下代码由【ZCN.NET自动化项目生成器】自动生成！
 * 请勿随意修改，如果修改后导致程序无法正常运行，请重新再次生成！
 * 
 * 日期：2019-04-19 14:56:59
 * 说明：Ado.Net ORM 实体类
 */
 
#endregion

using System;
using System.ComponentModel.DataAnnotations;
using Yoisoft.Util;

namespace Yoisoft.Application.Base
{
  
   
    /// <summary>
    /// 表：YY_CODE_SEX 实体类   性别表
    /// </summary>
    public partial class CODE_SEXEntity : IBaseEntity  
  
	{

		#region 属性	
        
		/// <summary>
        /// SEXID  性别ID
        /// </summary>
        [Key]
		public int? SEXID { get; set; }
        
		/// <summary>
        /// SEXNAME  性别名称
        /// </summary>
		public string SEXNAME { get; set; }
		
		#endregion 
		
		
	}

}
