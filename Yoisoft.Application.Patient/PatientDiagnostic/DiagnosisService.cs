using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.DataBase.Repository;
using Yoisoft.Util;

namespace Yoisoft.Application.Patient.PatientDiagnostic
{
    public class DiagnosisService : RepositoryFactory
    {
        #region 属性 构造函数
        private string fieldSql;
        public DiagnosisService()
        {
            fieldSql = @"     
                 t.ID,
                 t.PATIENTID,
                 t.DXINDEX,
                 t.DXCODE,
                 t.ICD,
                 t.DXNAME,
                 t.DXNAMESUP,
                 t.DXDIAGNOSIS,
                 t.RESULTID,
                 t.DXCATEGORY,
                 t.DOCTORID,
                 t.WRITINGTIME,
                 t.DXTIME,
                 t.REPORTCARD_TYPE,
                 t.REPORTEDCARD_TYPE,
                 t.UNREPORTED_REASON,
                 t.FATHERID,
                 t.OPERATIONID,
                 t.MAINOPERATIONID,
                 t.DXSTATE,
                 t.DXTYPE,
                 t.ADMISSION_IS,
                 t.SYNDROMESICD,
                 t.SYNDROMESNAME,
                 t.MAINDX,
                 t.DXPOSITION,
                 t.ANATOMYNAME
                        ";
        }
        #endregion
        #region 数据 查询

        public IEnumerable<DiagnosisEntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM YY_DX_DXTAB t ");
                return this.BaseRepository().FindList<DiagnosisEntity>(strSql.ToString(), pagination);
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

        public IEnumerable<DiagnosisEntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM YY_DX_DXTAB t");
                return this.BaseRepository().FindList<DiagnosisEntity>(strSql.ToString());
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
        public IQueryable<DiagnosisEntity> IQueryRecord(Expression<Func<DiagnosisEntity, bool>> condition)
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
        /// <summary>
        /// 获取主键
        /// </summary>
        /// <returns></returns>
        public string GetKey()
        {
            try
            {
                var strSql = "select seq_yy_dx_dxtab.nextval from dual";
                return this.BaseRepository().FindTable(strSql).Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                return Guid.NewGuid().ToString("N");
            }
        }


        public DiagnosisEntity GetEntity(string keyValue)
        {
            try
            {
                return this.BaseRepository().FindEntity<DiagnosisEntity>(t => t.ID == keyValue);
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
                DiagnosisEntity entity = new DiagnosisEntity()
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
        public void SaveEntity(string keyValue,DiagnosisEntity entity)
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

        public void UpdateEntity(DiagnosisEntity entity)
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
