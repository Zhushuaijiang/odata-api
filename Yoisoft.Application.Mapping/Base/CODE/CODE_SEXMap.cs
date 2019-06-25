using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Application.Base;

namespace Yoisoft.Application.Mapping
{
    
    public class CODE_SEXMap : EntityTypeConfiguration<CODE_SEXEntity>
    {
        public CODE_SEXMap()
        {
            #region 表、主键
            //表
            this.ToTable("YY_CODE_SEX");
            //主键
            this.HasKey(t => t.SEXID);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
