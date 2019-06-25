using Microsoft.AspNet.OData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using YoiEmr_Api.Controllers.Odata.Base;
using Yoisoft.Util;
using Yoisoft.Application.Base;
using System.Linq.Expressions;
using Microsoft.AspNet.OData.Query;

namespace YoiEmr_Api.Controllers.Odata.Base
{
    public class Record_typeController : ODataController
    {

        /// <summary>
        /// 查询列表所有
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [EnableQuery]
        public IHttpActionResult Get(ODataQueryOptions<Record_typeEntity> odataQueryOptions)
        {
            Expression<Func<Record_typeEntity, bool>> myfilter = null;
            if (odataQueryOptions.Filter != null)
            {
                myfilter = odataQueryOptions.Filter.ToExpression<Record_typeEntity>();
            }
            try
            {
                Record_typeService service = new Record_typeService();
                var expression = LinqExtensions.True<Record_typeEntity>();
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
        /// 列表不分页
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult RecordQuery(int key1, int key2)
        {
            try
            {
                Record_typeService service = new Record_typeService();
                var query = service.RecordQuery(key1, key2);
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
            try
            {
                Record_typeService service = new Record_typeService();
                var query = service.RecordPagination(pagination);
                return Ok(query.AsQueryable());
            }
            catch (Exception)
            {
                return NotFound();
            }

        }

        [HttpPost]
        public IHttpActionResult UpdateEntity(Record_typeEntity model)
        {
            if (model.ITEMID != 0 && model.XMID != 0)
            {
                Record_typeService service = new Record_typeService();
                service.UpdateEntity(model);
                return Ok();
            }
            else
            {
                return NotFound();
            }

        }
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="model"></param>
        public void Post(Record_typeEntity model)
        {
            Record_typeService service = new Record_typeService();
            service.SaveEntity(model);

        }
    }
}