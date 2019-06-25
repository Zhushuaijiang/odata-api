using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Application.Base;

namespace Yoisoft.Application.Mapping
{
   
    public class CODE_NATIONALITYMap : EntityTypeConfiguration<CODE_NATIONALITYEntity>
    {
        public CODE_NATIONALITYMap()
        {
            #region 表、主键
            //表
            this.ToTable("YY_CODE_NATIONALIT");
            //主键
            this.HasKey(t => t.NATIONALITYID);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
