using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Application.Base;

namespace Yoisoft.Application.Mapping
{
   
    public class CODE_RACEMap : EntityTypeConfiguration<CODE_RACEEntity>
    {
        public CODE_RACEMap()
        {
            #region 表、主键
            //表
            this.ToTable("YY_CODE_RACE");
            //主键
            this.HasKey(t => t.RACEID);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
