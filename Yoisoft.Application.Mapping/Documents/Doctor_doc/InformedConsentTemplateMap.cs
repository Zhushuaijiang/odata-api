using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Application.Patient;

namespace Yoisoft.Application.Mapping
{
    public class InformedConsentTemplateMap : EntityTypeConfiguration<InformedConsentTemplateEntity>
    {
        public InformedConsentTemplateMap()
        {
            #region 表、主键
            //表
            this.ToTable("YY_XY_MB");
            //主键
            this.HasKey(t => t.MBID);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
