using System;
using System.Linq;
using System.Web.Http;
using YoiEmr_Api.Base;
using Yoisoft.Application.Base;
using Yoisoft.Util;

namespace YoiEmr_Api.Controllers.Api.Base
{
    /// <summary>
    /// 表：YY_CODE_FEE 实体类   系统码表--病人性质
    /// </summary>
    public class API_CODE_FEEController : BaseApi

    {

        [HttpGet]
        public IHttpActionResult RecordQuery(string key)
        {
            CODE_FEEService service = new CODE_FEEService();
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
            CODE_FEEService service = new CODE_FEEService();
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
