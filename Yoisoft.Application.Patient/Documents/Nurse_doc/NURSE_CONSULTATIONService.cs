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
    public class NURSE_CONSULTATIONService : RepositoryFactory
    {
        #region 属性 构造函数
        private string fieldSql;
        public NURSE_CONSULTATIONService()
        {
            fieldSql = @"     
                   t.ID,
                   t.MRN,
                   t.PATIENTID,
                   t.CONSCIOUSNESS,
                   t.TEMPERATURE,
                   t.PULSE,
                   t.BREATH,
                   t.SYSTOLICPRESSURE,
                   t.DIASTOLICPRESSURE,
                   t.COORDINATIONDEGREE,
                   t.TRACHEOTOMY,
                   t.HORIZONTAL,
                   t.ROUTINEBLOODTEST,
                   t.CRUOR,
                   t.LOCALRADIOTHERAPY,
                   t.LOCALINFECTION,
                   t.TRAUMATICFRACTURE,
                   t.TPOSITION,
                   t.OPERATION,
                   t.OPOSITION,
                   t.VENAPRESSURESIGN,
                   t.HISTORYVENIPUNCTURE,
                   t.HPOSITION,
                   t.HTIME,
                   t.INFLUENTIALTREATMENT,
                   t.INFLUENCE,
                   t.SIGNATURESIMPLEMENTATION,
                   t.BEDNO,
                   t.PATIENTNAME,
                   t.WARDCODE,
                   t.POSITION,
                   t.IMPLANTATION,
                   t.LOCALANESTHESIA,
                   t.HEMORRHAGEAMOUNT,
                   t.BLOODRETURN,
                   t.PUNCTURESITE,
                   t.EDUCATION,
                   t.CATHETERIZATION,
                   t.ARMCIRCUMFERENCE,
                   t.FEMORALVEINCATHETERIZATION,
                   t.THIGHCIRCUMFERENCE,
                   t.OTHER,
                   t.APPLYDATE,
                   t.APPLICANTID,
                   t.APPLICANTNAME,
                   t.INVITEDDEPARTMENTID,
                   t.INVITEDEXPERTID,
                   t.CONSULTATIONREQUIREMENTS,
                   t.APPLYDEPT,
                   t.AFSTATE,
                   t.REPLYTIME
                        ";
        }
        #endregion
        #region 数据 查询

        public IEnumerable<NURSE_CONSULTATIONEntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM YY_NURSE_CONSULTATION t ");
                return this.BaseRepository().FindList<NURSE_CONSULTATIONEntity>(strSql.ToString(), pagination);
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

        public IEnumerable<NURSE_CONSULTATIONEntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM YY_NURSE_CONSULTATION  t");
                return this.BaseRepository().FindList<NURSE_CONSULTATIONEntity>(strSql.ToString());
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
        public IQueryable<NURSE_CONSULTATIONEntity> IQueryRecord(Expression<Func<NURSE_CONSULTATIONEntity, bool>> condition)
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
                var strSql = "select seq_nurse_consultation.nextval from dual";
                return this.BaseRepository().FindTable(strSql).Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                return Guid.NewGuid().ToString("N");
            }
        }


        public NURSE_CONSULTATIONEntity GetEntity(string keyValue)
        {
            try
            {
                return this.BaseRepository().FindEntity<NURSE_CONSULTATIONEntity>(t => t.ID == keyValue);
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
                NURSE_CONSULTATIONEntity entity = new NURSE_CONSULTATIONEntity()
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
        public void SaveEntity(string keyValue,NURSE_CONSULTATIONEntity entity)
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

        public void UpdateEntity(NURSE_CONSULTATIONEntity entity)
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
