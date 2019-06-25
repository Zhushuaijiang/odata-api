using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Http;
using Yoisoft.Application.Patient;
using Yoisoft.Util;

namespace YoiEmr_Api.Controllers.Odata.Patient
{
    [EnableQuery]
    public class DeathRecordController : ODataController
    {
        /// <summary>
        /// 查询列表所有
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [EnableQuery]
        public IHttpActionResult Get(ODataQueryOptions<DeathRecordEntity> odataQueryOptions)
        {
            Expression<Func<DeathRecordEntity, bool>> myfilter = null;
            if (odataQueryOptions.Filter != null)
            {
                myfilter = odataQueryOptions.Filter.ToExpression<DeathRecordEntity>();
            }
            try
            {
                DeathRecordService service = new DeathRecordService();
                var expression = LinqExtensions.True<DeathRecordEntity>();
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
        public IHttpActionResult Patch([FromODataUri] string key, Delta<DeathRecordEntity> patch)
        {
            DeathRecordService service = new DeathRecordService();
            object id;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else if (patch.GetChangedPropertyNames().Contains("DeathRecordID") && patch.TryGetPropertyValue("DeathRecordID", out id) && (string)id != key)
            {
                return BadRequest("The key from the url must match the key of the entity in the body");
            }

            try
            {
                var query = service.GetEntity(key.ToString());
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
            DeathRecordService service = new DeathRecordService();
            try
            {
                if (service.PhysicalDelRecord(key.ToString()) > 0)
                    return Ok(true);
                else
                    return Ok(false);
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
        public IHttpActionResult Put([FromODataUri] string key, DeathRecordEntity model)
        {
            try
            {
                DeathRecordService service = new DeathRecordService();
                if (service.UpdateEntity(model) > 0)
                    return Ok(true);
                else
                    return Ok(false);
            }
            catch (Exception)
            {
                return Ok(false);
            }
        }
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="model"></param>
        public IHttpActionResult Post(DeathRecordEntity model)
        {
            try
            {
                DeathRecordService service = new DeathRecordService();
                if (service.SaveEntity(model.PATIENTID, model) > 0)
                    return Ok(true);
                else
                    return Ok(false);
            }
            catch (Exception)
            {
                return Ok(false);
            }
        }
    }

}