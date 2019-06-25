using System.Collections.Generic;

namespace Yoisoft.Util
{
    /// <summary>
    /// 版 本 Yiosoft V1.0.0 佑医敏捷开发框架
    /// Copyright (c) 2018-2050 杭州佑医科技有限公司
    /// 创建人：佑医-框架开发组
    /// 日 期：2019.02.20
    /// 描 述：数据库查询拼接数据模型
    /// </summary>
    public class DbWhere
    {
        /// <summary>
        /// sql语句
        /// </summary>
        public string sql { get; set; }
        /// <summary>
        /// 查询参数
        /// </summary>
        public List<FieldValueParam> dbParameters { get; set; }
    }
}
