using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNet.OData.Query.Validators;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using Yoisoft.Application.Patient;
using Yoisoft.Util;
namespace YoiEmr_Api.Controllers.Odata.Patient
{
    [EnableQuery]
    public class AdmiSsionRecordController : ODataController
    {
        /// <summary>
        /// 查询列表所有
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [EnableQuery(PageSize = 1000, MaxExpansionDepth = 2)]
        public IHttpActionResult Get(ODataQueryOptions<AdmiSsionRecordEntity> odataQueryOptions)
        {
            Expression<Func<AdmiSsionRecordEntity, bool>> myfilter = null;
            if (odataQueryOptions.Filter != null)
            {
                myfilter = odataQueryOptions.Filter.ToExpression<AdmiSsionRecordEntity>();
            }
            try
            {
                AdmiSsionRecordService service = new AdmiSsionRecordService();
                var expression = LinqExtensions.True<AdmiSsionRecordEntity>();
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
        [HttpGet]
        [EnableQuery(PageSize = 100, MaxExpansionDepth = 2)]
        public IHttpActionResult RecordQuery(string key)
        {

            try
            {
                AdmiSsionRecordService service = new AdmiSsionRecordService();
                var query = service.RecordQuery(key);
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
        public IHttpActionResult Patch([FromODataUri] string key, Delta<AdmiSsionRecordEntity> patch)
        {
            AdmiSsionRecordService service = new AdmiSsionRecordService();
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
            AdmiSsionRecordService service = new AdmiSsionRecordService();
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
        public IHttpActionResult Put([FromODataUri] string key, AdmiSsionRecordEntity model)
        {
            try
            {
                AdmiSsionRecordService service = new AdmiSsionRecordService();
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
        public IHttpActionResult Post(AdmiSsionRecordEntity model)
        {
            try
            {
                AdmiSsionRecordService service = new AdmiSsionRecordService();
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