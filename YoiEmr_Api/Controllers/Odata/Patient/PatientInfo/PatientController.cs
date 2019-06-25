using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Http;
using Yoisoft.Application.Patient;
using Yoisoft.Application.Patient.Patient;
using Yoisoft.Util;

namespace YoiEmr_Api.Controllers.Odata.Patient
{
    public class PatientController : ODataController
    {
        ///// <summary>
        ///// 查询列表所有
        ///// </summary>
        ///// <returns></returns>
        //[HttpGet]
        //[EnableQuery]
        //public IHttpActionResult Get()
        //{
        //    PatientService service = new PatientService();
        //    try
        //    {
        //        var query = service.RecordQuery();
        //        return Ok(query.AsQueryable());
        //    }
        //    catch (Exception)
        //    {
        //        return NotFound();
        //    }
        //}
        /// <summary>
        /// 根据主键查询用户表
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        [HttpGet]
        [EnableQuery]
        public IHttpActionResult Get(ODataQueryOptions<PatientEntity> odataQueryOptions)
        {
            Expression<Func<PatientEntity, bool>> myfilter = null;
            if (odataQueryOptions.Filter != null)
            {
                myfilter = odataQueryOptions.Filter.ToExpression<PatientEntity>();
            }
            try
            {
                PatientService service = new PatientService();
                var expression = LinqExtensions.True<PatientEntity>();
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
        /// 分页列表
        /// </summary>
        /// <param name="pagination"></param>
        /// <returns></returns>
        [HttpPost]
        [EnableQuery]
        public IHttpActionResult RecordPagination(Pagination pagination)
        {
            PatientService service = new PatientService();
            try
            {
                var query = service.RecordPagination(pagination);
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
        public IHttpActionResult Patch([FromODataUri] string key, Delta<PatientEntity> patch)
        {
            PatientService service = new PatientService();
            object id;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else if (patch.GetChangedPropertyNames().Contains("PATIENTID") && patch.TryGetPropertyValue("PATIENTID", out id) && id.ToString() != key)
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
            PatientService service = new PatientService();
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
        public void Put([FromODataUri] string key, PatientEntity model)
        {
            PatientService service = new PatientService();
            service.UpdateEntity(model);
        }
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="model"></param>
        public void Post(PatientEntity model)
        {
            PatientService service = new PatientService();
            service.SaveEntity(model.PATIENTID,model);;
        }
    }
}