using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using YoiEmr_Api.Base;
using Yoisoft.Application.HospitalOrganization.DepartmentAndWard;
using Yoisoft.Util;

namespace YoiEmr_Api.Controllers.Odata.Base.Api.HospitalOrganization.DepartmentAndWard
{
    public class Api_DepartmentAndWardController : BaseApi
    {
        /// <summary>
        /// 根据主键查询用户表
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult RecordQuery(string key)
        {
            DepartmentAndWardService service = new DepartmentAndWardService();
            try
            {
                var query = service.GetEntity(key.ToString());
                return Ok(query.PackageResult());
            }
            catch (Exception)
            {
                PackageResultEntity<object> packageResultEntity = new PackageResultEntity<object>()
                {
                    list = null,
                    msg = "failed"
                };
                return Json(packageResultEntity);
            }

        }
        /// <summary>
        /// 分页列表
        /// </summary>
        /// <param name="pagination"></param>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult RecordPagination(Pagination pagination)
        {
            DepartmentAndWardService service = new DepartmentAndWardService();
            try
            {
                var query = service.RecordPagination(pagination);
                return Ok(query.PackageEntityPaginations(pagination));
            }
            catch (Exception)
            {

                PackageResultEntity<object> packageResultEntity = new PackageResultEntity<object>()
                {
                    list = null,
                    msg = "failed"
                };
                return Json(packageResultEntity);
            }


        }
    }
}
