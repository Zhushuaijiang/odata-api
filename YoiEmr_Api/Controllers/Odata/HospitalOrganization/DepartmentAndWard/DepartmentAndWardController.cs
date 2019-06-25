using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Http;
using Yoisoft.Application.HospitalOrganization.DepartmentAndWard;
using Yoisoft.Application.HospitalOrganization.User;
using Yoisoft.Util;

namespace YoiEmr_Api.Controllers.Odata.HospitalOrganization
{
    public class DepartmentAndWardController : ODataController
    {
        /// <summary>
        /// 查询列表所有
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [EnableQuery]
        public IHttpActionResult Get(ODataQueryOptions<DeptAndWardEntity> odataQueryOptions)
        {
            Expression<Func<DeptAndWardEntity, bool>> myfilter = null;
            if (odataQueryOptions.Filter != null)
            {
                myfilter = odataQueryOptions.Filter.ToExpression<DeptAndWardEntity>();
            }
            try
            {
                DepartmentAndWardService service = new DepartmentAndWardService();
                var expression = LinqExtensions.True<DeptAndWardEntity>();
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
        public IHttpActionResult Patch([FromODataUri] string key, Delta<DeptAndWardEntity> patch)
        {
            DepartmentAndWardService service = new DepartmentAndWardService();
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
        public IHttpActionResult Delete([FromODataUri]int key)
        {
            DepartmentAndWardService service = new DepartmentAndWardService();
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
        public void Put([FromODataUri] int key, DeptAndWardEntity model)
        {
            DepartmentAndWardService service = new DepartmentAndWardService();
            service.UpdateEntity(model);
        }
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="model"></param>
        public void Post(DeptAndWardEntity model)
        {
            DepartmentAndWardService service = new DepartmentAndWardService();
            service.SaveEntity(model.ID,model);;
        }
    }
}
