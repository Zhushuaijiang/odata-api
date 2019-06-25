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
    /// 表：YY_NURSE_CONSULTATION 实体类   
    /// </summary>
    public partial class NURSE_CONSULTATIONEntity : IBaseEntity  
  
	{

		#region 属性	
        
		/// <summary>
        /// ID  主键ID
        /// </summary>
        [Key]
		public string ID { get; set; }
        
		/// <summary>
        /// MRN  病案号
        /// </summary>
		public string MRN { get; set; }
        
		/// <summary>
        /// PATIENTID  病人序号
        /// </summary>
		public string PATIENTID { get; set; }
        
		/// <summary>
        /// CONSCIOUSNESS  意识
        /// </summary>
		public string CONSCIOUSNESS { get; set; }
        
		/// <summary>
        /// TEMPERATURE  体温
        /// </summary>
		public string TEMPERATURE { get; set; }
        
		/// <summary>
        /// PULSE  脉搏
        /// </summary>
		public string PULSE { get; set; }
        
		/// <summary>
        /// BREATH  呼吸
        /// </summary>
		public string BREATH { get; set; }
        
		/// <summary>
        /// SYSTOLICPRESSURE  收缩压
        /// </summary>
		public string SYSTOLICPRESSURE { get; set; }
        
		/// <summary>
        /// DIASTOLICPRESSURE  舒张压
        /// </summary>
		public string DIASTOLICPRESSURE { get; set; }
        
		/// <summary>
        /// COORDINATIONDEGREE  配合程度  1配合 0不配合
        /// </summary>
		public decimal? COORDINATIONDEGREE { get; set; }
        
		/// <summary>
        /// TRACHEOTOMY  气管切开  1有   0无
        /// </summary>
		public decimal? TRACHEOTOMY { get; set; }
        
		/// <summary>
        /// HORIZONTAL  平卧      1有   0无
        /// </summary>
		public decimal? HORIZONTAL { get; set; }
        
		/// <summary>
        /// ROUTINEBLOODTEST  血常规
        /// </summary>
		public string ROUTINEBLOODTEST { get; set; }
        
		/// <summary>
        /// CRUOR  凝血全套
        /// </summary>
		public string CRUOR { get; set; }
        
		/// <summary>
        /// LOCALRADIOTHERAPY  3个月内以局部放疗    1有   0无
        /// </summary>
		public decimal? LOCALRADIOTHERAPY { get; set; }
        
		/// <summary>
        /// LOCALINFECTION  局部感染             1有   0无
        /// </summary>
		public decimal? LOCALINFECTION { get; set; }
        
		/// <summary>
        /// TRAUMATICFRACTURE  外伤骨折             1有   0无
        /// </summary>
		public decimal? TRAUMATICFRACTURE { get; set; }
        
		/// <summary>
        /// TPOSITION  外伤骨折部位
        /// </summary>
		public string TPOSITION { get; set; }
        
		/// <summary>
        /// OPERATION  手术                 1有   0无
        /// </summary>
		public decimal? OPERATION { get; set; }
        
		/// <summary>
        /// OPOSITION  手术部位
        /// </summary>
		public string OPOSITION { get; set; }
        
		/// <summary>
        /// VENAPRESSURESIGN  上腔静脉压征         1有   0无
        /// </summary>
		public decimal? VENAPRESSURESIGN { get; set; }
        
		/// <summary>
        /// HISTORYVENIPUNCTURE  近期深静脉穿刺史     1有   0无
        /// </summary>
		public decimal? HISTORYVENIPUNCTURE { get; set; }
        
		/// <summary>
        /// HPOSITION  近期深静脉穿刺史部位
        /// </summary>
		public string HPOSITION { get; set; }
        
		/// <summary>
        /// HTIME  最近穿刺时间
        /// </summary>
		public DateTime? HTIME { get; set; }
        
		/// <summary>
        /// INFLUENTIALTREATMENT  对凝血功能有影响的治疗    1有   0无
        /// </summary>
		public decimal? INFLUENTIALTREATMENT { get; set; }
        
		/// <summary>
        /// INFLUENCE  影响
        /// </summary>
		public string INFLUENCE { get; set; }
        
		/// <summary>
        /// SIGNATURESIMPLEMENTATION  签字执行情况
        /// </summary>
		public string SIGNATURESIMPLEMENTATION { get; set; }
        
		/// <summary>
        /// BEDNO  病人床号
        /// </summary>
		public string BEDNO { get; set; }
        
		/// <summary>
        /// PATIENTNAME  病人姓名
        /// </summary>
		public string PATIENTNAME { get; set; }
        
		/// <summary>
        /// WARDCODE  病人病区代码
        /// </summary>
		public decimal? WARDCODE { get; set; }
        
		/// <summary>
        /// POSITION  会诊回复--位置
        /// </summary>
		public string POSITION { get; set; }
        
		/// <summary>
        /// IMPLANTATION  静脉将CVC/PICC导管置入
        /// </summary>
		public string IMPLANTATION { get; set; }
        
		/// <summary>
        /// LOCALANESTHESIA  利多卡因局麻
        /// </summary>
		public string LOCALANESTHESIA { get; set; }
        
		/// <summary>
        /// HEMORRHAGEAMOUNT  出血量
        /// </summary>
		public string HEMORRHAGEAMOUNT { get; set; }
        
		/// <summary>
        /// BLOODRETURN  回血
        /// </summary>
		public string BLOODRETURN { get; set; }
        
		/// <summary>
        /// PUNCTURESITE  穿刺局部
        /// </summary>
		public string PUNCTURESITE { get; set; }
        
		/// <summary>
        /// EDUCATION  置管后宣教执行      1是   0否
        /// </summary>
		public decimal? EDUCATION { get; set; }
        
		/// <summary>
        /// CATHETERIZATION  PICC置管
        /// </summary>
		public decimal? CATHETERIZATION { get; set; }
        
		/// <summary>
        /// ARMCIRCUMFERENCE  侧臂围
        /// </summary>
		public string ARMCIRCUMFERENCE { get; set; }
        
		/// <summary>
        /// FEMORALVEINCATHETERIZATION  股静脉置管
        /// </summary>
		public decimal? FEMORALVEINCATHETERIZATION { get; set; }
        
		/// <summary>
        /// THIGHCIRCUMFERENCE  侧大腿周径
        /// </summary>
		public string THIGHCIRCUMFERENCE { get; set; }
        
		/// <summary>
        /// OTHER  其他
        /// </summary>
		public string OTHER { get; set; }
        
		/// <summary>
        /// APPLYDATE  申请会诊日期
        /// </summary>
		public DateTime? APPLYDATE { get; set; }
        
		/// <summary>
        /// APPLICANTID  申请人
        /// </summary>
		public string APPLICANTID { get; set; }
        
		/// <summary>
        /// APPLICANTNAME  申请人姓名
        /// </summary>
		public string APPLICANTNAME { get; set; }
        
		/// <summary>
        /// INVITEDDEPARTMENTID  被邀请科室
        /// </summary>
		public decimal? INVITEDDEPARTMENTID { get; set; }
        
		/// <summary>
        /// INVITEDEXPERTID  被邀请专家
        /// </summary>
		public decimal? INVITEDEXPERTID { get; set; }
        
		/// <summary>
        /// CONSULTATIONREQUIREMENTS  会诊要求
        /// </summary>
		public string CONSULTATIONREQUIREMENTS { get; set; }
        
		/// <summary>
        /// APPLYDEPT  申请科室
        /// </summary>
		public decimal? APPLYDEPT { get; set; }
        
		/// <summary>
        /// AFSTATE  申请单状态 1：已回复，0：新开
        /// </summary>
		public decimal? AFSTATE { get; set; }
        
		/// <summary>
        /// REPLYTIME  答复时间    答复----请求会诊
        /// </summary>
		public DateTime? REPLYTIME { get; set; }
		
		#endregion 
		
		
	}

}
