using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Application.Patient.Patient;

namespace Yoisoft.Application.Mapping
{
    public class MedicalRecordHomepageMap : EntityTypeConfiguration<MedicalRecordHomepageEntity>
    {
        /// <summary>
        /// 病人信息数据库实体映射
        /// </summary>
        public MedicalRecordHomepageMap()
        {
            #region 表、主键
            //表
            this.ToTable("YY_MEDICAL_RECORD_HOMEPAGE");
            //主键
            this.HasKey(t => t.ID);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
