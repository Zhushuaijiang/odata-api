using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Util;

namespace Yoisoft.Application.Base
{
    /// <summary>
    /// 表：YY_CODE_AREA 实体类   行政区域表
    /// </summary>
    public  class CODE_AREAEntity : IBaseEntity

    {

        #region 属性	

        /// <summary>
        /// F_AREAID  区域主键
        /// </summary>
        [Key]
        public string F_AREAID { get; set; }

        /// <summary>
        /// F_PARENTID  父级主键
        /// </summary>
        public string F_PARENTID { get; set; }

        /// <summary>
        /// F_AREACODE  区域编码
        /// </summary>
        public string F_AREACODE { get; set; }

        /// <summary>
        /// F_AREANAME  区域名称
        /// </summary>
        public string F_AREANAME { get; set; }

        /// <summary>
        /// F_QUICKQUERY  快速查询
        /// </summary>
        public string F_QUICKQUERY { get; set; }

        /// <summary>
        /// F_SIMPLESPELLING  简拼
        /// </summary>
        public string F_SIMPLESPELLING { get; set; }

        /// <summary>
        /// F_LAYER  层次
        /// </summary>
        public decimal? F_LAYER { get; set; }

        /// <summary>
        /// F_SORTCODE  排序码
        /// </summary>
        public decimal? F_SORTCODE { get; set; }

        /// <summary>
        /// F_DELETEMARK  删除标记
        /// </summary>
        public decimal? F_DELETEMARK { get; set; }

        /// <summary>
        /// F_ENABLEDMARK  有效标志
        /// </summary>
        public decimal? F_ENABLEDMARK { get; set; }

        /// <summary>
        /// F_DESCRIPTION  备注
        /// </summary>
        public string F_DESCRIPTION { get; set; }

        /// <summary>
        /// F_CREATEDATE  创建日期
        /// </summary>
        public DateTime? F_CREATEDATE { get; set; }

        /// <summary>
        /// F_CREATEUSERID  创建用户主键
        /// </summary>
        public string F_CREATEUSERID { get; set; }

        /// <summary>
        /// F_CREATEUSERNAME  创建用户
        /// </summary>
        public string F_CREATEUSERNAME { get; set; }

        /// <summary>
        /// F_MODIFYDATE  修改日期
        /// </summary>
        public DateTime? F_MODIFYDATE { get; set; }

        /// <summary>
        /// F_MODIFYUSERID  修改用户主键
        /// </summary>
        public string F_MODIFYUSERID { get; set; }

        /// <summary>
        /// F_MODIFYUSERNAME  修改用户
        /// </summary>
        public string F_MODIFYUSERNAME { get; set; }

        #endregion


    }
}
