#region 说明

/* 以下代码由【ZCN.NET自动化项目生成器】自动生成！
 * 请勿随意修改，如果修改后导致程序无法正常运行，请重新再次生成！
 * 
 * 日期：2019-04-19 14:51:03
 * 说明：Ado.Net ORM 实体类
 */
 
#endregion

using System;
using System.ComponentModel.DataAnnotations;
using Yoisoft.Util;

namespace Yoisoft.Application.Base
{
  
   
    /// <summary>
    /// 表：YY_CODE_ITEM 实体类   项目代码表
    /// </summary>
    public partial class CODE_ITEMEntity : IBaseEntity  
  
	{

        #region 属性	

        /// <summary>
        /// ID  ID
        /// </summary>
        [Key]
        public int? ID { get; set; }
        
		/// <summary>
        /// ITEMID  项目ID
        /// </summary>
		public int? ITEMID { get; set; }
        
		/// <summary>
        /// ITEMNAME  项目名称
        /// </summary>
		public string ITEMNAME { get; set; }
        
		/// <summary>
        /// ORDERINDEX  排序
        /// </summary>
		public int? ORDERINDEX { get; set; }
		
		#endregion 
		
		
	}

}
