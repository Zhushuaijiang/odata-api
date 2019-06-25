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
    /// 表：YY_CODE_NATIONALITY 实体类   国籍表
    /// </summary>
    public  class CODE_NATIONALITYController : ODataController    
	{
        #region  default
        /// <summary>
        /// 查询列表所有
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [EnableQuery]
        public IHttpActionResult Get(ODataQueryOptions<CODE_NATIONALITYEntity> odataQueryOptions)
        {
            Expression<Func<CODE_NATIONALITYEntity, bool>> myfilter = null;
            if (odataQueryOptions.Filter != null)
            {
                myfilter = odataQueryOptions.Filter.ToExpression<CODE_NATIONALITYEntity>();
            }
            try
            {
                CODE_NATIONALITYService service = new CODE_NATIONALITYService();
                var expression = LinqExtensions.True<CODE_NATIONALITYEntity>();
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
        public IHttpActionResult Patch([FromODataUri] string key, Delta<CODE_NATIONALITYEntity> patch)
        {
            CODE_NATIONALITYService service = new CODE_NATIONALITYService();
            object id;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else if (patch.GetChangedPropertyNames().Contains("NATIONALITYID") && patch.TryGetPropertyValue("NATIONALITYID", out id) && (string)id != key)
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
            CODE_NATIONALITYService service = new CODE_NATIONALITYService();
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
        public void Put([FromODataUri] string key, CODE_NATIONALITYEntity model)
        {
            CODE_NATIONALITYService service = new CODE_NATIONALITYService();
            service.UpdateEntity(model);
        }
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="model"></param>
        public void Post(CODE_NATIONALITYEntity model)
        {
            CODE_NATIONALITYService service = new CODE_NATIONALITYService();
            service.SaveEntity(model);;
        }
        #endregion
    }

}
