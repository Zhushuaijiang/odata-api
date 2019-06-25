using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.DataBase.Repository;
using Yoisoft.Util;

namespace Yoisoft.Application.Patient.Patient
{
    public class PatientViewService : RepositoryFactory
    {
        /// <summary>
        /// 获取病人信息（视图）2019.4.10
        /// </summary>
        /// <param name="pagination">分页参数</param>
        /// <returns></returns>
        public IEnumerable<PatientViewEntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append("*  ");
                strSql.Append(" FROM view_zybr  ");
                return this.BaseRepository().FindList<PatientViewEntity>(strSql.ToString(), pagination);
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
       


        public IEnumerable<PatientViewEntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(" *  ");
                strSql.Append(" FROM view_zybr  ");
                return this.BaseRepository().FindList<PatientViewEntity>(strSql.ToString());
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
        public IQueryable<PatientViewEntity> IQueryRecord(Expression<Func<PatientViewEntity, bool>> condition)
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
        public IEnumerable<PatientViewEntity> RecordQuery(string keyvalue)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(" *  ");
                strSql.Append(" FROM view_zybr  ");
                strSql.Append(" where patientid=@patientid");
                return this.BaseRepository().FindList<PatientViewEntity>(strSql.ToString(), new { patientid = keyvalue });
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
        /// 根据住院序号获取病人信息
        /// </summary>
        /// <param name="keyvalue"></param>
        /// <returns></returns>

    }
}
