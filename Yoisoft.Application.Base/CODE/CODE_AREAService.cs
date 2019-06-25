using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.DataBase.Repository;
using Yoisoft.Util;

namespace Yoisoft.Application.Base
{

    public class CODE_AREAService : RepositoryFactory
    {
        #region 属性 构造函数
        private string fieldSql;
        public CODE_AREAService()
        {
            fieldSql = @" t.F_AREAID,                          t.F_PARENTID,                          t.F_AREACODE,                          t.F_AREANAME,                          t.F_QUICKQUERY,                          t.F_SIMPLESPELLING,                          t.F_LAYER,                          t.F_SORTCODE,                          t.F_DELETEMARK,                          t.F_ENABLEDMARK,                          t.F_DESCRIPTION,                          t.F_CREATEDATE,                          t.F_CREATEUSERID,                          t.F_CREATEUSERNAME,                          t.F_MODIFYDATE,                          t.F_MODIFYUSERID,                          t.F_MODIFYUSERNAME
                        ";
        }
        #endregion
        #region 数据 查询

        public IEnumerable<CODE_AREAEntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM YY_CODE_AREA t ");
                return this.BaseRepository().FindList<CODE_AREAEntity>(strSql.ToString(), pagination);
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

        public IEnumerable<CODE_AREAEntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM YY_CODE_BASIC  t");
                return this.BaseRepository().FindList<CODE_AREAEntity>(strSql.ToString());
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

        public string GetKey()
        {
            try
            {
                var strSql = "select seq_admissionassessment.nextval from dual";
                return this.BaseRepository().FindTable(strSql).Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                return Guid.NewGuid().ToString("N");
            }
        }
        public IQueryable<CODE_AREAEntity> IQueryRecord(Expression<Func<CODE_AREAEntity, bool>> condition)
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

        public CODE_AREAEntity GetEntity(string keyValue)
        {
            try
            {
               
                return this.BaseRepository().FindEntity<CODE_AREAEntity>(t => t.F_AREAID == keyValue);
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
                CODE_AREAEntity entity = new CODE_AREAEntity()
                {
                    F_AREAID = keyValue
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
        /// 修改
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="userEntity">用户实体</param>
        /// <returns></returns>
        public void SaveEntity(string keyValue, CODE_AREAEntity entity)
        {
            try
            {
                if (keyValue != "")
                {
                   
                    entity.F_AREAID = keyValue;
                }
                else
                {
                   
                    entity.F_AREAID = GetKey();
                }

                this.BaseRepository().Insert(entity);

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

        public void UpdateEntity(CODE_AREAEntity entity)
        {
            try
            {
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
        #endregion
    }
}
