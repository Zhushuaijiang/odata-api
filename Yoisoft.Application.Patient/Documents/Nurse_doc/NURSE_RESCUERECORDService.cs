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
   
    public class NURSE_RESCUERECORDService : RepositoryFactory
    {
        #region 属性 构造函数
        private string fieldSql;
        public NURSE_RESCUERECORDService()
        {
            fieldSql = @"     
                     t.PATIENTID，
                     t.RESCUE_STARTTIME，
                     t.CHIEF_COMPLAINT，
                     t.PRESENT_ILLNESS，
                     t.ALLERGY_HISTORY，
                     t.PAST_HISTORY，
                     t.TEMPERATURE，
                     t.PULSE，
                     t.BREATHING，
                     t.BLOOD_PRESSURE_1，
                     t.BLOOD_PRESSURE_2，
                     t.CONSCIOUSNESS，
                     t.SKIN，
                     t.PUPIL，
                     t.LIGHT_REFLECTION，
                     t.NECK，
                     t.CHEST，
                     t.HEART，
                     t.LUNG，
                     t.ABDOMEN，
                     t.SPINE_LIMBS，
                     t.OTHER，
                     t.ACCESSORY_EXAMINATION，
                     t.DRAWUP_DX，
                     t.CAUSE_INJURY，
                     t.RESCUE_MEASURES，
                     t.RESCUE_PROCESS，
                     t.FIRST_AID_EFFECT，
                     t.MAJOR_EVENTS，
                     t.WHEREABOUTS，
                     t.RESCUE_NURSE，
                     t.RESCUE_DOCTORS，
                     t.WRITINGTIME，
                     t.RESCUE_MEDICINE，
                     t.CARDIAC_DEFIBRILLATION
                        ";
        }
        #endregion
        #region 数据 查询

        public IEnumerable<NURSE_RESCUERECORDEntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM YY_NURSE_RESCUERECORD t ");
                return this.BaseRepository().FindList<NURSE_RESCUERECORDEntity>(strSql.ToString(), pagination);
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

        public IEnumerable<NURSE_RESCUERECORDEntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM YY_NURSE_RESCUERECORD  t");
                return this.BaseRepository().FindList<NURSE_RESCUERECORDEntity>(strSql.ToString());
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
        public IQueryable<NURSE_RESCUERECORDEntity> IQueryRecord(Expression<Func<NURSE_RESCUERECORDEntity, bool>> condition)
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
                var strSql = "select seq_nurse_rescuerecordc.nextval from dual";
                return this.BaseRepository().FindTable(strSql).Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                return Guid.NewGuid().ToString("N");
            }
        }

        public NURSE_RESCUERECORDEntity GetEntity(string keyValue)
        {
            try
            {
                return this.BaseRepository().FindEntity<NURSE_RESCUERECORDEntity>(t => t.PATIENTID == keyValue);
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
                NURSE_RESCUERECORDEntity entity = new NURSE_RESCUERECORDEntity()
                {
                    PATIENTID = keyValue
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
        public void SaveEntity(string keyValue,NURSE_RESCUERECORDEntity entity)
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

        public void UpdateEntity(NURSE_RESCUERECORDEntity entity)
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
