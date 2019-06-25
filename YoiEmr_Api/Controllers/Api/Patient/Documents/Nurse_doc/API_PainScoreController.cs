using System;
using System.Linq;
using System.Web.Http;
using YoiEmr_Api.Base;
using Yoisoft.Application.Base;
using Yoisoft.Application.Base.RecordSystem;
using Yoisoft.Application.Patient;
using Yoisoft.Application.Patient.Documents.Nurse_doc;
using Yoisoft.Util;

namespace YoiEmr_Api.Controllers.Api.Patient
{

    public class API_PainScoreController : BaseApi
    {
        [HttpGet]
        public IHttpActionResult RecordQuery(string key)
        {
            PainScoreService service = new PainScoreService();
            try
            {

                var query = service.GetEntity(key);
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
            PainScoreService service = new PainScoreService();
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
