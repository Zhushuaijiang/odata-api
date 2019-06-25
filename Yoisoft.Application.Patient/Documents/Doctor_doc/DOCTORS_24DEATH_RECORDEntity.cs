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

namespace Yoisoft.Application.Patient
{
  
   
    /// <summary>
    /// 表：YY_DOCTORS_24DEATH_RECORD 实体类   24小时死亡记录
    /// </summary>
    public partial class DOCTORS_24DEATH_RECORDEntity : IBaseEntity  
  
	{

		#region 属性	
        
		/// <summary>
        /// PATIENTID  病人序号
        /// </summary>
        [Key]
		public string PATIENTID { get; set; }
        
		/// <summary>
        /// DEATHTIME  死亡时间
        /// </summary>
		public DateTime? DEATHTIME { get; set; }
        
		/// <summary>
        /// CHIEF_COMPLAINT  主诉
        /// </summary>
		public string CHIEF_COMPLAINT { get; set; }
        
		/// <summary>
        /// ADMISSION_IS  入院情况
        /// </summary>
		public string ADMISSION_IS { get; set; }
        
		/// <summary>
        /// DIAGNOSIS_AND_TREATMENT  诊疗经过
        /// </summary>
		public string DIAGNOSIS_AND_TREATMENT { get; set; }
        
		/// <summary>
        /// DEATHHOSPITAL  死亡医院
        /// </summary>
		public string DEATHHOSPITAL { get; set; }
        
		/// <summary>
        /// WRITING_DOCTORS  书写医生
        /// </summary>
		public string WRITING_DOCTORS { get; set; }
        
		/// <summary>
        /// RECORDTIME  记录时间
        /// </summary>
		public DateTime? RECORDTIME { get; set; }
        
		/// <summary>
        /// WRITINGTIME  书写时间
        /// </summary>
		public DateTime? WRITINGTIME { get; set; }
        
		/// <summary>
        /// SUPERIOR_DOCTORS  上级医生
        /// </summary>
		public string SUPERIOR_DOCTORS { get; set; }
        
		/// <summary>
        /// OTHER  其他
        /// </summary>
		public string OTHER { get; set; }
        
		/// <summary>
        /// BIRTHDATE  出生日期
        /// </summary>
		public DateTime? BIRTHDATE { get; set; }
		
		#endregion 
		
		
	}

}
