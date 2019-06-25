using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Util;

namespace Yoisoft.Application.Patient
{
    public class DiagnosisEntity: IBaseEntity
    {
        /// <summary> 诊断表编号---主键ID </summary>
        [Key]
        [Column("ID")]
        public string ID { get; set; }
        [Column("PATIENTID")]
        /// <summary> 病人序号 </summary>         
        public string PATIENTID { get; set; }
        /// <summary> 诊断序号 </summary>
        [Column("DXINDEX")]
        public int? DXINDEX { get; set; }
        /// <summary> 诊断代码 </summary>
        [Column("DXCODE")]
        public int? DXCODE { get; set; }
        /// <summary> ICD编码 </summary>
        [Column("ICD")]
        public string ICD { get; set; }
        /// <summary> 诊断名称 </summary>
        [Column("DXNAME")]
        public string DXNAME { get; set; }
        /// <summary> 诊断名称补充 </summary>
        [Column("DXNAMESUP")]
        public string DXNAMESUP { get; set; }
        /// <summary> 诊断确诊标记 </summary>
        [Column("DXDIAGNOSIS")]
        public int? DXDIAGNOSIS { get; set; }
        /// <summary> 诊断治疗效果 </summary>
        [Column("诊断类别")]
        public int? RESULTID { get; set; }
        /// <summary> 诊断类别 </summary>
        [Column("DXCATEGORY")]
        public int? DXCATEGORY { get; set; }
        /// <summary> 诊断医师ID </summary>
        [Column("DOCTORID")]
        public string DOCTORID { get; set; }
        /// <summary> 书写时间 </summary>
        [Column("WRITINGTIME")]
        public DateTime? WRITINGTIME { get; set; }
        /// <summary> 诊断时间 </summary>
        [Column("DXTIME")]
        public DateTime? DXTIME { get; set; }
        /// <summary> 报卡类型 </summary>
        [Column("REPORTCARD_TYPE")]
        public int? REPORTCARD_TYPE { get; set; }
        /// <summary> 医保类型 </summary>
        [Column("REPORTEDCARD_TYPE")]
        public int? REPORTEDCARD_TYPE { get; set; }
        /// <summary> 未报原因 </summary>
        [Column("UNREPORTED_REASON")]
        public string UNREPORTED_REASON { get; set; }
        /// <summary> 父ID </summary>
        [Column("FATHERID")]
        public string FATHERID { get; set; }
        /// <summary> 手术ID </summary>
        [Column("OPERATIONID")]
        public string OPERATIONID { get; set; }
        /// <summary> 主手术ID </summary>
        [Column("MAINOPERATIONID")]
        public string MAINOPERATIONID { get; set; }
        /// <summary> 诊断状态 </summary>
        [Column("DXSTATE")]
        public int? DXSTATE { get; set; }
        /// <summary> 诊断类型 </summary>
        [Column("DXTYPE")]
        public int? DXTYPE { get; set; }
        /// <summary> 入院情况 </summary>
        [Column("ADMISSION_IS")]
        public string ADMISSION_IS { get; set; }
        /// <summary> 证候ICD </summary>
        [Column("SYNDROMESICD")]
        public string SYNDROMESICD { get; set; }
        /// <summary> 证候名称 </summary>
        [Column("SYNDROMESNAME")]
        public string SYNDROMESNAME { get; set; }
        /// <summary> 主诊断 </summary>
        [Column("MAINDX")]
        public int? MAINDX { get; set; }
        /// <summary> 诊断部位 </summary>
        [Column("DXPOSITION")]
        public string DXPOSITION { get; set; }
        /// <summary> 解剖名称 </summary>
        [Column("ANATOMYNAME")]
        public string ANATOMYNAME { get; set; }
    }
}
