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
    public class progress_noteService : RepositoryFactory
    {
        #region 属性 构造函数
        private string fieldSql;
        public progress_noteService()
        {
            fieldSql = @" t.ID,
                          t.PATIENTID,
                          t.WRITING_DOCTORS,
                          t.SUPERIOR_DOCTORS,
                          t.PTNAME,
                          t.RECORDTIME,
                          t.TYPEID,
                          t.WRITINGTIME,
                          t.DEL,
                          t.TYPENAME,
                          t.LINE,
                          t.WRITINGSTATE,
                          t.SHOWTIME,
                          t.DIRECTOR_DOCTORS,
                          t.ISXML,
                          t.SURGERYID,
                          t.DEPTCODE,
                          t.WARDCODE,
                          t.BEDNO,
                          t.RESERVED_SIGNATURE_LOCATION,
                          t.RESCUE_START_DATE,
                          t.SALVAGE_END_DATE,
                          t.CONDITION_CHANGE,
                          t.RESCUE_EFFECT,
                          t.OPERATION_OPERATION,
                          t.INSPECTION_INSPECTION,
                          t.MATTERS_NEEDING_ATTENTION,
                          t.LIST_OF_RESCUERS,
                          t.RECORD_CONTENT
                        
                        ";
        }
        #endregion
        #region 数据 查询

        public IEnumerable<progress_noteEntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_doctors_progress_note t ");
                return this.BaseRepository().FindList<progress_noteEntity>(strSql.ToString(), pagination);
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

        public IEnumerable<progress_noteEntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM yy_doctors_progress_note  t");
                return this.BaseRepository().FindList<progress_noteEntity>(strSql.ToString());
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
        public IQueryable<progress_noteEntity> IQueryRecord(Expression<Func<progress_noteEntity, bool>> condition)
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
                var strSql = "select SEQ_yy_doctors_progress_note.nextval from dual";
                return this.BaseRepository().FindTable(strSql).Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                return Guid.NewGuid().ToString("N");
            }
        }

        public progress_noteEntity GetEntity(string keyValue)
        {
            try
            {
                return this.BaseRepository().FindEntity<progress_noteEntity>(t => t.ID == keyValue);
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
                progress_noteEntity entity = new progress_noteEntity()
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
        public void SaveEntity(string keyValue,progress_noteEntity entity)
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

        public void UpdateEntity(progress_noteEntity entity)
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
