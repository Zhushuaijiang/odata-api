using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Application.Patient;

namespace Yoisoft.Application.Mapping
{
    public class PatientMap : EntityTypeConfiguration<PatientEntity>
    {
        /// <summary>
        /// 病人信息数据库实体映射
        /// </summary>
        public PatientMap()
        {
            #region 表、主键
            //表
            this.ToTable("YY_SYS_PATIENT");
            //主键
            this.HasKey(t => t.PATIENTID);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
