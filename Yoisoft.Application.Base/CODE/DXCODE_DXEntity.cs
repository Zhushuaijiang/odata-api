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
    /// 表：YY_DXCODE_DX 实体类   
    /// </summary>
    public partial class DXCODE_DXEntity : IBaseEntity  
  
	{

		#region 属性	
        
		/// <summary>
        /// DXCODE  诊断代码
        /// </summary>
        [Key]
		public string DXCODE { get; set; }
        
		/// <summary>
        /// DXNAME  诊断名称
        /// </summary>
		public string DXNAME { get; set; }
        
		/// <summary>
        /// ICD10  ICD10
        /// </summary>
		public string ICD10 { get; set; }
        
		/// <summary>
        /// ICD9  ICD9
        /// </summary>
		public string ICD9 { get; set; }
        
		/// <summary>
        /// INPUTCODE1  输入码1
        /// </summary>
		public string INPUTCODE1 { get; set; }
        
		/// <summary>
        /// INPUTCODE2  输入码2
        /// </summary>
		public string INPUTCODE2 { get; set; }
        
		/// <summary>
        /// INPUTCODE3  输入码3
        /// </summary>
		public string INPUTCODE3 { get; set; }
        
		/// <summary>
        /// MRNUMBER  病案序号
        /// </summary>
		public int? MRNUMBER { get; set; }
        
		/// <summary>
        /// DEPTCODE  科室代码
        /// </summary>
		public int? DEPTCODE { get; set; }
        
		/// <summary>
        /// REPORTCARD_TYPE  报卡类型
        /// </summary>
		public int? REPORTCARD_TYPE { get; set; }
        
		/// <summary>
        /// INFECT_SORT  感染排序
        /// </summary>
		public int? INFECT_SORT { get; set; }
        
		/// <summary>
        /// DESCRIPTION  描述
        /// </summary>
		public string DESCRIPTION { get; set; }
        
		/// <summary>
        /// SYSLEVEL  系统级别类型:1损伤诊断，2病理诊断,0西医诊断,3中医病证,4中医证型
        /// </summary>
		public int? SYSLEVEL { get; set; }
        
		/// <summary>
        /// LEVELSTATISTICS9  系统级别统计9
        /// </summary>
		public int? LEVELSTATISTICS9 { get; set; }
        
		/// <summary>
        /// LEVELSTATISTICS10  系统级别统计10
        /// </summary>
		public int? LEVELSTATISTICS10 { get; set; }
        
		/// <summary>
        /// INVALIDSTATE  作废状态
        /// </summary>
		public int? INVALIDSTATE { get; set; }
		
		#endregion 
		
		
	}

}
