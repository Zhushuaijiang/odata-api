using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Http;
using YoiEmr_Api.Base;
using Yoisoft.Application.Patient;
using Yoisoft.Application.Patient.Documents.Nurse_doc;
using Yoisoft.Application.Patient.Patient;
using Yoisoft.Util;

namespace YoiEmr_Api.Controllers.Api.Patient
{

    public class API_NURSE_THERMOMETERController : BaseApi
    {
        [HttpGet]
        public IHttpActionResult RecordQuery(string key)
        {
            NURSE_THERMOMETERService service = new NURSE_THERMOMETERService();
            try
            {

                var query = service.GetEntity(key);
                var packageEntity = query.PackageResult();
                return Json(packageEntity);
            }
            catch (Exception)
            {
                PackageResultEntity<object> packageResultEntity = new PackageResultEntity<object>()
                {
                    list = null,
                    msg = "failed"
                };
                return Json(packageResultEntity);
            }

        }
        /// <summary>
        /// ��ҳ�б�
        /// </summary>
        /// <param name="pagination"></param>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult RecordPagination(Pagination pagination)
        {
            NURSE_THERMOMETERService service = new NURSE_THERMOMETERService();
            try
            {
                var query = service.RecordPagination(pagination);
                var packageEntity = query.PackageEntityPaginations(pagination);
                return Json(packageEntity);
            }
            catch (Exception)
            {

                PackageResultEntity<object> packageResultEntity = new PackageResultEntity<object>()
                {
                    list = null,
                    msg = "failed"
                };
                return Json(packageResultEntity);
            }
        }

        [HttpGet]
        public ResultObject GetPtInfo(string patientId)
        {
            try
            {
                NURSE_THERMOMETERService service = new NURSE_THERMOMETERService();
                DataTable tb = service.SearchPtInfoByID(patientId);
                return new ResultObject(true, tb);
            }
            catch (Exception)
            {
                return new ResultObject(false, null);
            }

        }

