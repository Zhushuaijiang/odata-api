#region 说明

/* 以下代码由【ZCN.NET自动化项目生成器】自动生成！
 * 请勿随意修改，如果修改后导致程序无法正常运行，请重新再次生成！
 * 
 * 日期：2019-04-19 14:52:39
 * 说明：Ado.Net ORM 实体类
 */

#endregion

using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Http;
using Yoisoft.Application.Base;
using Yoisoft.Util;

namespace YoiEmr_Api.Controllers.Odata.Base
{
  
   
    /// <summary>
    /// 表：YY_CODE_POSTLEVELLEVEL 实体类   职位级别
    /// </summary>
    public  class CODE_POSTLEVELLEVELController : ODataController  
  
	{
        #region  default
        /// <summary>
        /// 查询列表所有
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [EnableQuery]
        public IHttpActionResult Get(ODataQueryOptions<CODE_POSTLEVELEntity> odataQueryOptions)
        {
            Expression<Func<CODE_POSTLEVELEntity, bool>> myfilter = null;
            if (odataQueryOptions.Filter != null)
            {
                myfilter = odataQueryOptions.Filter.ToExpression<CODE_POSTLEVELEntity>();
            }
            try
            {
                CODE_POSTLEVELService service = new CODE_POSTLEVELService();
                var expression = LinqExtensions.True<CODE_POSTLEVELEntity>();
                if (myfilter != null)
                {
                    expression = expression.And(myfilter);
                }
                var query = service.IQueryRecord(expression).ToList();
                return Ok(query.AsQueryable());
            }
            catch (Exception)
            {
                return NotFound();
            }

        }
        /// <summary>
        /// 更新数据 非幂等
        /// </summary>
        /// <param name="key"></param>
        /// <param name="patch"></param>
        /// <returns></returns>
        [AcceptVerbs("PATCH", "MERGE")]
        [HttpPatch]
        public IHttpActionResult Patch([FromODataUri] string key, Delta<CODE_POSTLEVELEntity> patch)
        {
            CODE_POSTLEVELService service = new CODE_POSTLEVELService();
            object id;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else if (patch.GetChangedPropertyNames().Contains("LEVELID") && patch.TryGetPropertyValue("LEVELID", out id) && (string)id != key)
            {
                return BadRequest("The key from the url must match the key of the entity in the body");
            }

            try
            {
                var query = service.GetEntity(key);
                patch.Patch(query);
                service.UpdateEntity(query);
                return Updated(query);
            }
            catch (Exception)
            {

                return NotFound();
            }

        }


        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public IHttpActionResult Delete([FromODataUri]string key)
        {
            CODE_POSTLEVELService service = new CODE_POSTLEVELService();
            try
            {
                service.PhysicalDelRecord(key);
                return Ok(true);
            }
            catch (Exception)
            {
                return Ok(false);
            }
        }
        /// <summary>
        /// 更新数据，幂等
        /// </summary>
        /// <param name="key"></param>
        /// <param name="model"></param>
        public void Put([FromODataUri] string key, CODE_POSTLEVELEntity model)
        {
            CODE_POSTLEVELService service = new CODE_POSTLEVELService();
            service.UpdateEntity(model);
        }
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="model"></param>
        public void Post(CODE_POSTLEVELEntity model)
        {
            CODE_POSTLEVELService service = new CODE_POSTLEVELService();
            service.SaveEntity(model);;
        }
        #endregion

    }

}
