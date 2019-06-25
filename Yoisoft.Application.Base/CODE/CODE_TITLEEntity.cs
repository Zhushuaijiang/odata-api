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
    /// 表：YY_CODE_TITLE 实体类   职称表
    /// </summary>
    public partial class CODE_TITLEEntity : IBaseEntity  
  
	{

		#region 属性	
        
		/// <summary>
        /// TITLEID  职称ID
        /// </summary>
        [Key]
		public int? TITLEID { get; set; }
        
		/// <summary>
        /// TITLENAME  职称名称
        /// </summary>
		public string TITLENAME { get; set; }
		
		#endregion 
		
		
	}

}
