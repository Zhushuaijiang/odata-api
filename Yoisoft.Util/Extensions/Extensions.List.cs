using System.Collections;
using System.Collections.Generic;


namespace Yoisoft.Util
{
    /// <summary>
    /// 版 本 Yiosoft V1.0.0 佑医敏捷开发框架
    /// Copyright (c) 2018-2050 杭州佑医科技有限公司
    /// 创建人：佑医-框架开发组
    /// 日 期：2019.02.06
    /// 描 述：List扩展
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        /// 获取list的分页数据
        /// </summary>
        /// <param name="obj">list对象</param>
        /// <param name="pagination">分页参数</param>
        /// <returns></returns>
        public static List<T> FindPage<T>(this List<T> obj, Pagination pagination) where T : class
        {
            pagination.records = obj.Count;
            int index = (pagination.page - 1) * pagination.rows;
            if (index >= obj.Count)
            {
                return new List<T>();
            }
            int end = index + pagination.rows;
            int count = end > obj.Count ? obj.Count - index : pagination.rows;
            List<T> list = obj.GetRange(index, count);
            return list;
        }
        /// <summary>
        ///  实体包装成有分页的数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="pagination"></param>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static PackageEntityPagination<T> PackageEntityPaginations<T>(this IEnumerable<T> obj, Pagination pagination, string msg="ok") where T : IBaseEntity
        {

            PackageEntityPagination<T> pack = new PackageEntityPagination<T>()
            {
                msg = msg,
                list = obj,
                page = pagination.page,
                records = pagination.records,
                rows = pagination.rows,
                sidx = pagination.sidx,
                sord = pagination.sord,
                total = pagination.total,
             
            };
            return pack;
        }
        public static PackageResultEntity<T> PackageResult<T>(this T obj, string msg = "ok") where T : IBaseEntity 
        {

            PackageResultEntity<T> pack = new PackageResultEntity<T>()
            {
                list = new List<T>() { obj },
                msg = msg
            };
            return pack;
        }
    }
}
