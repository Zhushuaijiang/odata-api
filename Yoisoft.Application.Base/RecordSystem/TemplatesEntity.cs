using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Util;

namespace Yoisoft.Application.Base
{
    public class TemplatesEntity:IBaseEntity
    {
        /// <summary> 模板ID </summary>
        [Key] 
        public string MBID { get; set; }
        /// <summary> 类型ID </summary>  
        public string ITEMID { get; set; }
        /// <summary> 大分类 默认:默认大类 </summary>        
        public string FLMC1 { get; set; }
        /// <summary> 分类2 </summary>         
        public string FLMC2 { get; set; }
        /// <summary> 模板名称 </summary>         
        public string MBMC { get; set; }
        /// <summary> 内容 </summary>
         
        public string NR { get; set; }
        /// <summary>syfw 个人0-科室1-全院2 </summary>
         
        public int? SYFW { get; set; }
        /// <summary> 用户ID </summary>
         
        public string CJRID { get; set; }
        /// <summary> 科室ID </summary>
         
        public int? KID { get; set; }
        /// <summary> 模板状态 默认空或者1启用  0删除</summary>
         
        public int? DEL { get; set; }



    }
}
