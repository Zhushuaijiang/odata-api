using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.DataBase.Repository;
using Yoisoft.Util;

namespace Yoisoft.Application.Patient
{
  
    public class CatheterEvaluationService : RepositoryFactory
    {
        #region 属性 构造函数
        private string fieldSql;
        public CatheterEvaluationService()
        {
            fieldSql = @"     
                            t.ID,
                            t.PATIENTID,
                            t.CENUMBER,
                            t.CENAME,
                            t.POSITION,
                            t.CATHETERTIME,
                            t.DEPTH,
                            t.DEPTH_AMOUNT,
                            t.FIXED,
                            t.SIGN,
                            t.UNOBSTRUCTED,
                            t.LOCAL_CONDITION,
                            t.LOCAL_CONDITION_OTHER,
                            t.DRAINAGE_NATURE,
                            t.DRAINAGE_AMOUNT,
                            t.STARTTIME,
                            t.ENDTIME,
                            t.RECORDTIME,
                            t.RECORD_NURSE_ID,
                            t.SUPERIOR_NURSE,
                            t.FATHERID,
                            t.CETYPE             
                        ";
        }
        #endregion
        #region 数据 查询

        public IEnumerable<CatheterEvaluationEntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_nurse_CatheterEvaluation t ");
                return this.BaseRepository().FindList<CatheterEvaluationEntity>(strSql.ToString(), pagination);
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

        public IEnumerable<CatheterEvaluationEntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_nurse_CatheterEvaluation  t");
                return this.BaseRepository().FindList<CatheterEvaluationEntity>(strSql.ToString());
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

        public IQueryable<CatheterEvaluationEntity> IQueryRecord(Expression<Func<CatheterEvaluationEntity, bool>> condition)
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
        public string GetKey()
        {
            try
            {
                var strSql = "select seq_catheterevaluation.nextval from dual";
                return this.BaseRepository().FindTable(strSql).Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                return Guid.NewGuid().ToString("N");
            }
        }

        public CatheterEvaluationEntity GetEntity(string keyValue)
        {
            try
            {
                int id = 0;
                int.TryParse(keyValue, out id);
                return this.BaseRepository().FindEntity<CatheterEvaluationEntity>(t => t.ID == id);
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
                CatheterEvaluationEntity entity = new CatheterEvaluationEntity()
                {
                    ID =Convert.ToInt32(keyValue)
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
        public void SaveEntity(string keyValue,CatheterEvaluationEntity entity)
        {
            try
            {
                int id = 0;
                if (keyValue != "")
                {
                    int.TryParse(keyValue, out id);
                    entity.ID = id;
                }
                else
                {
                    int.TryParse(GetKey(), out id);
                    entity.ID = id;
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

        public void UpdateEntity(CatheterEvaluationEntity entity)
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
