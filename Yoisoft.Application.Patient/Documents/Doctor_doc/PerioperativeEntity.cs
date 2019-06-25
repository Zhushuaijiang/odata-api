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
    public class PerioperativeEntity : IBaseEntity
    {
        /// <summary> 主键ID </summary>
        [Column("ID")]
        [Key]
        public string ID { get; set; }
        /// <summary> 病人序号 </summary>
        [Column("PATIENTID")]
        public string PATIENTID { get; set; }
        /// <summary> 拟手术名称 </summary>
        [Column("PERIOPERATIVENAME")]
        public string PERIOPERATIVENAME { get; set; }
    }
}
