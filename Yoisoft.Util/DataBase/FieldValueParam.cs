namespace Yoisoft.Util
{
    /// <summary>
    /// 版 本 Yiosoft V1.0.0 佑医敏捷开发框架
    /// Copyright (c) 2018-2050 杭州佑医科技有限公司
    /// 创建人：佑医-框架开发组
    /// 日 期：2019.02.20
    /// 描 述：数据库参数
    /// </summary>
    public class FieldValueParam
    {
        /// <summary>
        /// 字段名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 数据值
        /// </summary>
        public object value { get; set; }
        /// <summary>
        /// 数据类型
        /// </summary>
        public int type { get; set; }
    }
}