        /// <summary>
        /// ��ȡ���µ�����
        /// </summary>
        /// <param name="patientid"></param>
        /// <param name="nw"></param>
        /// <returns></returns>
        [HttpGet]
        public ResultObject TemperatureChartData(string patientid, int nw)
        {
            try
            {
                #region ���ݿ�� thermometer��thermometer_record��ȡ���»����������¼�¼
                //var thermometerBll = new ThermometerBll();
                //��ȡ���µ�yy_nurse_thermometer�����µ���¼yy_nurse_thermometer_record���ݣ�����Dataset����Ժʱ��
                string str_inadmittime = "";
                NURSE_THERMOMETERService service = new NURSE_THERMOMETERService();
                var tempdata = service.SearchByPatientId(patientid, nw, ref str_inadmittime);
                var tb_thermometer = tempdata.Tables["thermometer"];
                var tb_thermometer_record = tempdata.Tables["thermometer_record"];
                #endregion
                #region ת����JSON��ʽ���±�����
                var temperatureChart = new TemperatureChart();
                #region ���˻������� ���������䡢�Ա𡢿Ʊ𣬴��š�סԺ�ŵ�
                System.Reflection.PropertyInfo[] properties = temperatureChart.GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
                if (properties.Length <= 0)
                {
                    return null;
                }
                foreach (System.Reflection.PropertyInfo item in properties)
                {
                    foreach (DataRow dr in tb_thermometer.Rows)
                    {
                        foreach (DataColumn dc in tb_thermometer.Columns)
                        {
                            if (dc.ColumnName.ToUpper() == item.Name.ToUpper())
                            {
                                item.SetValue(temperatureChart, dr[dc].ToString());
                                break;
                            }
                        }
                        break;
                    }
                }
                #endregion
                #region ÿ�ջ������ݣ���������������ߡ����ء�С�����������������㷽ʽ������      
                List<TemperatureSerieslist> temperlist = new List<TemperatureSerieslist>();
                foreach (DataRow dr in tb_thermometer.Rows)
                {
                    var serieslist = new TemperatureSerieslist();
                    foreach (System.Reflection.PropertyInfo item in serieslist.GetType().GetProperties())
                    {
                        foreach (DataColumn dc in tb_thermometer.Columns)
                        {
                            if (dc.ColumnName.ToUpper() == item.Name.ToUpper())
                            {
                                item.SetValue(serieslist, dr[dc].ToString());
                                break;
                            }
                        }
                    }
                    temperlist.Add(serieslist);
                }

                #endregion
                #region ÿ���¶ȡ��������ʵ����¼�¼
                List<Serieslist> serieslists = new List<Serieslist>();
                //2��ÿ�ջ�������
                //Ѫѹ����������������ߡ����ء�С�����������������㷽ʽ������                    
                foreach (DataRow dr in tb_thermometer_record.Rows)
                {
                    var serieslist = new Serieslist();
                    foreach (System.Reflection.PropertyInfo item in serieslist.GetType().GetProperties())
                    {
                        foreach (DataColumn dc in tb_thermometer_record.Columns)
                        {
                            if (dc.ColumnName.ToUpper() == item.Name.ToUpper())
                            {
                                item.SetValue(serieslist, dr[dc].ToString());
                                break;
                            }
                        }
                    }
                    serieslists.Add(serieslist);
                }

                int countTemperature = -1;//���������
                int countNomal = -1;//���������
                List<TemperatureSerieslist> temperatureSerieslist = new List<TemperatureSerieslist>();
                //��Ժ��ʼ���һ�ܣ�����ÿ�ܵ����ݣ�1-7��
                for (var i = (nw - 1) * 7; i < 7 * nw; i++)
                {
                    DateTime dt_inadmittime = Convert.ToDateTime(str_inadmittime).AddDays(i);
                    //��ȡ�������µ�һ����¼
                    var temperatureSeriesLast = temperlist.Where(c => Convert.ToDateTime(c.RECORDING_TIME).ToString("yyyyMMdd").
                     Equals(dt_inadmittime.ToString("yyyyMMdd"))).
                    OrderByDescending(c => Convert.ToDateTime(c.RECORDING_TIME))
                    .FirstOrDefault();
                    if (temperatureSeriesLast != null)
                    {
                        temperatureSeriesLast.SORTINDEX = countTemperature == -1 ? 0 : countTemperature / 1440 + 1;
                        temperatureSerieslist.Add(temperatureSeriesLast);
                    }
                    //1����һ�̶�
                    for (var j = 0; j < 60 * 24; j++)
                    {
                        countTemperature++;//�������
                        var newdatetime = new DateTime();
                        newdatetime = dt_inadmittime.AddMinutes(j);

                        var recordList = tb_thermometer_record.
                               AsEnumerable().
                               Where(c =>
                               c.Field<DateTime>("MEASUREMENT_TIME").ToString().
                               Equals(newdatetime.ToString())
                               ).
                               ToList();

                        //3����ֵ �¶����꼯�ϡ������������꼯�ϡ���ʹǿ��
                        serieslists.ForEach(c =>
                        {
                            // �¶����꼯�ϡ������������꼯�ϡ�������������ʹǿ�ȡ�Ѫѹ1��Ѫѹ2

                            List<PlainLevels> LisPlainLevel = new List<PlainLevels>();
                            List<TemperatureCoordinates> Liscoordinates = new List<TemperatureCoordinates>();
                            List<PluseCoordinates> LispluseCoordinates = new List<PluseCoordinates>();

                            if (c.MEASUREMENT_TIME.Equals(newdatetime.ToString()))
                            {
                                //����
                                var coordinates = new TemperatureCoordinates()
                                {
                                    x = countTemperature,
                                    y = recordList.FirstOrDefault().Field<string>("TEMPERATURE")

                                };
                                Liscoordinates.Add(coordinates);
                                c.temperatureCoordinates = Liscoordinates.ToArray();
                                //��������
                                var pluseCoordinates = new PluseCoordinates()
                                {
                                    x = countTemperature,
                                    y = Convert.ToString(recordList.FirstOrDefault().Field<string>("PULSE"))
                                };
                                if (pluseCoordinates.y != null)
                                {
                                    LispluseCoordinates.Add(pluseCoordinates);
                                    c.pluseCoordinates = LispluseCoordinates.ToArray();
                                }
                                //��ʹǿ��
                                var plainLevel = new PlainLevels()
                                {
                                    x = countTemperature,
                                    y = Convert.ToString(recordList.FirstOrDefault().Field<string>("PLAINLEVEL"))
                                };
                                if (plainLevel.y != null)
                                {
                                    LisPlainLevel.Add(plainLevel);
                                    c.plainLevels = LisPlainLevel.ToArray();
                                }

                            }
                        });
                    }
                    //1��6���̶�
                    for (var k = 0; k < 6; k++)
                    {
                        countNomal++;
                        var newdatetime = new DateTime();
                        if (k == 0)
                        {
                            newdatetime = dt_inadmittime.AddHours(2);
                        }
                        else
                        {
                            newdatetime = dt_inadmittime.AddHours(k * 4 + 2);
                        }
                        var recordList = tb_thermometer_record.
                               AsEnumerable().
                               Where(c =>
                               c.Field<DateTime>("MEASUREMENT_TIME").ToString().
                               Equals(newdatetime.ToString())
                               ).
                               ToList();
                        serieslists.ForEach(c =>
                        {
                            List<Numberofbreaths> Lisbreaths = new List<Numberofbreaths>();
                            List<BloodPress1> LisBloodPress1 = new List<BloodPress1>();
                            List<BloodPress2> LisBloodPress2 = new List<BloodPress2>();
                            List<Spo2> LisSpo2 = new List<Spo2>();
                            if (c.MEASUREMENT_TIME.Equals(newdatetime.ToString()))
                            {
                                //����
                                var numberofbreaths = new Numberofbreaths()
                                {
                                    x = countNomal,
                                    y = Convert.ToString(recordList.FirstOrDefault().Field<string>("BREATHING"))
                                };
                                if (numberofbreaths.y != null)
                                {
                                    Lisbreaths.Add(numberofbreaths);
                                    c.numberofbreaths = Lisbreaths.ToArray();

                                }
                                //Ѫѹ1
                                var bloodpress1 = new BloodPress1()
                                {
                                    x = countNomal % 2 != 0 ? countNomal - 1 : countNomal,
                                    y = Convert.ToString(recordList.FirstOrDefault().Field<string>("BLOOD_PRESSURE_1"))
                                };
                                if (bloodpress1.y != null)
                                {
                                    LisBloodPress1.Add(bloodpress1);
                                    c.bloodPress1 = LisBloodPress1.ToArray();

                                }
                                //Ѫѹ2
                                var bloodpress2 = new BloodPress2()
                                {
                                    x = countNomal % 2 == 0 ? countNomal + 1 : countNomal,
                                    y = Convert.ToString(recordList.FirstOrDefault().Field<string>("BLOOD_PRESSURE_2"))
                                };
                                if (bloodpress2.y != null)
                                {
                                    LisBloodPress2.Add(bloodpress2);
                                    c.bloodPress2 = LisBloodPress2.ToArray();

                                }
                                //SPO2
                                var Spo2 = new Spo2()
                                {
                                    x = countNomal % 2 == 0 ? countNomal + 1 : countNomal,
                                    y = Convert.ToString(recordList.FirstOrDefault().Field<string>("OXYGEN_SATURATION"))
                                };
                                if (Spo2.y != null)
                                {
                                    LisSpo2.Add(Spo2);
                                    c.spo2 = LisSpo2.ToArray();
                                }
                            }
                        });


                    }
                }
                #endregion
                temperatureChart.temperatureSerieslists = temperatureSerieslist.ToArray();
                temperatureChart.serieslists = serieslists.ToArray();
                #endregion
                //1����ȡ��������
                return new ResultObject(true, temperatureChart);
            }
            catch (Exception ex)
            {
                return new ResultObject(false, null);
            }
            finally
            {

            }

        }

