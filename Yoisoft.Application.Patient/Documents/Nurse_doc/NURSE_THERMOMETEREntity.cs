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
    /// 表：YY_NURSE_THERMOMETER 实体类   YY_NURSE_TWD  体温单Thermometer
    /// </summary>
    public partial class NURSE_THERMOMETEREntity : IBaseEntity  
  
	{

		#region 属性	
        
		/// <summary>
        /// ID  记录编号
        /// </summary>
		public string ID { get; set; }
        
		/// <summary>
        /// NID  护士ID
        /// </summary>
		public string NID { get; set; }
        
		/// <summary>
        /// DEFECATION  大便方式
        /// </summary>
		public decimal? DEFECATION { get; set; }
        
		/// <summary>
        /// FREQUENCY_DEFECATION  大便次数
        /// </summary>
		public string FREQUENCY_DEFECATION { get; set; }
        
		/// <summary>
        /// STOOL_ENEMA  大便灌肠量
        /// </summary>
		public string STOOL_ENEMA { get; set; }
        
		/// <summary>
        /// AMOUNT_ENTRY  入量
        /// </summary>
		public string AMOUNT_ENTRY { get; set; }
        
		/// <summary>
        /// AMOUNT_OUTPUT  出量量
        /// </summary>
		public string AMOUNT_OUTPUT { get; set; }
        
		/// <summary>
        /// URINE_VOLUME  尿量
        /// </summary>
		public string URINE_VOLUME { get; set; }
        
		/// <summary>
        /// WEIGHT  体重
        /// </summary>
		public string WEIGHT { get; set; }
        
		/// <summary>
        /// XT  暂时未知
        /// </summary>
		public string XT { get; set; }
        
		/// <summary>
        /// FW  暂时未知
        /// </summary>
		public string FW { get; set; }
        
		/// <summary>
        /// HEIGHT  身高
        /// </summary>
		public string HEIGHT { get; set; }
        
		/// <summary>
        /// OTHER  其他
        /// </summary>
		public string OTHER { get; set; }
        
		/// <summary>
        /// RECORDING_TIME  记录时间
        /// </summary>
		public DateTime? RECORDING_TIME { get; set; }
        
		/// <summary>
        /// OPERATION_DAYS  手术天数
        /// </summary>
		public string OPERATION_DAYS { get; set; }
        
		/// <summary>
        /// PATIENTID  病人ID
        /// </summary>
		public string PATIENTID { get; set; }
        
		/// <summary>
        /// BABYID  婴儿序号
        /// </summary>
		public string BABYID { get; set; }
        
		/// <summary>
        /// ACTUAL_RECORDING_TIME  实际记录时间
        /// </summary>
		public DateTime? ACTUAL_RECORDING_TIME { get; set; }
        
		/// <summary>
        /// OUTPUT_TYPE  出量类型
        /// </summary>
		public string OUTPUT_TYPE { get; set; }
        
		/// <summary>
        /// AMOUNT_TIME  出量时间
        /// </summary>
		public DateTime? AMOUNT_TIME { get; set; }
        
		/// <summary>
        /// BODY_TEMPERATURE_TYPE   体温单类型 1:普通 2:新生儿
        /// </summary>
		public decimal? BODY_TEMPERATURE_TYPE { get; set; }
        
		/// <summary>
        /// TRANSCUTANEOUS_BILIRUBIN  经皮测胆红素
        /// </summary>
		public string TRANSCUTANEOUS_BILIRUBIN { get; set; }
        
		/// <summary>
        /// FAST_BLOOD_SUGAR  快速血糖
        /// </summary>
		public string FAST_BLOOD_SUGAR { get; set; }
        
		/// <summary>
        /// URINE  小便
        /// </summary>
		public string URINE { get; set; }
        
		/// <summary>
        /// AMOUNT_OUTPUT_HOUR  出量小时
        /// </summary>
		public decimal? AMOUNT_OUTPUT_HOUR { get; set; }
        
		/// <summary>
        /// AMOUNT_ENTRY_HOUR  入量小时
        /// </summary>
		public decimal? AMOUNT_ENTRY_HOUR { get; set; }
        
		/// <summary>
        /// WAYOFWALK  行走方式
        /// </summary>
		public string WAYOFWALK { get; set; }
        
		/// <summary>
        /// FREQUENCY_STOOL_ENEMA  大便灌肠次数
        /// </summary>
		public decimal? FREQUENCY_STOOL_ENEMA { get; set; }
        
		/// <summary>
        /// ABDOMINAL_CIRCUMFERENCE  腹维
        /// </summary>
		public string ABDOMINAL_CIRCUMFERENCE { get; set; }
        
		/// <summary>
        /// BEDTEMPERATURE  床温（早产婴儿专用）
        /// </summary>
		public string BEDTEMPERATURE { get; set; }
		
		#endregion 
		
		
	}
    /// <summary>
    /// 体温单数据
    /// </summary>
    public class TemperatureChart
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string NAME { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string SEX { get; set; }
        /// <summary>
        /// 年龄单位
        /// </summary>
        public string UNIT { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public string AGE { get; set; }
        /// <summary>
        /// 科室代码
        /// </summary>
        public string DEPTCODE { get; set; }
        /// <summary>
        /// 床号
        /// </summary>
        public string BEDNO { get; set; }
        /// <summary>
        /// 住院号
        /// </summary>
        public string PATIENTID { get; set; }
        /// <summary>
        /// 入院时间
        /// </summary>
        public string INADMITTIME { get; set; }
        /// <summary>
        /// 出院时间
        /// </summary>
        public string OUTADMITTIME { get; set; }
        /// <summary>
        /// 体温记录
        /// </summary>   
        public TemperatureSerieslist[] temperatureSerieslists { get; set; }
        public Serieslist[] serieslists { get; set; }
    }
    //体温表一天一次出量入量显示，体温记录数据多条
    public class TemperatureSerieslist
    {
        public int SORTINDEX { get; set; }
        public string ID { get; set; }//记录编号
        public string NID { get; set; }//护士id
        public string DEFECATION { get; set; }//大便方式
        public string FREQUENCY_DEFECATION { get; set; }//大便次数
        public string STOOL_ENEMA { get; set; }//大便灌肠量
        public string AMOUNT_ENTRY { get; set; }//入量
        public string AMOUNT_OUTPUT { get; set; }//出量
        public string URINE_VOLUME { get; set; }//尿量
        public string WEIGHT { get; set; }//体重
        public string HEIGHT { get; set; }//身高
        public string SUPPLEMENT { get; set; }//补充
        public string OTHER { get; set; }//其他
        public string RECORDING_TIME { get; set; }//记录时间
        public string OPERATION_DAYS { get; set; }//手术天数
        public string PATIENTID { get; set; }//病人id
        public string BABYID { get; set; }//婴儿序号
        public string ACTUAL_RECORDING_TIME { get; set; } //实际记录时间
        public string OUTPUT_TYPE { get; set; }//出量类型
        public string AMOUNT_TIME { get; set; }//出量时间
        public string BODY_TEMPERATURE_TYPE { get; set; }// 体温单类型 1:普通 2:新生儿


    }
    /// <summary>
    /// 体温记录数据list
    /// </summary>
    public class Serieslist
    {
        public string IS_PULSE { get; set; }
        /// <summary>
        ///  测量日期
        /// </summary>
        public string MEASUREMENT_TIME { get; set; }
        /// <summary>
        /// 体温类型
        /// </summary>
        public string BODY_TEMPERATURE_TYPE { get; set; }
        /// <summary>
        /// 补充记录
        /// </summary>
        public string SUPPLEMENT { get; set; }
        /// <summary>
        /// 温度坐标集合
        /// </summary>
        public TemperatureCoordinates[] temperatureCoordinates { get; set; }
        /// <summary>
        /// 心率脉搏坐标集合
        /// </summary>
        public PluseCoordinates[] pluseCoordinates { get; set; }
        /// <summary>
        /// 呼吸次数
        /// </summary>
        public Numberofbreaths[] numberofbreaths { get; set; }
        /// <summary>
        /// 疼痛强度
        /// </summary>
        public PlainLevels[] plainLevels { get; set; }
        /// <summary>
        /// 血压1
        /// </summary>
        public BloodPress1[] bloodPress1 { get; set; }
        /// <summary>
        /// 血压2
        /// </summary>
        public BloodPress2[] bloodPress2 { get; set; }
        /// <summary>
        ///  spo2
        /// </summary>
        public Spo2[] spo2 { get; set; }
    }
    /// <summary>
    /// 温度坐标
    /// </summary>
    public class TemperatureCoordinates
    {
        /// <summary>
        /// 横坐标-时间
        /// </summary>
        public int x { get; set; }
        /// <summary>
        /// 纵坐标-数值
        /// </summary>
        public string y { get; set; }
    }
    /// <summary>
    /// 心率脉搏
    /// </summary>
    public class PluseCoordinates
    {
        /// <summary>
        /// 横坐标-时间
        /// </summary>
        public int x { get; set; }
        /// <summary>
        /// 纵坐标-数值
        /// </summary>
        public string y { get; set; }
    }
    /// <summary>
    /// 呼吸
    /// </summary>
    public class Numberofbreaths
    {
        public int x { get; set; }
        public string y { get; set; }
        //public string breaths { get; set; }
    }
    /// <summary>
    /// 脉搏
    /// </summary>
    public class PlainLevels
    {
        public int x { get; set; }
        public string y { get; set; }
    }

    /// <summary>
    /// 血压1
    /// </summary>
    public class BloodPress1
    {
        public int x { get; set; }
        public string y { get; set; }
    }
    /// <summary>
    /// 血压2
    /// </summary>
    public class BloodPress2
    {
        public int x { get; set; }
        public string y { get; set; }
    }
    /// <summary>
    /// 血氧饱和度
    /// </summary>
    public class Spo2
    {
        public int x { get; set; }
        public string y { get; set; }
    }

}
