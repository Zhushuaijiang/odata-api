using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Yoisoft.Application.Patient.Patient;
using Yoisoft.Util;

namespace YoiEmr_Api.Controllers.Odata.Base
{
    [EnableQuery]
    public class PatientViewController : ODataController
    {

        [HttpGet]
        public IHttpActionResult Get()
        {
            PatientViewService service = new PatientViewService();
            //var query = userService.GetAllList();
            var query = service.RecordQuery();
            return Ok(query.AsQueryable());
        }
        /// <summary>
        /// 获取病人信息列表
        /// </summary>
        /// <returns>IQueyable<PatientViewEntity></returns>
        [HttpGet]
        public IHttpActionResult RecordQuery(string key)
        {
            PatientViewService service = new PatientViewService();
            var query = service.RecordQuery(key);
            return Ok(query.AsQueryable());
        }
        /// <summary>
        /// 获取病人信息列表-分页
        /// </summary>
        /// <param name="pagination">分页参数</param>
        /// <returns>IQueyable<PatientViewEntity></returns>
        [HttpPost]
        public IHttpActionResult RecordPagination(Pagination pagination)
        {
            PatientViewService service = new PatientViewService();
            var query = service.RecordPagination(pagination);
            return Ok(query);
        }
        

       
    }
}
