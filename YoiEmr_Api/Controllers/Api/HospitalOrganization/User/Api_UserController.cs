using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using YoiEmr_Api.Base;
using Yoisoft.Application.HospitalOrganization.User;
using Yoisoft.Util;

namespace YoiEmr_Api.Controllers.Odata.Base.Api.HospitalOrganization.User
{
    public class Api_UserController : BaseApi
    {
        /// <summary>
        /// 根据主键查询用户表
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult RecordQuery(string key)
        {
            UserService service = new UserService();
            try
            {
                var query = service.GetEntity(key.ToString());
                var packageEntity = query.PackageResult<UserEntity>();
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
            UserService service = new UserService();
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

        [HttpPost]
        public IHttpActionResult CheckLogin(UserEntity model)
        {
            UserService service = new UserService();
            try
            {
                var query = service.CheckLogin(model.USERNO, model.PASSWORD == null ? "" : model.PASSWORD);
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
        [HttpGet]
        public IHttpActionResult ExistAccount(string accno, string key)
        {
            UserService service = new UserService();
            try
            {
                var query = service.ExistAccount(accno, key);
                return Ok(query);
            }
            catch (Exception)
            {
                return Ok(false);
            }


        }
        [HttpGet]
        public IEnumerable<Select2GroupObject> SeaUserByPym(bool bygh, string pym)
        {
            List<Select2GroupObject> lst = new List<Select2GroupObject>();
            if (string.IsNullOrEmpty(pym)) return lst;
            UserService service = new UserService();
            IEnumerable<UserEntity> users =  service.SeaUserByPym(pym);
            if (users == null) return lst;
            foreach (UserEntity user in users)
            {

                var group = lst.FirstOrDefault(p => p.id.Equals("0"));
                if (group == null)
                {
                    group = new Select2GroupObject
                    {
                        id = "0",
                        text = "请选择"
                    };
                    lst.Add(group);
                }
                if (group.children == null) group.children = new List<Select2ResultObject>();
                group.children.Add(new Select2ResultObject(
                    bygh ? user.USERNO : user.USERID,
                    user.USNAME,
                    group.id, group.text, user.USERNO + " " + user.USNAME, null));
            }
            return lst;
        }
    }
}
