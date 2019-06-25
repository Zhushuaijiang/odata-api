#region 说明

/* 以下代码由【ZCN.NET自动化项目生成器】自动生成！
 * 请勿随意修改，如果修改后导致程序无法正常运行，请重新再次生成！
 * 
 * 日期：2019-04-19 14:56:59
 * 说明：Ado.Net ORM 实体类
 */
 
#endregion

using System;
using Yoisoft.Util;

namespace Yoisoft.Application.Patient
{
  
   
    /// <summary>
    /// 表：YY_NURSE_THERMOMETER_RECORD 实体类   YY_NURSE_TWJL 体温记录 Thermometer record


    /// </summary>
    public partial class NURSE_THERMOMETER_RECORDEntity : IBaseEntity  
  
	{

		#region 属性	
        
		/// <summary>
        /// ID  记录编号
        /// </summary>
		public string ID { get; set; }
        
		/// <summary>
        /// RECORDING_TIME  记录时间
        /// </summary>
		public DateTime? RECORDING_TIME { get; set; }
        
		/// <summary>
        /// MEASUREMENT_TIME  测量时间
        /// </summary>
		public DateTime? MEASUREMENT_TIME { get; set; }
        
		/// <summary>
        /// NURSE_ID  护士ID
        /// </summary>
		public string NURSE_ID { get; set; }
        
		/// <summary>
        /// BODY_TEMPERATURE_TYPE   体温类型 0-口温，1-腋温，2-肛温
        /// </summary>
		public decimal? BODY_TEMPERATURE_TYPE { get; set; }
        
		/// <summary>
        /// TEMPERATURE  体温
        /// </summary>
		public string TEMPERATURE { get; set; }
        
		/// <summary>
        /// PULSE  脉搏
        /// </summary>
		public string PULSE { get; set; }
        
		/// <summary>
        /// BREATHING  呼吸
        /// </summary>
		public string BREATHING { get; set; }
        
		/// <summary>
        /// BLOOD_PRESSURE_1  血压1
        /// </summary>
		public string BLOOD_PRESSURE_1 { get; set; }
        
		/// <summary>
        /// BLOOD_PRESSURE_2  血压2
        /// </summary>
		public string BLOOD_PRESSURE_2 { get; set; }
        
		/// <summary>
        /// OXYGEN_SATURATION  氧饱和度
        /// </summary>
		public string OXYGEN_SATURATION { get; set; }
        
		/// <summary>
        /// TYPE_MEASUREMENT  测量类型，有常规-0和降温后半小时-1，主要用来画图
        /// </summary>
		public string TYPE_MEASUREMENT { get; set; }
        
		/// <summary>
        /// SUPPLEMENT  体温补充内容
        /// </summary>
		public string SUPPLEMENT { get; set; }
        
		/// <summary>
        /// RECORD_CATEGORY  记录类别，1-表示观察体征
        /// </summary>
		public string RECORD_CATEGORY { get; set; }
        
		/// <summary>
        /// ACTUAL_RECORDING_TIME  实际记录时间
        /// </summary>
		public DateTime? ACTUAL_RECORDING_TIME { get; set; }
        
		/// <summary>
        /// PATIENTID  病人ID
        /// </summary>
		public string PATIENTID { get; set; }
        
		/// <summary>
        /// BABYID  婴儿ID
        /// </summary>
		public string BABYID { get; set; }
        
		/// <summary>
        /// IS_PULSE  是否脉搏 0脉搏 1心率
        /// </summary>
		public decimal? IS_PULSE { get; set; }
        
		/// <summary>
        /// SUPPLEMENTARY_DESCRIPTION  补充描述
        /// </summary>
		public string SUPPLEMENTARY_DESCRIPTION { get; set; }
        
		/// <summary>
        /// HZJC  暂时未知 
        /// </summary>
		public string HZJC { get; set; }
        
		/// <summary>
        /// PLAINLEVEL  疼痛强度
        /// </summary>
		public string PLAINLEVEL { get; set; }
        
		/// <summary>
        /// AFTERPLAIN  疼痛之后时间
        /// </summary>
		public string AFTERPLAIN { get; set; }
        
		/// <summary>
        /// SUPPLEMENT_TYPE  补充类型
        /// </summary>
		public string SUPPLEMENT_TYPE { get; set; }
		
		#endregion 
		
		
	}

}