        /// <summary>
        /// ���µ���¼
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public object TemperatureChartEdit()
        {
            var draw = HttpContext.Current.Request.Form["draw"];

            var patientid = HttpContext.Current.Request.Form["patientid"];
            var edittime = HttpContext.Current.Request.Form["edittime"];
            NURSE_THERMOMETERService service = new NURSE_THERMOMETERService();
            var tempdata = service.SearchByPtIdAndEdTime(patientid, edittime);
            // return new ResultObject(false, null);
            List<string[]> arrs = new List<string[]>();
            foreach (DataRow row in tempdata.Tables["thermometer_record"].Rows)
            {
                arrs.Add(new string[] {
                    row["MEASUREMENT_TIME"].ToString(),
                    row["TEMPERATURE"].ToString(),
                    row["PULSE"].ToString(),
                    row["BREATHING"].ToString(),
                    row["BLOOD_PRESSURE_1"].ToString()+"/"+   row["BLOOD_PRESSURE_2"].ToString(),
                    row["OXYGEN_SATURATION"].ToString(),
                    row["TYPE_MEASUREMENT"].ToString(),
                    row["SUPPLEMENTARY_DESCRIPTION"].ToString(),
                    string.Format("<a href='javascript:TemperatureRecord(\"{0}\");'>{1}</a><a href='javascript:DeleteRecord(\"{0}\");'>{2}</a><a href='#tab3' data-toggle='tab' id='nav3'>{3}</a>"
                            ,row["ID"].ToString(),"�༭","ɾ��","����")
                });
            }
            long count = 0;
            return Json(new TableObject(arrs, int.Parse(draw), count, count));

        }

