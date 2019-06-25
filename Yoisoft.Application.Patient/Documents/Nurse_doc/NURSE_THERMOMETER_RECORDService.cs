using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.DataBase.Repository;
using Yoisoft.Util;

namespace Yoisoft.Application.Patient.Documents.Nurse_doc
{
    public class NURSE_THERMOMETER_RECORDService : RepositoryFactory
    {
        #region 属性 构造函数
        private string fieldSql;
        public NURSE_THERMOMETER_RECORDService()
        {
            fieldSql = @"     
                   t.ID,
                   t.RECORDING_TIME,
                   t.MEASUREMENT_TIME,
                   t.NURSE_ID,
                   t.BODY_TEMPERATURE_TYPE,
                   t.TEMPERATURE,
                   t.PULSE,
                   t.BREATHING,
                   t.BLOOD_PRESSURE_1,
                   t.BLOOD_PRESSURE_2,
                   t.OXYGEN_SATURATION,
                   t.TYPE_MEASUREMENT,
                   t.SUPPLEMENT,
                   t.RECORD_CATEGORY,
                   t.ACTUAL_RECORDING_TIME,
                   t.PATIENTID,
                   t.BABYID,
                   t.IS_PULSE,
                   t.SUPPLEMENTARY_DESCRIPTION,
                   t.HZJC,
                   t.PLAINLEVEL,
                   t.AFTERPLAIN,
                   t.SUPPLEMENT_TYPE
                        ";
        }
        #endregion
        #region 数据 查询

        public IEnumerable<NURSE_THERMOMETER_RECORDEntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM YY_NURSE_THERMOMETER_RECORD t ");
                return this.BaseRepository().FindList<NURSE_THERMOMETER_RECORDEntity>(strSql.ToString(), pagination);
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

        public IEnumerable<NURSE_THERMOMETER_RECORDEntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM YY_NURSE_RESCUERECORD  t");
                return this.BaseRepository().FindList<NURSE_THERMOMETER_RECORDEntity>(strSql.ToString());
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
        public IQueryable<NURSE_THERMOMETER_RECORDEntity> IQueryRecord(Expression<Func<NURSE_THERMOMETER_RECORDEntity, bool>> condition)
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
                var strSql = "select SEQ_THERMOMETER_RECORD.nextval from dual";
                return this.BaseRepository().FindTable(strSql).Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                return Guid.NewGuid().ToString("N");
            }
        }
        public NURSE_THERMOMETER_RECORDEntity GetEntity(string keyValue)
        {
            try
            {
                return this.BaseRepository().FindEntity<NURSE_THERMOMETER_RECORDEntity>(t => t.ID == keyValue);
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
                NURSE_THERMOMETER_RECORDEntity entity = new NURSE_THERMOMETER_RECORDEntity()
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
        public void SaveEntity(string keyValue,NURSE_THERMOMETER_RECORDEntity entity)
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

        public void UpdateEntity(NURSE_THERMOMETER_RECORDEntity entity)
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
