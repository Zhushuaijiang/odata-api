using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.DataBase.Repository;
using Yoisoft.Util;

namespace Yoisoft.Application.HospitalOrganization.DepartmentAndWard
{
    public class DepartmentAndWardService : RepositoryFactory
    {
        #region 属性 构造函数
        private string fieldSql;
        public DepartmentAndWardService()
        {
            fieldSql = @" t.ID,
                          t.DEPTCODE,
                          t.DEPTNAME,
                          t.DEPT_PHONETIC,
                          t.WARDCODE,
                          t.WARDNAME,
                          t.WARD_PHONETIC,
                          t.IS_DEPT,
                          t.ORGANID
                        ";
        }
        #endregion
        #region 数据 查询
        /// <summary>
        /// 获取病区科室列表-分页
        /// </summary>
        /// <param name="pagination"></param>
        /// <returns></returns>
        public IEnumerable<DeptAndWardEntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_code_dept_ward t ");
                return this.BaseRepository().FindList<DeptAndWardEntity>(strSql.ToString(), pagination);
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
        /// 获取病区科室列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DeptAndWardEntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_code_dept_ward  t");
                return this.BaseRepository().FindList<DeptAndWardEntity>(strSql.ToString());
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
        public IQueryable<DeptAndWardEntity> IQueryRecord(Expression<Func<DeptAndWardEntity, bool>> condition)
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

        public IEnumerable<DeptAndWardEntity> GetRecordByDeptCode(string deptcode)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_code_dept_ward t ");
                strSql.Append(" WHERE t.DEPTCODE = @deptcode");
                return this.BaseRepository().FindList<DeptAndWardEntity>(strSql.ToString(), new { deptcode = deptcode });
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
        public IEnumerable<DeptAndWardEntity> GetRecordByWardCode(string wardcode)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_code_dept_ward t ");
                strSql.Append(" WHERE t.wardcode = @wardcode");
                return this.BaseRepository().FindList<DeptAndWardEntity>(strSql.ToString(), new { wardcode = wardcode });
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
                var strSql = "select seq_code_dept_ward.nextval from dual";
                return this.BaseRepository().FindTable(strSql).Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                return Guid.NewGuid().ToString("N");
            }
        }
        public DeptAndWardEntity GetEntity(string keyValue)
        {
            try
            {
                return this.BaseRepository().FindEntity<DeptAndWardEntity>(t => t.ID == keyValue);
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

        #region 操作数据
        public void PhysicalDelRecord(string keyValue)
        {
            try
            {
                DeptAndWardEntity entity = new DeptAndWardEntity()
                {
                    ID = keyValue,
                };
                this.BaseRepository().Delete(entity);
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
        public void SaveEntity(string keyValue, DeptAndWardEntity  deptAndWard)
        {
            try
            {
                if (string.IsNullOrEmpty(keyValue))
                {
                    deptAndWard.ID = GetKey();
                    deptAndWard.ID = "99";
                    this.BaseRepository().Insert(deptAndWard);
                }
                else
                {
                  
                    this.BaseRepository().Update(deptAndWard);
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

        public void UpdateEntity(DeptAndWardEntity  deptAndWard)
        {
            try
            {
                this.BaseRepository().Update(deptAndWard);
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
    }
}
