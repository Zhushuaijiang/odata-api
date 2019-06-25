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

    public class DoctorsOperationService : RepositoryFactory
    {
        #region 属性 构造函数
        private string fieldSql;
        public DoctorsOperationService()
        {
            fieldSql = @" t.ID,
                          t.PATIENTID,
                          t.STARTTIME,
                          t.ENDTIME,
                          t.PREOPERATIVE_DIAGNOSIS_CODE,
                          t.PREOPERATIVE_DIAGNOSIS_NAME,
                          t.OPERATION_CODE,
                          t.OPERATION_NAME,
                          t.CHIEF_DOCTORID,
                          t.CHIEF_DOCTORNAME,
                          t.FIRST_ASSISTANTID,
                          t.FIRST_ASSISTANTNAME,
                          t.SECOND_ASSISTANTID,
                          t.SECOND_ASSISTANTNAME,
                          t.ANESTHESIA_MANNER,
                          t.ANESTHESIA_PERSONID,
                          t.ANESTHESIA_PERSONNAME,
                          t.OPERATION_PROCESS,
                          t.WRITING_DOCTORS_ID,
                          t.WRITING_DOCTORS_NAME,
                          t.RECORDTIME,
                          t.WRITINGTIME,
                          t.SURGERYID,
                          t.ANESTHESIA_OTHER,
                          t.STATE,
                          t.OPERATION_GRADE,
                          t.OPERATION_SUPPLEMENT,
                          t.OUTSIDE_SIGN,
                          t.AGENT_RELATIONSHIP,
                          t.AGENT_RELATIONSHIP_OTHER,
                          t.TRANSBLOOD_NURSEID,
                          t.TRANSBLOOD_NURSENAME,
                          t.SURGICAL_SITE,
                          t.SURGICAL_SITE_OTHER,
                          t.TRANSBLOOD_REACTION,
                          t.TRANSBLOOD_REACTION_OTHER,
                          t.SURGERYTYPE,
                          t.ANESTHESIA_SATISFACTION,
                          t.TOTALINPUT,
                          t.TOTALOUTPUT,
                          t.BLOODLOSS,
                          t.BLOODTRANSFUSION,
                          t.ANESTHESIA_STARTTIME,
                          t.EXITTIME,
                          t.ROOMNUMBER,
                          t.INTERVENTION,
                          t.SKINDESCRIPTION,
                          t.PREMEDICATION,
                          t.INTRAOPERATIVE,
                          t.DRAINAGESIGN,
                          t.DRAINAGE_MATERIAL_NAME,
                          t.DRAINAGE_MATERIAL_NUMBER,
                          t.PLACEMENT,
                          t.SURGICAL_POSITION,
                          t.SURGICALSIGN,
                          t.SOURCESURGERY
                        ";
        }
        #endregion
        #region 数据 查询

        public IEnumerable<DoctorsOperationEntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_DoctorsOperation t ");
                return this.BaseRepository().FindList<DoctorsOperationEntity>(strSql.ToString(), pagination);
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

        public IEnumerable<DoctorsOperationEntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_DoctorsOperation  t");
                return this.BaseRepository().FindList<DoctorsOperationEntity>(strSql.ToString());
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


        public IQueryable<DoctorsOperationEntity> IQueryRecord(Expression<Func<DoctorsOperationEntity, bool>> condition)
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

        public DoctorsOperationEntity GetEntity(string keyValue)
        {
            try
            {
                return this.BaseRepository().FindEntity<DoctorsOperationEntity>(t => t.ID == keyValue);
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
                DoctorsOperationEntity entity = new DoctorsOperationEntity()
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
        public void SaveEntity(string keyValue, DoctorsOperationEntity entity)
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

        public void UpdateEntity(DoctorsOperationEntity entity)
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




