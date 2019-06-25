using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Yoisoft.DataBase.Repository;
using Yoisoft.Util;

namespace Yoisoft.Application.HospitalOrganization.User
{
    public class UserService : RepositoryFactory
    {
        #region 属性 构造函数
        private string fieldSql;
        public UserService()
        {
            fieldSql = @" 
                        t.USERID,
                        t.USNAME,
                        t.NAME_PHONETIC,
                        t.PASSWORD,
                        t.SIGN_PASSWORD,
                        t.WARDCODE,
                        t.DEPTCODE,
                        t.POSTID,
                        t.TITLEID,
                        t.POST_LEVEL,
                        t.MEDICAL_GROUP,
                        t.USERNO,
                        t.STATE,
                        t.BASICROLE,
                        t.REGISTDATE,
                        t.SUPERIOR_DOCTORS,
                        t.SUPERIOR_NURSE,
                        t.ORGANID,
                        t.HIS_USID,
                        t.USER_GROUP_ID,
                        t.USER_GROUP_NAME,
                        t.DELETEMARK
                        ";
        }
        #endregion

        /// <summary>
        /// 获取实体,通过用户账号
        /// </summary>
        /// <param name="account">用户账号</param>
        /// <returns></returns>
        public UserEntity GetEntityByAccount(string account)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_sys_user t ");
                strSql.Append(" WHERE t.userno = @account AND t.DeleteMark = 0  ");
                return this.BaseRepository().FindEntity<UserEntity>(strSql.ToString(), new { account = account });
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }
        }


        public IQueryable<UserEntity> RecordQueryable(Expression<Func<UserEntity, bool>> condition)
        {
            return this.BaseRepository().IQueryable<UserEntity>(condition);
        }
        /// <summary>
        /// 用户列表,全部
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UserEntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql.Replace("t.PASSWORD,", "").Replace("t.SIGN_PASSWORD,", ""));
                strSql.Append(" FROM YY_SYS_USER t WHERE t.DELETEMARK = 0  ORDER BY t.ORGANID,t.DEPTCODE,t.WARDCODE ");
                return this.BaseRepository().FindList<UserEntity>(strSql.ToString());
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }
        }
        public IQueryable<UserEntity> IQueryRecord(Expression<Func<UserEntity, bool>> condition)
        {
            try
            {
                return this.BaseRepository().IQueryable(condition);
            }
            catch (Exception ex)
            {

                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }

        }

        public IEnumerable<UserEntity> RecordQuery(string keyvalue)
        {

            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql.Replace("t.PASSWORD,", "").Replace("t.SIGN_PASSWORD,", ""));
                strSql.Append(" FROM YY_SYS_USER t WHERE t.DELETEMARK = 0 AND t.USERID=@USERID  ORDER BY t.ORGANID,t.DEPTCODE,t.WARDCODE ");
                return this.BaseRepository().FindList<UserEntity>(strSql.ToString(), new { USERID = keyvalue });
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }
        }

        /// <summary>
        /// 用户列表,全部 可分页
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UserEntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql.Replace("t.PASSWORD,", "").Replace("t.SIGN_PASSWORD,", ""));
                strSql.Append(" FROM YY_SYS_USER t WHERE t.DELETEMARK = 0  ORDER BY t.ORGANID,t.DEPTCODE,t.WARDCODE ");
                return this.BaseRepository().FindList<UserEntity>(strSql.ToString(), pagination);
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }
        }

        /// <summary>
        /// 用户实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public UserEntity GetEntity(string keyValue)
        {
            try
            {
                return this.BaseRepository().FindEntity<UserEntity>(t => t.USERID == keyValue && t.DELETEMARK == 0);
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }
        }
        /// <summary>
        /// 获取主键
        /// </summary>
        /// <returns></returns>
        public string GetKey()
        {
            try
            {
                var strSql = "select seq_yy_sys_user.nextval from dual";
                return this.BaseRepository().FindTable(strSql).Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                return Guid.NewGuid().ToString("N");
            }
        }

        public IEnumerable<UserEntity> SeaUserByPym(string pym)
        {
            string strSql = string.Format(@"select * from (select * from yy_sys_user where name_phonetic like :name_phonetic) where rownum<15");
            return this.BaseRepository().FindList<UserEntity>(strSql, new { name_phonetic = "" + pym.ToUpper() + "%" });
        }
        #region 验证数据
        /// <summary>
        /// 账户不能重复
        /// </summary>
        /// <param name="account">账户值</param>
        /// <param name="keyValue">主键</param>
        /// <returns></returns>
        public bool ExistAccount(string account, string keyValue)
        {
            try
            {
                var expression = LinqExtensions.True<UserEntity>();
                expression = expression.And(t => t.USERNO == account);
                if (!string.IsNullOrEmpty(keyValue))
                {
                    expression = expression.And(t => t.USERID != keyValue);
                }
                return this.BaseRepository().IQueryable(expression).ToList().Count() == 0 ? true : false;
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }
        }
        #endregion

        #region
        public void VirtualDelRecord(string keyValue)
        {
            try
            {
                UserEntity entity = new UserEntity()
                {
                    USERID = keyValue,
                    DELETEMARK = 1,
                    REGISTDATE = DateTime.Now
                };
                this.BaseRepository().Update(entity);
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }
        }
        /// <summary>
        /// 保存用户表单（新增、修改）
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="userEntity">用户实体</param>
        /// <returns></returns>
        public void SaveEntity(string keyValue, UserEntity userEntity)
        {
            try
            {
                if (string.IsNullOrEmpty(keyValue))
                {
                    userEntity.USERID = GetKey();
                    userEntity.REGISTDATE = DateTime.Now;
                    string enCodePasswd = Extensions.EncodeBase64("GB2312", userEntity.USERID);
                    if (enCodePasswd.Length > 20) enCodePasswd = enCodePasswd.Substring(0, 20);
                    userEntity.PASSWORD = enCodePasswd;
                    this.BaseRepository().Insert(userEntity);
                }
                else
                {
                    userEntity.REGISTDATE = DateTime.Now;

                    this.BaseRepository().Update(userEntity);
                }
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }
        }
        /// <summary>
        /// 修改用户登录密码
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="password">新密码（MD5 小写）</param>
        public void RevisePassword(string keyValue, string password)
        {
            try
            {
                UserEntity userEntity = new UserEntity();
                string enCodePasswd = Extensions.EncodeBase64("GB2312", password);
                if (enCodePasswd.Length > 20) enCodePasswd = enCodePasswd.Substring(0, 20);
                userEntity.PASSWORD = enCodePasswd;
                this.BaseRepository().Update(userEntity);
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="userEntity">实体对象</param>
        public void UpdateEntity(UserEntity userEntity)
        {
            try
            {
                this.BaseRepository().Update(userEntity);
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }
        }

        #endregion
        #region 扩展方法
        /// <summary>
        /// 验证登录
        /// </summary>
        /// <param name="account">账号</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public UserEntity CheckLogin(string account, string password)
        {
            try
            {

                UserEntity userEntity = GetEntityByAccount(account);
                if (userEntity == null)
                {
                    userEntity = new UserEntity()
                    {
                        USERID = userEntity.USERID
                    };
                    return userEntity;
                }
                string enCodePasswd = Extensions.EncodeBase64("GB2312", password);

                if (enCodePasswd.Length > 20) enCodePasswd = enCodePasswd.Substring(0, 20);
                if (enCodePasswd == userEntity.PASSWORD)
                {
                    return userEntity;
                }
                else
                {
                    userEntity = new UserEntity()
                    {
                        USERID = userEntity.USERID
                    };
                    return userEntity;
                }

            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowBusinessException(ex);
                }
            }
        }

        #endregion
    }
}
