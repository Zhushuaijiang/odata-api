using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Application.Patient.Patient;
using Yoisoft.DataBase.Repository;
using Yoisoft.Util;

namespace Yoisoft.Application.Patient.Documents.Nurse_doc
{
    public class NURSE_THERMOMETERService : RepositoryFactory
    {
        #region 属性 构造函数
        private string fieldSql;
        public NURSE_THERMOMETERService()
        {
            fieldSql = @"     
                   t.ID,
                   t.NID,
                   t.DEFECATION,
                   t.FREQUENCY_DEFECATION,
                   t.STOOL_ENEMA,
                   t.AMOUNT_ENTRY,
                   t.AMOUNT_OUTPUT,
                   t.URINE_VOLUME,
                   t.WEIGHT,
                   t.XT,
                   t.FW,
                   t.HEIGHT,
                   t.OTHER,
                   t.RECORDING_TIME,
                   t.OPERATION_DAYS,
                   t.PATIENTID,
                   t.BABYID,
                   t.ACTUAL_RECORDING_TIME,
                   t.OUTPUT_TYPE,
                   t.AMOUNT_TIME,
                   t.BODY_TEMPERATURE_TYPE,
                   t.TRANSCUTANEOUS_BILIRUBIN,
                   t.FAST_BLOOD_SUGAR,
                   t.URINE,
                   t.AMOUNT_OUTPUT_HOUR,
                   t.AMOUNT_ENTRY_HOUR,
                   t.WAYOFWALK,
                   t.FREQUENCY_STOOL_ENEMA,
                   t.ABDOMINAL_CIRCUMFERENCE,
                   t.BEDTEMPERATURE
                        ";
        }
        #endregion
        #region 数据 查询

        public IEnumerable<NURSE_THERMOMETEREntity> RecordPagination(Pagination pagination)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM YY_NURSE_THERMOMETER t ");
                return this.BaseRepository().FindList<NURSE_THERMOMETEREntity>(strSql.ToString(), pagination);
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

