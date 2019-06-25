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

    public class DXCODE_DXService : RepositoryFactory
    {
        #region 属性 构造函数
        private string fieldSql;
        public DXCODE_DXService()
        {
            fieldSql = @" t.DXCODE,
                          t.DXNAME,
                          t.ICD10,
                          t.ICD9,
                          t.INPUTCODE1,
                          t.INPUTCODE2,
                          t.INPUTCODE3,
                          t.MRNUMBER,
                          t.DEPTCODE,
                          t.REPORTCARD_TYPE,
                          t.INFECT_SORT,
                          t.SYSLEVEL,
                          t.LEVELSTATISTICS9,
                          t.LEVELSTATISTICS10,
                          t.INVALIDSTATE
                        ";
        }
        #endregion
        #region 数据 查询

        public IEnumerable<DXCODE_DXEntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM YY_DXCODE_DX t ");
                return this.BaseRepository().FindList<DXCODE_DXEntity>(strSql.ToString(), pagination);
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

        public IEnumerable<DXCODE_DXEntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM YY_DXCODE_DX  t");
                return this.BaseRepository().FindList<DXCODE_DXEntity>(strSql.ToString());
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

        public IQueryable<DXCODE_DXEntity> IQueryRecord(Expression<Func<DXCODE_DXEntity, bool>> condition)
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


        public DXCODE_DXEntity GetEntity(string keyValue)
        {
            try
            {
                return this.BaseRepository().FindEntity<DXCODE_DXEntity>(t => t.DXCODE == keyValue);
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
                DXCODE_DXEntity entity = new DXCODE_DXEntity()
                {
                    DXCODE = keyValue
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
        public void SaveEntity(DXCODE_DXEntity entity)
        {
            try
            {
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

        public void UpdateEntity(DXCODE_DXEntity entity)
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




