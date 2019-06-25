using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Application.Patient;

namespace Yoisoft.Application.Mapping
{
    public class DOCTORS_24DEATH_RECORDMap : EntityTypeConfiguration<DOCTORS_24DEATH_RECORDEntity>
    {
        public DOCTORS_24DEATH_RECORDMap()
        {
            #region 表、主键
            //表
            this.ToTable("YY_DOCTORS_24DEATH_RECORD");
            //主键
            this.HasKey(t => t.PATIENTID);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
