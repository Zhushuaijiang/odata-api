using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Application.Base;

namespace Yoisoft.Application.Mapping
{

    public class CODE_CASE_HISTORYSTYPEMap  : EntityTypeConfiguration<CODE_CASE_HISTORYSTYPEEntity>
    {
        public CODE_CASE_HISTORYSTYPEMap()
        {
            #region 表、主键
            //表
            this.ToTable("YY_CODE_CASE_HISTORYSTYPE");
            //主键
            this.HasKey(t => t.CASEHISTORYSTYPE);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
