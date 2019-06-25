using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Application.Base;

namespace Yoisoft.Application.Mapping
{
    public class CODE_AREAMap : EntityTypeConfiguration<CODE_AREAEntity>
    {
        public CODE_AREAMap()
        {
            #region 表、主键
            //表
            this.ToTable("YY_CODE_AREA");
            //主键
            this.HasKey(t => t.F_AREAID);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
