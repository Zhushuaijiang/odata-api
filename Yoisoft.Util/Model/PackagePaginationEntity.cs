using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoisoft.Util
{
    public class PackageEntityPagination<T>
    {
        /// <summary>
        /// 返回提示
        /// </summary>
        public string msg { get; set; }
        /// <summary>
        /// 每页行数
        /// </summary>
        [Key]
        public int rows { get; set; }
        /// <summary>
        /// 当前页
        /// </summary>
        public int page { get; set; }
        /// <summary>
        /// 排序列
        /// </summary>
        public string sidx { get; set; }
        /// <summary>
        /// 排序类型
        /// </summary>
        public string sord { get; set; }
        /// <summary>
        /// 总记录数
        /// </summary>
        public int records { get; set; }
        /// <summary>
        /// 总页数
        /// </summary>
        public int total { get; set; }

       

        public IEnumerable<T> list { get; set; }

    }
}
