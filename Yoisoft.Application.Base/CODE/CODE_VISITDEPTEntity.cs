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
    /// 表：YY_CODE_VISITDEPT 实体类   就诊科室
    /// </summary>
    public partial class CODE_VISITDEPTEntity : IBaseEntity  
  
	{

		#region 属性	
        
		/// <summary>
        /// ID  主键ID
        /// </summary>
        [Key]
		public string ID { get; set; }
        
		/// <summary>
        /// DEPTCODE  科室代码
        /// </summary>
		public int? DEPTCODE { get; set; }
        
		/// <summary>
        /// DEPTNAME  科室名称
        /// </summary>
		public string DEPTNAME { get; set; }
		
		#endregion 
		
		
	}

}
