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
using Yoisoft.Util;

namespace YoiEmr_Api.Controllers.Odata.Patient
{

    public class NURSE_RESCUERECORDController : ODataController
    {

        #region  default
        /// <summary>
        /// ��ѯ�б�����
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [EnableQuery]
        public IHttpActionResult Get(ODataQueryOptions<NURSE_RESCUERECORDEntity> odataQueryOptions)
        {
            Expression<Func<NURSE_RESCUERECORDEntity, bool>> myfilter = null;
            if (odataQueryOptions.Filter != null)
            {
                myfilter = odataQueryOptions.Filter.ToExpression<NURSE_RESCUERECORDEntity>();
            }
            try
            {
                NURSE_RESCUERECORDService service = new NURSE_RESCUERECORDService();
                var expression = LinqExtensions.True<NURSE_RESCUERECORDEntity>();
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
        /// �������� ���ݵ�
        /// </summary>
        /// <param name="key"></param>
        /// <param name="patch"></param>
        /// <returns></returns>
        [AcceptVerbs("PATCH", "MERGE")]
        [HttpPatch]
        public IHttpActionResult Patch([FromODataUri] string key, Delta<NURSE_RESCUERECORDEntity> patch)
        {
            NURSE_RESCUERECORDService service = new NURSE_RESCUERECORDService();
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
        /// ɾ������
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public IHttpActionResult Delete([FromODataUri]string key)
        {
            NURSE_RESCUERECORDService service = new NURSE_RESCUERECORDService();
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
        /// �������ݣ��ݵ�
        /// </summary>
        /// <param name="key"></param>
        /// <param name="model"></param>
        public void Put([FromODataUri] string key, NURSE_RESCUERECORDEntity model)
        {
            NURSE_RESCUERECORDService service = new NURSE_RESCUERECORDService();
            service.UpdateEntity(model);
        }
        /// <summary>
        /// ��������
        /// </summary>
        /// <param name="model"></param>
        public void Post(NURSE_RESCUERECORDEntity model)
        {
            NURSE_RESCUERECORDService service = new NURSE_RESCUERECORDService();
            service.SaveEntity(model.PATIENTID, model);
        }
        #endregion

    }
}
