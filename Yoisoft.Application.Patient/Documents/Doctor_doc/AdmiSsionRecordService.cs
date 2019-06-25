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

    public class AdmiSsionRecordService : RepositoryFactory
    {
        #region 属性 构造函数
        private string fieldSql;
        public AdmiSsionRecordService()
        {
            fieldSql = @" t.PATIENTID,
                          t.MRN,
                          t.MEDICAL_HISTORY_COMPLAINT,
                          t.USER_GROUP_RELATIONSHIP,
                          t.CHIEF_COMPLAINT,
                          t.PRESENT_ILLNESS,
                          t.PAST_HISTORY,
                          t.SYSTEMATIC_REVIEW,
                          t.PERSONAL_HISTORY,
                          t.OBSTERICAL_HISTORY,
                          t.FAMILY_HISTORY,
                          t.LABORATORY_INSPECT,
                          t.SPECIAL_INSPECT,
                          t.PATHOLOGY_INSPECT,
                          t.MEDICAL_HISTORY,
                          t.WRITING_DOCTORS,
                          t.RECORDTIME,
                          t.WRITINGTIME,
                          t.WRITING_STATE,
                          t.SPECIALTYID,
                          t.GOVID,
                          t.SPECIALTY_INSPECT,
                          t.OTHER,
                          t.SUPERIOR_DOCTORS,
                          t.RELATION,
                          t.FAMILY,
                          t.RELIABLE,
                          t.NUMBERADMISSIONS,
                          t.DEL,
                          t.MENSTRUATION_HISTORY,
                          t.PLANNED_DELIVERY_MODE,
                          t.CONCEIVE_MODE,
                          t.PREGNANCY_Y,
                          t.HUSBANDNAME,
                          t.LAST_MENSTRUATION,
                          t.EXPECTED_CHILDBIRTHDATE,
                          t.PREGNANCY_C,
                          t.DELTIME,
                          t.PHYSICAL_EXAMINATION,
                          t.PARENT_NAME
                        ";
        }
        #endregion
        #region 数据 查询

        public IEnumerable<AdmiSsionRecordEntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_doctors_admission_record t ");
                return this.BaseRepository().FindList<AdmiSsionRecordEntity>(strSql.ToString(), pagination);
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
        public IQueryable<AdmiSsionRecordEntity> IQueryRecord(Expression<Func<AdmiSsionRecordEntity, bool>> condition)
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
        public IEnumerable<AdmiSsionRecordEntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_doctors_admission_record  t");
                return this.BaseRepository().FindList<AdmiSsionRecordEntity>(strSql.ToString());
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

        public IEnumerable<AdmiSsionRecordEntity> RecordQuery(string key)
        {
            List<AdmiSsionRecordEntity> lis = new List<AdmiSsionRecordEntity>();
            AdmiSsionRecordEntity entity = this.BaseRepository().FindEntity<AdmiSsionRecordEntity>(key);
            lis.Add(entity);
            return lis;
        }
        public string GetKey()
        {
            try
            {
                var strSql = "select seq_admission_record.nextval from dual";
                return this.BaseRepository().FindTable(strSql).Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                return Guid.NewGuid().ToString("N");
            }
        }

        public AdmiSsionRecordEntity GetEntity(string keyValue)
        {
            try
            {

                return this.BaseRepository().FindEntity<AdmiSsionRecordEntity>(t => t.PATIENTID == keyValue);
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
        public int PhysicalDelRecord(string keyValue)
        {
            try
            {
                AdmiSsionRecordEntity entity = new AdmiSsionRecordEntity()
                {
                    PATIENTID = keyValue
                };
                return this.BaseRepository().Delete(entity);
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
        public int SaveEntity(string keyValue, AdmiSsionRecordEntity entity)
        {
            try
            {
                if (keyValue != "")
                {
                    entity.PATIENTID = keyValue;
                }
                else
                {
                    entity.PATIENTID = GetKey();
                }
                return this.BaseRepository().Insert(entity);

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

        public int UpdateEntity(AdmiSsionRecordEntity entity)
        {
            try
            {
                return this.BaseRepository().Update(entity);
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







