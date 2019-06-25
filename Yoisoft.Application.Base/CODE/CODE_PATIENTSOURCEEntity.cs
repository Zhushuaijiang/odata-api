#region 说明

/* 以下代码由【ZCN.NET自动化项目生成器】自动生成！
 * 请勿随意修改，如果修改后导致程序无法正常运行，请重新再次生成！
 * 
 * 日期：2019-04-19 14:52:19
 * 说明：Ado.Net ORM 实体类
 */
 
#endregion

using System;
using System.ComponentModel.DataAnnotations;
using Yoisoft.Util;

namespace Yoisoft.Application.Base
{
  
   
    /// <summary>
    /// 表：YY_CODE_PATIENTSOURCE 实体类   系统码表---病人来源
    /// </summary>
    public partial class CODE_PATIENTSOURCEEntity : IBaseEntity  
  
	{

		#region 属性	
        
		/// <summary>
        /// PATIENTSOURCEID  病人来源ID
        /// </summary>
        [Key]
		public int? PATIENTSOURCEID { get; set; }
        
		/// <summary>
        /// PATIENTSOURCE  病人来源名称
        /// </summary>
		public string PATIENTSOURCE { get; set; }
        
		/// <summary>
        /// MEDICALRECORD  作废状态
        /// </summary>
		public int? MEDICALRECORD { get; set; }
		
		#endregion 
		
		
	}

}
