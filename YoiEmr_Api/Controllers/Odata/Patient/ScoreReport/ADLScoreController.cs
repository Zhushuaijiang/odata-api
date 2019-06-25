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
using Yoisoft.Application.Patient;
using Yoisoft.Application.Patient.Documents.Nurse_doc;
using Yoisoft.Application.Patient.PatientDiagnostic;
using Yoisoft.Application.Patient.ScoreReport;
using Yoisoft.Util;

namespace YoiEmr_Api.Controllers.Odata.Patient
{

    public class ADLScoreController : ODataController
    {

        #region  default
        /// <summary>
        /// 查询列表所有
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [EnableQuery]
        public IHttpActionResult Get(ODataQueryOptions<ADLScoreEntity> odataQueryOptions)
        {
            Expression<Func<ADLScoreEntity, bool>> myfilter = null;
            if (odataQueryOptions.Filter != null)
            {
                myfilter = odataQueryOptions.Filter.ToExpression<ADLScoreEntity>();
            }
            try
            {
                ADLScoreService service = new ADLScoreService();
                var expression = LinqExtensions.True<ADLScoreEntity>();
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
        public IHttpActionResult Patch([FromODataUri] string key, Delta<ADLScoreEntity> patch)
        {
            ADLScoreService service = new ADLScoreService();
            object id;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else if (patch.GetChangedPropertyNames().Contains("ID") && patch.TryGetPropertyValue("ID", out id) && (string)id != key)
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
            ADLScoreService service = new ADLScoreService();
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
        public void Put([FromODataUri] string key, ADLScoreEntity model)
        {
            ADLScoreService service = new ADLScoreService();
            service.UpdateEntity(model);
        }
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="model"></param>
        public void Post(ADLScoreEntity model)
        {
            ADLScoreService service = new ADLScoreService();
            service.SaveEntity(model.ID, model);
        }
        #endregion

    }
}