        public IEnumerable<NURSE_THERMOMETEREntity> RecordQuery()
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM YY_NURSE_THERMOMETER t");
                return this.BaseRepository().FindList<NURSE_THERMOMETEREntity>(strSql.ToString());
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
        public IQueryable<NURSE_THERMOMETEREntity> IQueryRecord(Expression<Func<NURSE_THERMOMETEREntity, bool>> condition)
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
                var strSql = "select SEQ_YY_NURSE_THERMOMETER.nextval from dual";
                return this.BaseRepository().FindTable(strSql).Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                return Guid.NewGuid().ToString("N");
            }
        }

        public NURSE_THERMOMETEREntity GetEntity(string keyValue)
        {
            try
            {
                return this.BaseRepository().FindEntity<NURSE_THERMOMETEREntity>(t => t.ID == keyValue);
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

        //@zsj 2019.4.24
        public DataTable SearchPtInfoByID(string patientid)
        {
            try
            {
                string strSql = string.Format(@"select a.*,b.* from yy_sys_patient
                                a join YY_CODE_DEPT_WARD b on a.WARDCODE=b.WARDCODE where patientid='{0}'", patientid);
                DataTable dt_ptInfo = this.BaseRepository().FindTable(strSql);
                dt_ptInfo.TableName = "patientInfo";
                return dt_ptInfo;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public DataSet SearchByPatientId(string patientid, int nw, ref string inadmittime)
        {
            try
            {
                DataSet ds = new DataSet();

                //00018640
                string strSql = string.Format(@"select a.*,b.* from
                                        yy_sys_patient a 
                                        inner join 
                                        yy_nurse_thermometer b 
                                        on a.patientid=b.patientid
                                        where a.patientid='{0}'
                                        and to_date(to_char(b.recording_time,'yyyy-MM-dd'),'yyyy-MM-dd')
                                        >= to_date(to_char(a.inadmittime,'yyyy-MM-dd'),'yyyy-MM-dd')+ 7*({1}-1)
                                        and   to_date(to_char(b.recording_time,'yyyy-MM-dd'),'yyyy-MM-dd')
                                        -7*{1}<= to_date(to_char(a.inadmittime,'yyyy-MM-dd'),'yyyy-MM-dd')-1
                                        order by b.recording_time", patientid, nw);
                DataTable dt_thermometer = this.BaseRepository().FindTable(strSql);
                dt_thermometer.TableName = "thermometer";
                if (dt_thermometer.Rows.Count > 0)
                {
                    inadmittime = Convert.ToDateTime(dt_thermometer.Rows[0]["inadmittime"]).ToString("yyyy-MM-dd");
                }
                strSql = string.Format(@"select a.*,b.* from
                                        yy_sys_patient a 
                                        inner join 
                                        yy_nurse_thermometer_record b 
                                        on a.patientid=b.patientid
                                        where a.patientid='{0}'
                                        and to_date(to_char(b.MEASUREMENT_TIME,'yyyy-MM-dd'),'yyyy-MM-dd')
                                        >= to_date(to_char(a.inadmittime,'yyyy-MM-dd'),'yyyy-MM-dd')+ 7*({1}-1)
                                        and   to_date(to_char(b.MEASUREMENT_TIME,'yyyy-MM-dd'),'yyyy-MM-dd')
                                        -7*{1}<= to_date(to_char(a.inadmittime,'yyyy-MM-dd'),'yyyy-MM-dd')-1
                                        order by b.MEASUREMENT_TIME", patientid, nw);
                DataTable dt_thermometer_record = this.BaseRepository().FindTable(strSql);
                dt_thermometer_record.TableName = "thermometer_record";
                //返回入院时间
                if (dt_thermometer.Rows.Count > 0 && string.IsNullOrEmpty(inadmittime))
                {
                    inadmittime = Convert.ToDateTime(dt_thermometer_record.Rows[0]["inadmittime"]).ToString("yyyy-MM-dd");
                }
                ds.Tables.Add(dt_thermometer.Copy());
                ds.Tables.Add(dt_thermometer_record.Copy());
                return ds;
            }
            catch (Exception ex)
            {
                //LogHelper.WriteLog("ThermometerDal->SearchByPatientId", ex);
                return null;
            }



        }
        public DataSet SearchByTHERMOMETERID(string ID)
        {
            try
            {
                DataSet ds = new DataSet();
                string strSql = string.Format(@"select * from YY_NURSE_THERMOMETER 
                                    where 1=1 and ID='{0}'", ID);
                DataTable dt_thermometer = this.BaseRepository().FindTable(strSql);
                dt_thermometer.TableName = "thermometer";
                ds.Tables.Add(dt_thermometer.Copy());
                string patientid = "";
                string EditTime = "";
                string babyid = "";
                if (dt_thermometer.Rows.Count > 0)
                {
                    patientid = dt_thermometer.Rows[0]["patientid"].ToString();
                    EditTime = Convert.ToDateTime(dt_thermometer.Rows[0]["RECORDING_TIME"].ToString()).ToString("yyyy-MM-dd");
                    babyid = dt_thermometer.Rows[0]["BABYID"].ToString();
                }
                //体温单记录表
                strSql = string.Format(@"select * from
                YY_NURSE_THERMOMETER_RECORD where RECORD_CATEGORY='2' 
                and patientid='{0}' and to_char(MEASUREMENT_TIME,'yyyy-MM-dd')='{1}'", patientid, EditTime);
                if (!string.IsNullOrEmpty(babyid))
                {
                    strSql += string.Format(" and BABYID='{0}' order by MEASUREMENT_TIME desc", babyid);
                }
                else
                {
                    strSql += string.Format(" and BABYID is null order by MEASUREMENT_TIME desc");
                }
                DataTable dt_thermometer_record = this.BaseRepository().FindTable(strSql);
                dt_thermometer_record.TableName = "thermometer_record";
                ds.Tables.Add(dt_thermometer_record.Copy());
                // 体温表  YY_NURSE_THERMOMETER

                //死亡记录  

                //strSql = string.Format("select * from t_Zyys_Swjl where zyxh='{0}'", patientid);
                //DataTable dt_death = DbHelper.GetDataTable(DbHelper.QebemrConnstr, strSql);
                //dt_death.TableName = "death";

                ////补充记录
                //strSql = string.Format("select distinct mc from T_ZYHS_TWDBC whre type= 2 and patientid='{0}'", patientid);
                return ds;

            }
            catch (Exception ex)
            {
                //LogHelper.WriteLog("ThermometerDal->SearchByTHERMOMETERID", ex);
                return null;

            }
        }

        public DataSet SearchByPtIdAndEdTime(string patientid, string EditTime)
        {
            DataSet ds = new DataSet();
            string strSql = string.Format(@"select * from YY_NURSE_THERMOMETER 
                                    where 1=1 and patientid='{0}' and 
                                    to_char(RECORDING_TIME,'yyyy-MM-dd')='{1}'", patientid, EditTime);
            DataTable dt_thermometer = this.BaseRepository().FindTable(strSql);
            dt_thermometer.TableName = "thermometer";
            ds.Tables.Add(dt_thermometer.Copy());
            string babyid = "";
            if (dt_thermometer.Rows.Count > 0)
            {
                patientid = dt_thermometer.Rows[0]["patientid"].ToString();
                EditTime = Convert.ToDateTime(dt_thermometer.Rows[0]["RECORDING_TIME"].ToString()).ToString("yyyy-MM-dd");
                babyid = dt_thermometer.Rows[0]["BABYID"].ToString();
            }
            //体温单记录表
            strSql = string.Format(@"select * from
                YY_NURSE_THERMOMETER_RECORD where RECORD_CATEGORY='2' 
                and patientid='{0}' and to_char(MEASUREMENT_TIME,'yyyy-MM-dd')='{1}'", patientid, EditTime);
            if (!string.IsNullOrEmpty(babyid))
            {
                strSql += string.Format(" and BABYID='{0}' order by MEASUREMENT_TIME desc", babyid);
            }
            else
            {
                strSql += string.Format(" and BABYID is null order by MEASUREMENT_TIME desc");
            }
            DataTable dt_thermometer_record = this.BaseRepository().FindTable(strSql);
            dt_thermometer_record.TableName = "thermometer_record";
            ds.Tables.Add(dt_thermometer_record.Copy());
            return ds;
        }

        public string SearchByThermometerSqueueID(string patientId, string EditTime)
        {
            string retvalue = string.Empty;
            DataSet ds = new DataSet();
            string strSql = string.Format(@"select ID from YY_NURSE_THERMOMETER 
                                    where 1=1 and patientid='{0}' and 
                                    to_char(RECORDING_TIME,'yyyy-MM-dd')='{1}'", patientId, EditTime);
            DataTable dt_thermometer = this.BaseRepository().FindTable(strSql);
            if (dt_thermometer != null && dt_thermometer.Rows.Count > 0)
            {
                retvalue = dt_thermometer.Rows[0][0].ToString();
                return retvalue;
            }
            else
            {
                return string.Empty;
            }
        }
        public DataSet SearchByID(string ID)
        {
            DataSet ds = new DataSet();
            //体温单记录表
            string strSql = string.Format(@"select * from
                YY_NURSE_THERMOMETER_RECORD where ID='{0}'", ID);
            DataTable dt_thermometer_record = this.BaseRepository().FindTable(strSql);
            dt_thermometer_record.TableName = "THERMOMETER_RECORD";
            DataTable dt_thermometer = new DataTable();
            foreach (DataRow dr in dt_thermometer_record.Rows)
            {
                strSql = string.Format(@"select * from YY_NURSE_THERMOMETER
                where patientid='{0}' and to_char(recording_time,'yyyyMMdd')='{1}' 
                order by recording_time desc", dr["PATIENTID"],
                Convert.ToDateTime(dr["MEASUREMENT_TIME"]).ToString("yyyyMMdd"));
                dt_thermometer = this.BaseRepository().FindTable(strSql);
                dt_thermometer.TableName = "THERMOMETER";
                break;
            }

            ds.Tables.Add(dt_thermometer.Copy());
            ds.Tables.Add(dt_thermometer_record.Copy());
            return ds;
        }

      
        /// <summary>
        /// 体温单整体录入数据
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        public DataTable Temperature_Integralentry(string wardcode, string measurement_time, string sortBy, string sortType, PersonType type)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(string.Format(@"select br.*,twjl.*,twjl.id as twjlid,twd.*,twd.id as twdid,zk.*,zk.id as zkid from 
                yy_sys_patient br,yy_nurse_thermometer_record twjl,yy_nurse_thermometer twd,yy_doctors_departtrans zk where
                br.stateid=1 and br.wardcode='{0}' and br.patientid = zk.patientid(+) and br.patientid=twjl.patientid(+) and br.patientid=twd.patientid(+) 
                and to_char(twjl.measurement_time(+),'YYYY-MM-DD hh24:mi:ss')='{1}' and to_char(twd.recording_time(+),'YYYY-MM-DD')='{2}' and zk.inwardid(+)='{3}'
                and zk.inwardid(+)!=zk.outwardid(+) and twjl.type_measurement(+)='0' and twd.babyid(+) is null and twjl.babyid(+) is null"
            , wardcode, measurement_time, measurement_time.Substring(0, 10), wardcode));
            if (sortBy != "")
            {
                stringBuilder.Append(" order by br.bedno " + sortType);
            }
            DataTable dt_Integralentry = this.BaseRepository().FindTable(stringBuilder.ToString());
            dt_Integralentry.TableName = "Integralentry";
            return dt_Integralentry;
        }

        #endregion
        #region 操作数据
        public void PhysicalDelRecord(string keyValue)
        {
            try
            {
                NURSE_THERMOMETEREntity entity = new NURSE_THERMOMETEREntity()
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
        public void SaveEntity(string keyValue, NURSE_THERMOMETEREntity entity)
        {
            try
            {

                entity.ID = GetKey();
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

        public void UpdateEntity(NURSE_THERMOMETEREntity entity)
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


        public bool TemperatureBatchSave(List<NURSE_THERMOMETEREntity> list_twd,
            List<NURSE_THERMOMETER_RECORDEntity> list_twjl)
        {
            NURSE_THERMOMETER_RECORDService service = new NURSE_THERMOMETER_RECORDService();
            var Repository = this.BaseRepository().BeginTrans();
            try
            {
                
                foreach (var twd in list_twd)
                {
                    if (twd.ID == "" || twd.ID == null)
                    {
                        twd.ID = GetKey();
                        this.BaseRepository().Insert(twd);
                    }
                    else
                    {
                        
                        this.BaseRepository().Update(twd);
                    }
                }       
                foreach (var twjl in list_twjl)
                {
                    if (twjl.ID == "" || twjl.ID == null)
                    {
                        twjl.ID = service.GetKey();
                        this.BaseRepository().Insert(twjl);
                    }
                    else
                    {
                        this.BaseRepository().Update(twjl);
                    }

                }
                Repository.Commit();
                return true;
            }
            catch (Exception ex)
            {
                Repository.Rollback();
                return false;
            }
           
        }
        #endregion
    }
}
