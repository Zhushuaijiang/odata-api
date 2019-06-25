using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Yoisoft.Application.Patient;

namespace Yoisoft.Application.Mapping
{
   public class AdmiSsionRecordMap : EntityTypeConfiguration<AdmiSsionRecordEntity>
    {
        public AdmiSsionRecordMap()
        {
            #region 表、主键
            //表
            this.ToTable("YY_DOCTORS_ADMISSION_RECORD");
            //主键
            this.HasKey(t => t.PATIENTID);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
