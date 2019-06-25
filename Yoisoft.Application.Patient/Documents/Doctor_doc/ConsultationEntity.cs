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
    public class ConsultationEntity:IBaseEntity
    {
        /// <summary> 主键ID </summary>
        [Column("ID")]
        [Key]
        public string ID { get; set; }
        /// <summary> 病案号 </summary>
        [Column("MRN")]
        public string MRN { get; set; }
        /// <summary> 病人序号 </summary>
        [Column("PATIENTID")]
        public string PATIENTID { get; set; }
        /// <summary> 病人姓名 </summary>
        [Column("PATIENTNAME")]
        public string PATIENTNAME { get; set; }
        /// <summary> 病人病区代码 </summary>
        [Column("WARDCODE")]
        public int? WARDCODE { get; set; }
        /// <summary> 申请科室 </summary>
        [Column("APPLYDEPT")]
        public int? APPLYDEPT { get; set; }
        /// <summary> 申请医师 </summary>
        [Column("APPLYDOCTORID")]
        public string APPLYDOCTORID { get; set; }
        /// <summary> 申请时间 </summary>
        [Column("APPLYTIME")]
        public DateTime? APPLYTIME { get; set; }
        /// <summary> 病历简述 </summary>
        [Column("CASEHISTORY_SKETCH")]
        public string CASEHISTORY_SKETCH { get; set; }
        /// <summary> 答复时间 </summary>
        [Column("REPLYTIME")]
        public DateTime? REPLYTIME { get; set; }
        /// <summary> 答复内容 </summary>
        [Column("REPLYCONTENT")]
        public string REPLYCONTENT { get; set; }
        /// <summary> 答复医师 </summary>
        [Column("REPLYDOCTORID")]
        public string REPLYDOCTORID { get; set; }
        /// <summary> 答复医师姓名 </summary>
        [Column("REPLYDOCTORNAME")]
        public string REPLYDOCTORNAME { get; set; }
        /// <summary> 答复科室代码 </summary>
        [Column("REPLYWARDCODE")]
        public int? REPLYWARDCODE { get; set; }
        /// <summary> 答复科室名称 </summary>
        [Column("REPLYWARDNAME")]
        public string REPLYWARDNAME { get; set; }
        /// <summary> 病程记录ID </summary>
        [Column("PROGRESS_NODEID")]
        public string PROGRESS_NODEID { get; set; }
        /// <summary> 外院 1：是，0否； </summary>
        [Column("OUTSIDE_HOSPITAL")]
        public int? OUTSIDE_HOSPITAL { get; set; }
        /// <summary> 外院名称 </summary>
        [Column("OUTSIDE_HOSPITALNAME")]
        public string OUTSIDE_HOSPITALNAME { get; set; }
        /// <summary> 签名时间 </summary>
        [Column("AUTOGRAPHTIME")]
        public DateTime? AUTOGRAPHTIME { get; set; }
        /// <summary> 签名医师姓名 </summary>
        [Column("AUTOGRAPHDOCTORNAME")]
        public string AUTOGRAPHDOCTORNAME { get; set; }
        /// <summary> 紧急情况 1:紧急 ，0：普通 </summary>
        [Column("URGENT")]
        public string URGENT { get; set; }
        /// <summary> 病人床号 </summary>
        [Column("BEDNO")]
        public string BEDNO { get; set; }
        /// <summary> 上级医师 </summary>
        [Column("SUPERIOR_DOCTORS")]
        public string SUPERIOR_DOCTORS { get; set; }
        /// <summary> 审签 </summary>
        [Column("CHECKSIGN")]
        public string CHECKSIGN { get; set; }
        /// <summary> 会诊类别 1：西医，0：中医 </summary>
        [Column("CONSULTATION_TYPE")]
        public int? CONSULTATION_TYPE { get; set; }
        /// <summary> 申请单状态 1：已回复，0：新开 </summary>
        [Column("AFSTATE")]
        public string AFSTATE { get; set; }
        /// <summary> 保存状态 1：保存，0：暂存 </summary>
        [Column("STATE")]
        public string STATE { get; set; }
    }
}
