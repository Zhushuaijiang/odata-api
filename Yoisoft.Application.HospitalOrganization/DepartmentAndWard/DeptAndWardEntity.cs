using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Util;
namespace Yoisoft.Application.HospitalOrganization.DepartmentAndWard
{
    public class DeptAndWardEntity : IBaseEntity
    {
        [Key]
        public string ID { get; set; }
        /// <summary> 科室代码 </summary>
        public int? DEPTCODE { get; set; }
        /// <summary> 科室名称 </summary>     
        public string DEPTNAME { get; set; }
        /// <summary> 科室拼音缩写(大写) </summary>
        public string DEPT_PHONETIC { get; set; }
        /// <summary> 病区代码 </summary>
        public int? WARDCODE { get; set; }
        /// <summary> 病区名称 </summary>
        public string WARDNAME { get; set; }
        /// <summary> 病区拼音缩写(大写) </summary>
        public string WARD_PHONETIC { get; set; }
        /// <summary> 标识是否是科室(0是病区,1是科室) </summary>
        public int IS_DEPT { get; set; }
        /// <summary> 机构号 </summary>
        public string ORGANID { get; set; }
    }
}
