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
    public class progress_noteEntity:IBaseEntity
    {
        /// <summary> 主键ID </summary>

        [Column("ID")]
        [Key]
        public string ID { get; set; }
        [Column("PATIENTID")]
        public string PATIENTID { get; set; }
        /// <summary> 书写医生 </summary>
        [Column("WRITING_DOCTORS")]
        public string WRITING_DOCTORS { get; set; }
        /// <summary> 上级医生 </summary>
        [Column("SUPERIOR_DOCTORS")]
        public string SUPERIOR_DOCTORS { get; set; }
        /// <summary> 病人姓名 </summary>
        [Column("PTNAME")]
        public string PTNAME { get; set; }
        /// <summary> 记录时间 </summary>
        [Column("RECORDTIME")]
        public DateTime? RECORDTIME { get; set; }

        /// <summary> 类型ID </summary>
        [Column("TYPEID")]
        public string TYPEID { get; set; }
        /// <summary> 书写时间 </summary>
        [Column("WRITINGTIME")]
        public DateTime? WRITINGTIME { get; set; }
        /// <summary> 删除状态 </summary>
        [Column("DEL")]
        public int? DEL { get; set; }
        /// <summary> 有创诊疗操作记录名称 </summary>
        [Column("TYPENAME")]
        public string TYPENAME { get; set; }
        /// <summary> 换行线 </summary>
        [Column("LINE")]
        public int? LINE { get; set; }
        /// <summary> 书写状态 </summary>
        [Column("WRITINGSTATE")]
        public int? WRITINGSTATE { get; set; }
        /// <summary> 显示时间 </summary>
        [Column("SHOWTIME")]
        public DateTime? SHOWTIME { get; set; }
        /// <summary> 病人序号 </summary>

        /// <summary> 查房医生 </summary>
        [Column("DIRECTOR_DOCTORS")]
        public string DIRECTOR_DOCTORS { get; set; }
        [Column("ISXML")]
        public int? ISXML { get; set; }
        /// <summary> 围手术期文书ID </summary>
        [Column("SURGERYID")]
        public string SURGERYID { get; set; }
        /// <summary> 科室代码 </summary>
        [Column("DEPTCODE")]
        public int? DEPTCODE { get; set; }
        /// <summary> 病区代码 </summary>
        [Column("WARDCODE")]
        public int? WARDCODE { get; set; }
        /// <summary> 床位号 </summary>
        [Column("BEDNO")]
        public string BEDNO { get; set; }
        /// <summary> 预留家属签名位置 </summary>
        [Column("RESERVED_SIGNATURE_LOCATION")]
        public string RESERVED_SIGNATURE_LOCATION { get; set; }
        /// <summary> 抢救开始日期时间 </summary>
        [Column("RESCUE_START_DATE")]
        public string RESCUE_START_DATE { get; set; }
        /// <summary> 抢救结束日期时间 </summary>
        [Column("SALVAGE_END_DATE")]
        public string SALVAGE_END_DATE { get; set; }
        /// <summary> 病情变化情况 </summary>
        [Column("CONDITION_CHANGE")]
        public string CONDITION_CHANGE { get; set; }
        /// <summary> 抢救措施 </summary>
        [Column("RESCUE_MEASURES")]
        public string RESCUE_MEASURES { get; set; }
        /// <summary> 抢救效果 </summary>
      
        [Column("RESCUE_EFFECT")]
        public string RESCUE_EFFECT { get; set; }
        /// <summary> 手术及操作名称 </summary>

        [Column("OPERATION_OPERATION")]
        public string OPERATION_OPERATION { get; set; }
        /// <summary> 检验/检查 </summary>
        [Column("INSPECTION_INSPECTION")]
        public string INSPECTION_INSPECTION { get; set; }
        /// <summary> 注意事项 </summary>
      
        [Column("MATTERS_NEEDING_ATTENTION")]
        public string MATTERS_NEEDING_ATTENTION { get; set; }
        /// <summary> 参加抢救人员名单 </summary>
       
        [Column("LIST_OF_RESCUERS")]
        public string LIST_OF_RESCUERS { get; set; }
        /// <summary> 记录内容 </summary>
        [Column("RECORD_CONTENT")]
        public string RECORD_CONTENT { get; set; }

    }
}
