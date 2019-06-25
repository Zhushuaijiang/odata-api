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

    public class ConsultationService : RepositoryFactory
    {
        #region 属性 构造函数
        private string fieldSql;
        public ConsultationService()
        {
            fieldSql = @" t.ID,
                          t.MRN,
                          t.PATIENTID,
                          t.PATIENTNAME,
                          t.WARDCODE,
                          t.APPLYDEPT,
                          t.APPLYDOCTORID,
                          t.APPLYTIME,
                          t.CASEHISTORY_SKETCH,
                          t.REPLYTIME,
                          t.REPLYCONTENT,
                          t.REPLYDOCTORID,
                          t.REPLYDOCTORNAME,
                          t.REPLYWARDCODE,
                          t.REPLYWARDNAME,
                          t.PROGRESS_NODEID,
                          t.OUTSIDE_HOSPITAL,
                          t.OUTSIDE_HOSPITALNAME,
                          t.AUTOGRAPHTIME,
                          t.AUTOGRAPHDOCTORNAME,
                          t.URGENT,
                          t.BEDNO,
                          t.SUPERIOR_DOCTORS,
                          t.CHECKSIGN,
                          t.CONSULTATION_TYPE,
                          t.AFSTATE,
                          t.STATE
                        ";
        }
        #endregion
        #region 数据 查询

        public IEnumerable<ConsultationEntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_doctors_admission_record t ");
                return this.BaseRepository().FindList<ConsultationEntity>(strSql.ToString(), pagination);
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

        public IEnumerable<ConsultationEntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_doctors_admission_record  t");
                return this.BaseRepository().FindList<ConsultationEntity>(strSql.ToString());
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

        public IQueryable<ConsultationEntity> IQueryRecord(Expression<Func<ConsultationEntity, bool>> condition)
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
                var strSql = "select seq_consultation_sheet_id.nextval from dual";
                return this.BaseRepository().FindTable(strSql).Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                return Guid.NewGuid().ToString("N");
            }
        }

        public ConsultationEntity GetEntity(string keyValue)
        {
            try
            {
                return this.BaseRepository().FindEntity<ConsultationEntity>(t => t.ID == keyValue);
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
                ConsultationEntity entity = new ConsultationEntity()
                {
                    ID = keyValue
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
        public void SaveEntity(string keyValue, ConsultationEntity entity)
        {
            try
            {
                if (keyValue != "")
                {
                    entity.ID = keyValue;
                }
                else
                {
                    entity.ID = GetKey();
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

        public void UpdateEntity(ConsultationEntity entity)
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
