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
    /// 表：YY_CODE_CAREER 实体类   系统码表--职业
    /// </summary>
    public class CODE_CAREERController : ODataController
    {


        #region  default
        [HttpGet]
        [EnableQuery]
        public IHttpActionResult Get(ODataQueryOptions<CODE_CAREEREntity> odataQueryOptions)
        {
            Expression<Func<CODE_CAREEREntity, bool>> myfilter = null;
            if (odataQueryOptions.Filter != null)
            {
                myfilter = odataQueryOptions.Filter.ToExpression<CODE_CAREEREntity>();
            }
            try
            {
                CODE_CAREERService service = new CODE_CAREERService();
                var expression = LinqExtensions.True<CODE_CAREEREntity>();
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
        public IHttpActionResult Patch([FromODataUri] string key, Delta<CODE_CAREEREntity> patch)
        {
           CODE_CAREERService service = new CODE_CAREERService();
            object id;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else if (patch.GetChangedPropertyNames().Contains("CAREERID") && patch.TryGetPropertyValue("CAREERID", out id) && (string)id != key)
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
           CODE_CAREERService service = new CODE_CAREERService();
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
        public void Put([FromODataUri] string key,CODE_CAREEREntity model)
        {
           CODE_CAREERService service = new CODE_CAREERService();
            service.UpdateEntity(model);
        }
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="model"></param>
        public void Post(CODE_CAREEREntity model)
        {
           CODE_CAREERService service = new CODE_CAREERService();
            service.SaveEntity(model);
        }
        #endregion
    }
}
