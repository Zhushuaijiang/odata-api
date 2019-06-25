using System;
using System.Linq;
using System.Web.Http;
using YoiEmr_Api.Base;
using Yoisoft.Application.Base;
using Yoisoft.Application.Base.RecordSystem;
using Yoisoft.Application.Patient;
using Yoisoft.Application.Patient.Patient;
using Yoisoft.Application.Patient.PatientDiagnostic;
using Yoisoft.Util;

namespace YoiEmr_Api.Controllers.Api.Patient
{

    public class Api_PatientViewController : BaseApi
    {
        [HttpGet]
        public IHttpActionResult RecordQuery(string key)
        {
            PatientViewService service = new PatientViewService();
            try
            {

                var query = service.RecordQuery(key).FirstOrDefault();
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
            PatientViewService service = new PatientViewService();
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
