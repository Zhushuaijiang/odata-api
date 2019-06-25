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
    public class CNRService : RepositoryFactory
    {
        #region 属性 构造函数
        private string fieldSql;
        public CNRService()
        {
            fieldSql = @"     
                         t.ID,
                         t.PARENTID,
                         t.RECORDING_TIME,
                         t.RECORD_NURSE_ID,
                         t.TEMPERATURE,
                         t.PULSE,
                         t.BREATHING,
                         t.DIASTOLIC_PRESSURE,
                         t.SYSTOLIC_PRESSURE,
                         t.CONSCIOUSNESS,
                         t.LEFT_PUPIL,
                         t.RIGHT_PUPIL,
                         t.INTAKE_NAME,
                         t.INTAKE_AMOUNT,
                         t.INTAKE_COMPANY,
                         t.OUTPUT_NAME,
                         t.OUTPUT_AMOUNT,
                         t.OUTPUT_COMPANY,
                         t.OUTPUT_COLOR,
                         t.OUTPUT_CHARACTER,
                         t.BASIC_NURSING,
                         t.SPECIAL_CARE,
                         t.ACTUAL_RECORDING_TIME,
                         t.SAVE_TYPE,
                         t.OXYGEN_SATURATION,
                         t.ISREDLINE,
                         t.TOTAL_INTAKE,
                         t.TOTAL_OUTPUT,
                         t.RECORD_TYPE,
                         t.SIGNATURE_SUPERIOR_NURSE,
                         t.PATIENTID,
                         t.TOTAL_INPUT_TIME,
                         t.TOTAL_SIGNATURE_ID,
                         t.TOTAL_SIGNATURE_NAME,
                         t.NURSING_MEASURES,
                         t.INTAKE_STR,
                         t.CATHETER,
                         t.NURSING_ASSESSMENT,
                         t.TYPE_TEMPERATURE,
                         t.TYPE_PULSE,
                         t.NURSING_LEVEL,
                         t.SAFETY_MEASURES,
                         t.DECUBITUS_POSITION,
                         t.SKIN_CONDITION,
                         t.PIPELINE_NURSING_PROJECT,
                         t.PIPELINE_NURSING,
                         t.DELTIME,
                         t.DEL,
                         t.WRITINGTIME,
                         t.OXYGEN_INHALATION,
                         t.SPO2,
                         t.FIO2,
                         t.PUPIL_LEFT,
                         t.PUPIL_RIGHT,
                         t.LIGHT_REFLECTION_LEFT,
                         t.LIGHT_REFLECTION_RIGHT,
                         t.HEALTH_EDUCATION,
                         t.TOTAL_INPUT_TYPE           
                        ";
        }
        #endregion
        #region 数据 查询

        public IEnumerable<CNREntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_nurse_cnr t ");
                return this.BaseRepository().FindList<CNREntity>(strSql.ToString(), pagination);
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

        public IEnumerable<CNREntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_nurse_cnr  t");
                return this.BaseRepository().FindList<CNREntity>(strSql.ToString());
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
        public IQueryable<CNREntity> IQueryRecord(Expression<Func<CNREntity, bool>> condition)
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
                var strSql = "select seq_cnr.nextval from dual";
                return this.BaseRepository().FindTable(strSql).Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                return Guid.NewGuid().ToString("N");
            }
        }


        public CNREntity GetEntity(string keyValue)
        {
            try
            {
                return this.BaseRepository().FindEntity<CNREntity>(t => t.ID.ToString() == keyValue);
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
                CNREntity entity = new CNREntity()
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
        public void SaveEntity(string keyValue,CNREntity entity)
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

        public void UpdateEntity(CNREntity entity)
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
