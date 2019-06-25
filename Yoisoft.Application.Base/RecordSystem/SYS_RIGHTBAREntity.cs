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
    /// 表：YY_SYS_RIGHTBAR 实体类   
    /// </summary>
    public partial class SYS_RIGHTBAREntity : IBaseEntity  
  
	{

        #region 属性	

        /// <summary>
        /// ID  
        /// </summary>
        [Key]
        public int? ID { get; set; }
        
		/// <summary>
        /// DIVID  
        /// </summary>
		public string DIVID { get; set; }
        
		/// <summary>
        /// CDDR  
        /// </summary>
		public string CDDR { get; set; }
        
		/// <summary>
        /// CDDI  
        /// </summary>
		public string CDDI { get; set; }
        
		/// <summary>
        /// URL  
        /// </summary>
		public string URL { get; set; }
        
		/// <summary>
        /// STATE  
        /// </summary>
		public string STATE { get; set; }
		
		#endregion 
		
		
	}

}
