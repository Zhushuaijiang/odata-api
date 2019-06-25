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
    /// 表：YY_NURSE_RESCUERECORD 实体类   
    /// </summary>
    public partial class NURSE_RESCUERECORDEntity : IBaseEntity  
  
	{

		#region 属性	
        
		/// <summary>
        /// PATIENTID  病人ID
        /// </summary>
        [Key]
		public string PATIENTID { get; set; }
        
		/// <summary>
        /// RESCUE_STARTTIME  抢救时间
        /// </summary>
		public DateTime? RESCUE_STARTTIME { get; set; }
        
		/// <summary>
        /// CHIEF_COMPLAINT  主诉
        /// </summary>
		public string CHIEF_COMPLAINT { get; set; }
        
		/// <summary>
        /// PRESENT_ILLNESS  现病史
        /// </summary>
		public string PRESENT_ILLNESS { get; set; }
        
		/// <summary>
        /// ALLERGY_HISTORY  过敏史
        /// </summary>
		public string ALLERGY_HISTORY { get; set; }
        
		/// <summary>
        /// PAST_HISTORY  既往史
        /// </summary>
		public string PAST_HISTORY { get; set; }
        
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
        /// CONSCIOUSNESS  意识
        /// </summary>
		public string CONSCIOUSNESS { get; set; }
        
		/// <summary>
        /// SKIN  皮肤
        /// </summary>
		public string SKIN { get; set; }
        
		/// <summary>
        /// PUPIL  瞳孔
        /// </summary>
		public string PUPIL { get; set; }
        
		/// <summary>
        /// LIGHT_REFLECTION  对光反射
        /// </summary>
		public string LIGHT_REFLECTION { get; set; }
        
		/// <summary>
        /// NECK  头颈部
        /// </summary>
		public string NECK { get; set; }
        
		/// <summary>
        /// CHEST  胸部
        /// </summary>
		public string CHEST { get; set; }
        
		/// <summary>
        /// HEART  心
        /// </summary>
		public string HEART { get; set; }
        
		/// <summary>
        /// LUNG  肺
        /// </summary>
		public string LUNG { get; set; }
        
		/// <summary>
        /// ABDOMEN  腹
        /// </summary>
		public string ABDOMEN { get; set; }
        
		/// <summary>
        /// SPINE_LIMBS  脊柱四肢
        /// </summary>
		public string SPINE_LIMBS { get; set; }
        
		/// <summary>
        /// OTHER  其他
        /// </summary>
		public string OTHER { get; set; }
        
		/// <summary>
        /// ACCESSORY_EXAMINATION  辅助检查
        /// </summary>
		public string ACCESSORY_EXAMINATION { get; set; }
        
		/// <summary>
        /// DRAWUP_DX  拟诊断
        /// </summary>
		public string DRAWUP_DX { get; set; }
        
		/// <summary>
        /// CAUSE_INJURY  损伤原因
        /// </summary>
		public string CAUSE_INJURY { get; set; }
        
		/// <summary>
        /// RESCUE_MEASURES  处理过程---措施
        /// </summary>
		public string RESCUE_MEASURES { get; set; }
        
		/// <summary>
        /// RESCUE_PROCESS  处理过程---过程
        /// </summary>
		public string RESCUE_PROCESS { get; set; }
        
		/// <summary>
        /// FIRST_AID_EFFECT  积极效果
        /// </summary>
		public string FIRST_AID_EFFECT { get; set; }
        
		/// <summary>
        /// MAJOR_EVENTS  重大事件
        /// </summary>
		public string MAJOR_EVENTS { get; set; }
        
		/// <summary>
        /// WHEREABOUTS  去向
        /// </summary>
		public string WHEREABOUTS { get; set; }
        
		/// <summary>
        /// RESCUE_NURSE  抢救护士
        /// </summary>
		public string RESCUE_NURSE { get; set; }
        
		/// <summary>
        /// RESCUE_DOCTORS  抢救医生
        /// </summary>
		public string RESCUE_DOCTORS { get; set; }
        
		/// <summary>
        /// WRITINGTIME  书写时间
        /// </summary>
		public DateTime? WRITINGTIME { get; set; }
        
		/// <summary>
        /// RESCUE_MEDICINE  处理过程---药物
        /// </summary>
		public string RESCUE_MEDICINE { get; set; }
        
		/// <summary>
        /// CARDIAC_DEFIBRILLATION  心脏除颤
        /// </summary>
		public decimal? CARDIAC_DEFIBRILLATION { get; set; }
		
		#endregion 
		
		
	}

}
