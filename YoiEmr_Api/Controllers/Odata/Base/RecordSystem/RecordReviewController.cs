using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Http;
using Yoisoft.Application.Base;
using Yoisoft.Application.Base.RecordSystem;
using Yoisoft.Util;

namespace YoiEmr_Api.Controllers.Odata.Base
{
    public class RecordReviewController : ODataController
    {

        #region 注册方法
        /// <summary>
        /// 根据主键查询用户表
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult RecordQuery(string key)
        {
            RecordReviewService service = new RecordReviewService();
            try
            {
                var query = service.GetEntity(Convert.ToInt32(key));
                return Ok(query);
            }
            catch (Exception)
            {
                return NotFound();
            }

        }
        /// <summary>
        /// 列表分页
        /// </summary>
        /// <param name="pagination"></param>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult RecordPagination(Pagination pagination)
        {
            RecordReviewService service = new RecordReviewService();
            var query = service.RecordPagination(pagination);
            return Ok(query.AsQueryable());
        }
        #endregion
        #region  default
        /// <summary>
        /// 查询列表所有
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [EnableQuery]
        public IHttpActionResult Get(ODataQueryOptions<RecordReviewEntity> odataQueryOptions)
        {
            Expression<Func<RecordReviewEntity, bool>> myfilter = null;
            if (odataQueryOptions.Filter != null)
            {
                myfilter = odataQueryOptions.Filter.ToExpression<RecordReviewEntity>();
            }
            try
            {
                RecordReviewService service = new RecordReviewService();
                var expression = LinqExtensions.True<RecordReviewEntity>();
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
        public IHttpActionResult Patch([FromODataUri] string key, Delta<RecordReviewEntity> patch)
        {
            RecordReviewService service = new RecordReviewService();
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
                var query = service.GetEntity(Convert.ToInt32(key));
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
            RecordReviewService service = new RecordReviewService();
            try
            {
                service.PhysicalDelRecord(Convert.ToInt32(key));
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
        public void Put([FromODataUri] string key, RecordReviewEntity model)
        {
            RecordReviewService service = new RecordReviewService();
            service.UpdateEntity(model);
        }
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="model"></param>
        public void Post(RecordReviewEntity model)
        {
            RecordReviewService service = new RecordReviewService();
            service.SaveEntity(model);;
        }
        #endregion
    }
}