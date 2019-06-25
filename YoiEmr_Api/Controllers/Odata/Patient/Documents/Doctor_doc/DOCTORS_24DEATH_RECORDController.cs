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
    public class DOCTORS_24DEATH_RECORDController : ODataController
    {
        /// <summary>
        /// 查询列表所有
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [EnableQuery]
        public IHttpActionResult Get(ODataQueryOptions<DOCTORS_24DEATH_RECORDEntity> odataQueryOptions)
        {
            Expression<Func<DOCTORS_24DEATH_RECORDEntity, bool>> myfilter = null;
            if (odataQueryOptions.Filter != null)
            {
                myfilter = odataQueryOptions.Filter.ToExpression<DOCTORS_24DEATH_RECORDEntity>();
            }
            try
            {
                DOCTORS_24DEATH_RECORDService service = new DOCTORS_24DEATH_RECORDService();
                var expression = LinqExtensions.True<DOCTORS_24DEATH_RECORDEntity>();
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
        public IHttpActionResult Patch([FromODataUri] string key, Delta<DOCTORS_24DEATH_RECORDEntity> patch)
        {
            DOCTORS_24DEATH_RECORDService service = new DOCTORS_24DEATH_RECORDService();
            object id;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else if (patch.GetChangedPropertyNames().Contains("PATIENTID") && patch.TryGetPropertyValue("PATIENTID", out id) && (string)id != key)
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
            DOCTORS_24DEATH_RECORDService service = new DOCTORS_24DEATH_RECORDService();
            try
            {
                service.PhysicalDelRecord(key.ToString());
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
        public void Put([FromODataUri] string key, DOCTORS_24DEATH_RECORDEntity model)
        {
            DOCTORS_24DEATH_RECORDService service = new DOCTORS_24DEATH_RECORDService();
            service.UpdateEntity(model);
        }
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="model"></param>
        public void Post(DOCTORS_24DEATH_RECORDEntity model)
        {
            DOCTORS_24DEATH_RECORDService service = new DOCTORS_24DEATH_RECORDService();
            service.SaveEntity(model.PATIENTID, model); ;
        }
    }

}