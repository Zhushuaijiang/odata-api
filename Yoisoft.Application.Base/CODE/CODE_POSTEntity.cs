#region 说明

/* 以下代码由【ZCN.NET自动化项目生成器】自动生成！
 * 请勿随意修改，如果修改后导致程序无法正常运行，请重新再次生成！
 * 
 * 日期：2019-04-19 14:52:25
 * 说明：Ado.Net ORM 实体类
 */
 
#endregion

using System;
using System.ComponentModel.DataAnnotations;
using Yoisoft.Util;

namespace Yoisoft.Application.Base
{
  
   
    /// <summary>
    /// 表：YY_CODE_POST 实体类   职位表
    /// </summary>
    public partial class CODE_POSTEntity : IBaseEntity  
  
	{

		#region 属性	
        
		/// <summary>
        /// POSTID  职位ID
        /// </summary>
       [Key]
		public int? POSTID { get; set; }
        
		/// <summary>
        /// POSTNAME  职位名称
        /// </summary>
		public string POSTNAME { get; set; }
		
		#endregion 
		
		
	}

}
