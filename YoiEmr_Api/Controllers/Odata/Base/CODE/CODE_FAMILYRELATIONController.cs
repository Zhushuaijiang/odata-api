using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Yoisoft.Application.Base;
using Yoisoft.Util;

namespace YoiEmr_Api.Controllers.Odata.Base
{
    /// <summary>
    /// 表：YY_CODE_FAMILYRELATION 实体类   家庭关系表
    /// </summary>
    public class CODE_FAMILYRELATIONController : ODataController
    {

        #region  default
        /// <summary>
        /// 查询列表所有
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [EnableQuery]
        public IHttpActionResult Get(ODataQueryOptions<CODE_FAMILYRELATIONEntity> odataQueryOptions)
        {
            Expression<Func<CODE_FAMILYRELATIONEntity, bool>> myfilter = null;
            if (odataQueryOptions.Filter != null)
            {
                myfilter = odataQueryOptions.Filter.ToExpression<CODE_FAMILYRELATIONEntity>();
            }
            try
            {
                CODE_FAMILYRELATIONService service = new CODE_FAMILYRELATIONService();
                var expression = LinqExtensions.True<CODE_FAMILYRELATIONEntity>();
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
        public IHttpActionResult Patch([FromODataUri] string key, Delta<CODE_FAMILYRELATIONEntity> patch)
        {
            CODE_FAMILYRELATIONService service = new CODE_FAMILYRELATIONService();
            object id;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else if (patch.GetChangedPropertyNames().Contains("RELATIONID") && patch.TryGetPropertyValue("RELATIONID", out id) && (string)id != key)
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
            CODE_FAMILYRELATIONService service = new CODE_FAMILYRELATIONService();
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
        public void Put([FromODataUri] string key, CODE_FAMILYRELATIONEntity model)
        {
            CODE_FAMILYRELATIONService service = new CODE_FAMILYRELATIONService();
            service.UpdateEntity(model);
        }
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="model"></param>
        public void Post(CODE_FAMILYRELATIONEntity model)
        {
            CODE_FAMILYRELATIONService service = new CODE_FAMILYRELATIONService();
            service.SaveEntity(model);;
        }
        #endregion
    }
}