        /// <summary>
        /// ��ȡ���µ��༭����
        /// </summary>
        /// <param name="patientid"></param>
        /// <param name="recordtime"></param>
        /// <returns></returns>
        [HttpGet]
        public object TemperatureRecordData(string ID)
        {

            NURSE_THERMOMETERService service = new NURSE_THERMOMETERService();
            var tempdata = service.SearchByID(ID);
            try
            {
                //return Json(tempdata);
                return new ResultObject(true, tempdata);
            }
            catch (Exception ex)
            {
                return new ResultObject(false, null);
            }

        }

        [HttpGet]
        public object TemperatureDataByPtIdAndEdTime(string patientid, string edtime)
        {
            try
            {
                NURSE_THERMOMETERService service = new NURSE_THERMOMETERService();
                var tempdata = service.SearchByPtIdAndEdTime(patientid, edtime);
                return new ResultObject(true, tempdata.Tables[0]);
            }
            catch (Exception ex)
            {
                return new ResultObject(false, null);
            }
        }

        /// <summary>
        /// ��ȡΨһ���з���ֵ
        /// </summary>
        /// <param name="patientid"></param>
        /// <param name="edtime"></param>
        /// <returns></returns>
        [HttpGet]
        public object ThermometerSqueueID(string patientid, string edtime)
        {
            try
            {
                NURSE_THERMOMETERService service = new NURSE_THERMOMETERService();
                var tempdata = service.SearchByThermometerSqueueID(patientid, edtime);
                return new ResultObject(true, tempdata);
            }
            catch (Exception ex)
            {
                return new ResultObject(false, null);
            }
        }
        [HttpGet]
        public object Temperature_Integralentry(string wardcode, string measurement_datetime, string sortBy, string sortType)
        {
            NURSE_THERMOMETERService service = new NURSE_THERMOMETERService();
            var tempdata = service.Temperature_Integralentry(wardcode, measurement_datetime, sortBy, sortType, PersonType.Normal);
            return tempdata;

        }
        [HttpPost]
        public ResultObject TemperatureBatchSave(Rootobject rootobject)
        {
            NURSE_THERMOMETERService service = new NURSE_THERMOMETERService();
           
            var isok = service.TemperatureBatchSave(rootobject.list.list_twd, rootobject.list.list_twjl);
            return new ResultObject(isok, null);
        }
        public class Rootobject
        {
            public List list { get; set; }
        }
        public class List
        {
            public List<NURSE_THERMOMETEREntity> list_twd { get; set; }
            public List<NURSE_THERMOMETER_RECORDEntity> list_twjl { get; set; }
        }
    }
}
