﻿using System;
using System.Linq;
using System.Web.Http;
using YoiEmr_Api.Base;
using Yoisoft.Application.Base;
using Yoisoft.Util;

namespace YoiEmr_Api.Controllers.Api.Base
{
    /// <summary>
    /// 表：YY_CODE_CASE_HISTORYSTYPE 实体类   病历类型
    /// </summary>
    public  class API_CODE_CASE_HISTORYSTYPEController : BaseApi
    {
        [HttpGet]
        public IHttpActionResult RecordQuery(string key)
        {
            CODE_CASE_HISTORYSTYPEService service = new CODE_CASE_HISTORYSTYPEService();
            try
            {
                var query = service.GetEntity(key.ToString());
                var packageEntity = query.PackageResult();
                return Json(packageEntity);
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
            CODE_CASE_HISTORYSTYPEService service = new CODE_CASE_HISTORYSTYPEService();
            try
            {
                var query = service.RecordPagination(pagination);
                var packageEntity = query.PackageEntityPaginations(pagination);
                return Json(packageEntity);
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
