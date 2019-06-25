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
    /// 表：YY_SYS_REPORTCARD 实体类   
    /// </summary>
    public partial class SYS_REPORTCARDEntity : IBaseEntity  
  
	{

		#region 属性	
        
		/// <summary>
        /// ID  唯一ID
        /// </summary>
        [Key]
		public string ID { get; set; }
        
		/// <summary>
        /// SCHEMEID  自定义模板id
        /// </summary>
		public string SCHEMEID { get; set; }
        
		/// <summary>
        /// SCHEMEVER  自定义模板版本号id
        /// </summary>
		public string SCHEMEVER { get; set; }
        
		/// <summary>
        /// PATIENTID  病人id
        /// </summary>
		public string PATIENTID { get; set; }
        
		/// <summary>
        /// TEMPLETENAME  表单名称
        /// </summary>
		public string TEMPLETENAME { get; set; }
        
		/// <summary>
        /// CREATETIME  创建时间
        /// </summary>
		public DateTime? CREATETIME { get; set; }
        
		/// <summary>
        /// CREATEUSERID  创建人id
        /// </summary>
		public string CREATEUSERID { get; set; }
        
		/// <summary>
        /// CREATEUSER  创建人姓名
        /// </summary>
		public string CREATEUSER { get; set; }
        
		/// <summary>
        /// MODIFYTIME  修改时间
        /// </summary>
		public DateTime? MODIFYTIME { get; set; }
        
		/// <summary>
        /// MODIFYUSERID  修改人id
        /// </summary>
		public string MODIFYUSERID { get; set; }
        
		/// <summary>
        /// MODIFYUSER  修改人姓名
        /// </summary>
		public string MODIFYUSER { get; set; }
        
		/// <summary>
        /// ISDEL  是否删除
        /// </summary>
		public string ISDEL { get; set; }
        
		/// <summary>
        /// RELATIONID  表单数据关联id，UniqueId
        /// </summary>
		public string RELATIONID { get; set; }
		
		#endregion 
		
		
	}

}
